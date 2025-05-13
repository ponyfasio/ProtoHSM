namespace ProtoHSM.Compras
{
    partial class nuevaCompraView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            comboProveedor1 = new comboProveedor();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1077, 100);
            panel1.TabIndex = 76;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SlateGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 90);
            panel2.Name = "panel2";
            panel2.Size = new Size(1077, 10);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 84);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(83, 5);
            label2.Name = "label2";
            label2.Size = new Size(418, 78);
            label2.TabIndex = 8;
            label2.Text = "Nueva Compra";
            // 
            // label1
            // 
            label1.Font = new Font("Calibri", 14.25F);
            label1.Location = new Point(23, 128);
            label1.Name = "label1";
            label1.Size = new Size(135, 29);
            label1.TabIndex = 77;
            label1.Text = "Proveedor:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // comboProveedor1
            // 
            comboProveedor1.DisplayMember = "Nombre";
            comboProveedor1.DropDownHeight = 92;
            comboProveedor1.Font = new Font("Calibri", 14.25F);
            comboProveedor1.FormattingEnabled = true;
            comboProveedor1.IntegralHeight = false;
            comboProveedor1.Location = new Point(164, 126);
            comboProveedor1.MaxDropDownItems = 5;
            comboProveedor1.Name = "comboProveedor1";
            comboProveedor1.Size = new Size(337, 31);
            comboProveedor1.TabIndex = 78;
            comboProveedor1.ValueMember = "ProveedorID";
            // 
            // nuevaCompraView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 645);
            Controls.Add(comboProveedor1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "nuevaCompraView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HSM: Nueva Compra";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private comboProveedor comboProveedor1;
    }
}