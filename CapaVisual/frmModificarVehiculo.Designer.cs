namespace CapaVisual
{
    partial class frmModificarVehiculo
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
            BuscarPlaca = new Button();
            GuardarV = new Button();
            EliminarVehiculo = new Button();
            MVPlacaBuscarTextBox = new TextBox();
            MVPlacaTextBox = new TextBox();
            MVValorTextBox = new TextBox();
            MVAñoTextBox = new TextBox();
            MVCilindrajeTextBox = new TextBox();
            MVModeloTextBox = new TextBox();
            MVColorTextBox = new TextBox();
            MVDNITextBox = new TextBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // BuscarPlaca
            // 
            BuscarPlaca.Location = new Point(487, 24);
            BuscarPlaca.Name = "BuscarPlaca";
            BuscarPlaca.Size = new Size(112, 36);
            BuscarPlaca.TabIndex = 0;
            BuscarPlaca.Text = "Buscar";
            BuscarPlaca.UseVisualStyleBackColor = true;
            BuscarPlaca.Click += BuscarPlaca_Click;
            // 
            // GuardarV
            // 
            GuardarV.Location = new Point(467, 269);
            GuardarV.Name = "GuardarV";
            GuardarV.Size = new Size(146, 38);
            GuardarV.TabIndex = 1;
            GuardarV.Text = "Guargar Modificacion";
            GuardarV.UseVisualStyleBackColor = true;
            GuardarV.Click += GuardarV_Click;
            // 
            // EliminarVehiculo
            // 
            EliminarVehiculo.Location = new Point(464, 322);
            EliminarVehiculo.Name = "EliminarVehiculo";
            EliminarVehiculo.Size = new Size(154, 27);
            EliminarVehiculo.TabIndex = 2;
            EliminarVehiculo.Text = "Eliminar Vehiculo";
            EliminarVehiculo.UseVisualStyleBackColor = true;
            EliminarVehiculo.Click += EliminarVehiculo_Click;
            // 
            // MVPlacaBuscarTextBox
            // 
            MVPlacaBuscarTextBox.Location = new Point(291, 23);
            MVPlacaBuscarTextBox.Name = "MVPlacaBuscarTextBox";
            MVPlacaBuscarTextBox.Size = new Size(172, 23);
            MVPlacaBuscarTextBox.TabIndex = 3;
            // 
            // MVPlacaTextBox
            // 
            MVPlacaTextBox.Location = new Point(62, 66);
            MVPlacaTextBox.Name = "MVPlacaTextBox";
            MVPlacaTextBox.Size = new Size(89, 23);
            MVPlacaTextBox.TabIndex = 4;
            // 
            // MVValorTextBox
            // 
            MVValorTextBox.Location = new Point(73, 100);
            MVValorTextBox.Name = "MVValorTextBox";
            MVValorTextBox.Size = new Size(100, 23);
            MVValorTextBox.TabIndex = 5;
            // 
            // MVAñoTextBox
            // 
            MVAñoTextBox.Location = new Point(70, 155);
            MVAñoTextBox.Name = "MVAñoTextBox";
            MVAñoTextBox.Size = new Size(100, 23);
            MVAñoTextBox.TabIndex = 6;
            // 
            // MVCilindrajeTextBox
            // 
            MVCilindrajeTextBox.Location = new Point(72, 195);
            MVCilindrajeTextBox.Name = "MVCilindrajeTextBox";
            MVCilindrajeTextBox.Size = new Size(100, 23);
            MVCilindrajeTextBox.TabIndex = 7;
            // 
            // MVModeloTextBox
            // 
            MVModeloTextBox.Location = new Point(90, 240);
            MVModeloTextBox.Name = "MVModeloTextBox";
            MVModeloTextBox.Size = new Size(100, 23);
            MVModeloTextBox.TabIndex = 8;
            // 
            // MVColorTextBox
            // 
            MVColorTextBox.Location = new Point(94, 275);
            MVColorTextBox.Name = "MVColorTextBox";
            MVColorTextBox.Size = new Size(107, 23);
            MVColorTextBox.TabIndex = 9;
            // 
            // MVDNITextBox
            // 
            MVDNITextBox.Location = new Point(110, 327);
            MVDNITextBox.Name = "MVDNITextBox";
            MVDNITextBox.Size = new Size(100, 23);
            MVDNITextBox.TabIndex = 10;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.RetrocerderIcon;
            pictureBox4.Location = new Point(12, 9);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(41, 37);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 21;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // frmModificarVehiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 380);
            Controls.Add(pictureBox4);
            Controls.Add(MVDNITextBox);
            Controls.Add(MVColorTextBox);
            Controls.Add(MVModeloTextBox);
            Controls.Add(MVCilindrajeTextBox);
            Controls.Add(MVAñoTextBox);
            Controls.Add(MVValorTextBox);
            Controls.Add(MVPlacaTextBox);
            Controls.Add(MVPlacaBuscarTextBox);
            Controls.Add(EliminarVehiculo);
            Controls.Add(GuardarV);
            Controls.Add(BuscarPlaca);
            Name = "frmModificarVehiculo";
            Text = "frmModificarVehiculo";
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BuscarPlaca;
        private Button GuardarV;
        private Button EliminarVehiculo;
        private TextBox MVPlacaBuscarTextBox;
        private TextBox MVPlacaTextBox;
        private TextBox MVValorTextBox;
        private TextBox MVAñoTextBox;
        private TextBox MVCilindrajeTextBox;
        private TextBox MVModeloTextBox;
        private TextBox MVColorTextBox;
        private TextBox MVDNITextBox;
        private PictureBox pictureBox4;
    }
}