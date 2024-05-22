namespace CapaVisual
{
    partial class frmVehiculos
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
            GuardarVehiculo = new Button();
            PlacaTextBox = new TextBox();
            ValorTextBox = new TextBox();
            AñoTextBox = new TextBox();
            CilindrajeTextBox = new TextBox();
            ModeloTextBox = new TextBox();
            ColorTextBox = new TextBox();
            DNITextBox = new TextBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ModificarVehiculo = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // GuardarVehiculo
            // 
            GuardarVehiculo.Location = new Point(489, 250);
            GuardarVehiculo.Name = "GuardarVehiculo";
            GuardarVehiculo.Size = new Size(126, 44);
            GuardarVehiculo.TabIndex = 0;
            GuardarVehiculo.Text = "Guardar Vehiculo";
            GuardarVehiculo.UseVisualStyleBackColor = true;
            GuardarVehiculo.Click += GuardarVehiculo_Click;
            // 
            // PlacaTextBox
            // 
            PlacaTextBox.Location = new Point(97, 52);
            PlacaTextBox.Name = "PlacaTextBox";
            PlacaTextBox.Size = new Size(100, 23);
            PlacaTextBox.TabIndex = 1;
            // 
            // ValorTextBox
            // 
            ValorTextBox.Location = new Point(97, 81);
            ValorTextBox.Name = "ValorTextBox";
            ValorTextBox.Size = new Size(100, 23);
            ValorTextBox.TabIndex = 2;
            // 
            // AñoTextBox
            // 
            AñoTextBox.Location = new Point(97, 110);
            AñoTextBox.Name = "AñoTextBox";
            AñoTextBox.Size = new Size(100, 23);
            AñoTextBox.TabIndex = 3;
            // 
            // CilindrajeTextBox
            // 
            CilindrajeTextBox.Location = new Point(97, 139);
            CilindrajeTextBox.Name = "CilindrajeTextBox";
            CilindrajeTextBox.Size = new Size(100, 23);
            CilindrajeTextBox.TabIndex = 4;
            // 
            // ModeloTextBox
            // 
            ModeloTextBox.Location = new Point(97, 168);
            ModeloTextBox.Name = "ModeloTextBox";
            ModeloTextBox.Size = new Size(100, 23);
            ModeloTextBox.TabIndex = 5;
            // 
            // ColorTextBox
            // 
            ColorTextBox.Location = new Point(97, 197);
            ColorTextBox.Name = "ColorTextBox";
            ColorTextBox.Size = new Size(100, 23);
            ColorTextBox.TabIndex = 6;
            // 
            // DNITextBox
            // 
            DNITextBox.Location = new Point(97, 226);
            DNITextBox.Name = "DNITextBox";
            DNITextBox.Size = new Size(100, 23);
            DNITextBox.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.RetrocerderIcon;
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 60);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 19;
            label1.Text = "Placa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 84);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 20;
            label2.Text = "Valor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 110);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 21;
            label3.Text = "Año";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 141);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 22;
            label4.Text = "Cilindraje";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 178);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 23;
            label5.Text = "Modelo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 208);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 24;
            label6.Text = "Color";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 235);
            label7.Name = "label7";
            label7.Size = new Size(27, 15);
            label7.TabIndex = 25;
            label7.Text = "DNI";
            // 
            // ModificarVehiculo
            // 
            ModificarVehiculo.Location = new Point(489, 311);
            ModificarVehiculo.Name = "ModificarVehiculo";
            ModificarVehiculo.Size = new Size(126, 48);
            ModificarVehiculo.TabIndex = 26;
            ModificarVehiculo.Text = "Modificar Vehiculo";
            ModificarVehiculo.UseVisualStyleBackColor = true;
            ModificarVehiculo.Click += ModificarVehiculo_Click;
            // 
            // frmVehiculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 392);
            Controls.Add(ModificarVehiculo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(DNITextBox);
            Controls.Add(ColorTextBox);
            Controls.Add(ModeloTextBox);
            Controls.Add(CilindrajeTextBox);
            Controls.Add(AñoTextBox);
            Controls.Add(ValorTextBox);
            Controls.Add(PlacaTextBox);
            Controls.Add(GuardarVehiculo);
            Name = "frmVehiculos";
            Text = "frmVehiculos";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GuardarVehiculo;
        private TextBox PlacaTextBox;
        private TextBox ValorTextBox;
        private TextBox AñoTextBox;
        private TextBox CilindrajeTextBox;
        private TextBox ModeloTextBox;
        private TextBox ColorTextBox;
        private TextBox DNITextBox;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button ModificarVehiculo;
    }
}