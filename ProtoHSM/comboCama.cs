using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using ProtoHSM.Models;

namespace ProtoHSM
{
    public partial class comboCama : ComboBox
    {
        private const int MaxVisibleItems = 5;
        private List<CamaDisponibleDTO> _originalItems = new();
        private bool _filtering;

        // Ocultamos Items/DataSource al diseñador
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new object DataSource
        {
            get => base.DataSource;
            set => base.DataSource = value;
        }
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new ObjectCollection Items => base.Items;

        public comboCama()
        {
            DropDownStyle = ComboBoxStyle.DropDown;
            AutoCompleteMode = AutoCompleteMode.None;
            AutoCompleteSource = AutoCompleteSource.None;

            MaxDropDownItems = MaxVisibleItems;
            IntegralHeight = false;
            DropDownHeight = ItemHeight * MaxVisibleItems
                             + SystemInformation.BorderSize.Height * 2;
        }

        /// <summary>
        /// Carga las camas disponibles del tipo indicado.
        /// </summary>
        public void LoadItems(int tipoCamaID)
        {
            var ctrl = new Controller();
            _originalItems = ctrl.ObtenerCamasDisponibles(tipoCamaID);

            DisplayMember = nameof(CamaDisponibleDTO.NumeroCama);
            ValueMember = nameof(CamaDisponibleDTO.CamaID);

            _filtering = true;
            DataSource = _originalItems.ToList();
            SelectedIndex = -1;
            _filtering = false;
        }

        /// <summary>
        /// Se dispara cada vez que cambias el texto: filtramos y abrimos dropdown.
        /// </summary>
        protected override void OnTextUpdate(EventArgs e)
        {
            base.OnTextUpdate(e);
            if (_filtering) return;

            var text = Text;
            var lista = string.IsNullOrEmpty(text)
                ? _originalItems
                : _originalItems
                    .Where(c => c.NumeroCama
                        .IndexOf(text, StringComparison.CurrentCultureIgnoreCase) >= 0)
                    .ToList();

            _filtering = true;
            var pos = SelectionStart;

            BeginUpdate();
            DataSource = lista;
            EndUpdate();

            Text = text;
            SelectionStart = pos;
            SelectionLength = 0;
            _filtering = false;

            DroppedDown = true;
        }

        [Browsable(false)]
        public CamaDisponibleDTO CamaSeleccionada => SelectedItem as CamaDisponibleDTO;

        // Opcional: Supr para limpiar
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                _filtering = true;
                DataSource = _originalItems.ToList();
                SelectedIndex = -1;
                Text = string.Empty;
                _filtering = false;

                DroppedDown = true;
                SelectionStart = 0;
                e.Handled = true;
                return;
            }

            base.OnKeyDown(e);
        }
    }
}
