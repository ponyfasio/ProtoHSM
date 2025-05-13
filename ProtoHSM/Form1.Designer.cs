namespace ProtoHSM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel2 = new Panel();
            label5 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            textPass = new TextBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            textUser = new TextBox();
            button1 = new Button();
            label3 = new Label();
            textBox3 = new TextBox();
            panel4 = new Panel();
            listAvisos = new ListBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.AliceBlue;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textPass);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(textUser);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(226, 538);
            panel2.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F);
            label5.Location = new Point(51, 477);
            label5.Name = "label5";
            label5.Size = new Size(91, 19);
            label5.TabIndex = 4;
            label5.Text = "¿Problemas?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 267);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 3;
            label2.Text = "Contraseña";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(35, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 145);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F);
            label4.Location = new Point(52, 496);
            label4.Name = "label4";
            label4.Size = new Size(90, 19);
            label4.TabIndex = 3;
            label4.Text = "Contactanos";
            // 
            // textPass
            // 
            textPass.Location = new Point(35, 292);
            textPass.Name = "textPass";
            textPass.Size = new Size(146, 23);
            textPass.TabIndex = 2;
            textPass.Text = "1234";
            textPass.TextAlign = HorizontalAlignment.Center;
            textPass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 206);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(148, 480);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 35);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // textUser
            // 
            textUser.Location = new Point(35, 231);
            textUser.Name = "textUser";
            textUser.Size = new Size(146, 23);
            textUser.TabIndex = 1;
            textUser.Text = "admin";
            textUser.TextAlign = HorizontalAlignment.Center;
            textUser.KeyPress += textUser_KeyPress;
            // 
            // button1
            // 
            button1.Location = new Point(71, 346);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Ingresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(257, 11);
            label3.Name = "label3";
            label3.Size = new Size(207, 29);
            label3.TabIndex = 2;
            label3.Text = "Avisos importantes:";
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(257, 60);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(479, 436);
            textBox3.TabIndex = 3;
            textBox3.Text = resources.GetString("textBox3.Text");
            // 
            // panel4
            // 
            panel4.BackColor = Color.SlateGray;
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(226, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(12, 538);
            panel4.TabIndex = 4;
            // 
            // listAvisos
            // 
            listAvisos.FormattingEnabled = true;
            listAvisos.Location = new Point(257, 60);
            listAvisos.Name = "listAvisos";
            listAvisos.Size = new Size(479, 439);
            listAvisos.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(769, 538);
            Controls.Add(listAvisos);
            Controls.Add(panel4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(panel2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HSM: Inicio";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox textPass;
        private Label label1;
        private TextBox textUser;
        private Label label3;
        private TextBox textBox3;
        private Panel panel4;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox2;
        private ListBox listAvisos;
    }
}
