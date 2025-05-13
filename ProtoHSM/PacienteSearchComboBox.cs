using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using ProtoHSM.Models;  // Para PacienteComboDTO

namespace ProtoHSM
{
    public partial class PacienteSearchComboBox : ComboBox
    {

        const int MaxVisibleItems = 5;
        private List<PacienteComboDTO> _originalItems = new();
        private bool _filtering;
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new object DataSource
        {
            get => base.DataSource;
            set => base.DataSource = value;
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new ObjectCollection Items
        {
            get => base.Items;
        }

        public PacienteSearchComboBox()
        {
            // 1) Configuración básica
            DropDownStyle = ComboBoxStyle.DropDown;
            AutoCompleteMode = AutoCompleteMode.None;
            AutoCompleteSource = AutoCompleteSource.None;

            // 2) Limitar altura a 5 ítems
            MaxDropDownItems = MaxVisibleItems;
            IntegralHeight = false;
            DropDownHeight = ItemHeight * MaxVisibleItems
                             + SystemInformation.BorderSize.Height * 2;

            // 3) Suscribir eventos
            TextChanged += OnTextChangedFilter;
           
            Click += (s, e) => OpenDropDown();
            KeyDown += (s, e) => { if (!DroppedDown) OpenDropDown(); };

            // 4) Carga inicial
            LoadItems();
        }

        private void OpenDropDown()
        {
            DroppedDown = true;
            // opcional: que el cursor quede al final
            SelectionStart = Text.Length;
        }

        /// <summary>
        /// Carga tus pacientes desde el SP a _originalItems
        /// </summary>
        public void LoadItems()
        {
            var ctrl = new Controller();
            _originalItems = ctrl.ObtenerPacientesDTO();

            DisplayMember = nameof(PacienteComboDTO.Nombre);
            ValueMember = nameof(PacienteComboDTO.PacienteID);

            _filtering = true;
            DataSource = _originalItems.ToList();
            SelectedIndex = -1;
            _filtering = false;
        }

        private void OnTextChangedFilter(object sender, EventArgs e)
        {
            if (_filtering) return;
            // Solo filtrar si la lista está desplegada
            if (DroppedDown)
                FilterItems();
        }

        private void FilterItems()
        {
            // 1) Texto tal cual, sin Trim()
            var texto = Text;

            // 2) Filtrado (ahora sí permitiendo espacios)
            var lista = string.IsNullOrEmpty(texto)
                ? _originalItems
                : _originalItems
                    .Where(p =>
                       p.Nombre.IndexOf(texto, StringComparison.CurrentCultureIgnoreCase) >= 0
                    )
                    .ToList();

            // 3) Reasignar DataSource sin perder el texto
            _filtering = true;
            var caretPos = SelectionStart;

            BeginUpdate();
            DataSource = lista;
            EndUpdate();

            // 4) Restaurar texto y posición de cursor
            Text = texto;
            SelectionStart = caretPos;
            SelectionLength = 0;
            _filtering = false;
        }

        [Browsable(false)]
        public PacienteComboDTO PacienteSeleccionado
            => SelectedItem as PacienteComboDTO;

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                // Limpiar selección y texto
                _filtering = true;
                DataSource = _originalItems.ToList();
                SelectedIndex = -1;
                Text = string.Empty;
                _filtering = false;

                // abrir dropdown y colocar cursor al inicio
                DroppedDown = true;
                SelectionStart = 0;
                e.Handled = true;
                return;
            }

            // Comportamiento normal: abrir dropdown al teclear
            if (!DroppedDown)
                DroppedDown = true;

            base.OnKeyDown(e);
        }
    }
}
