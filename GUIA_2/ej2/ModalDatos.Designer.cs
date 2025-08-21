namespace ej1
{
    partial class ModalDatos
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
            label1 = new Label();
            label2 = new Label();
            tbDNI = new TextBox();
            tbNombre = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 46);
            label1.Name = "label1";
            label1.Size = new Size(46, 28);
            label1.TabIndex = 0;
            label1.Text = "DNI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 97);
            label2.Name = "label2";
            label2.Size = new Size(85, 28);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // tbDNI
            // 
            tbDNI.Location = new Point(210, 43);
            tbDNI.Name = "tbDNI";
            tbDNI.Size = new Size(261, 34);
            tbDNI.TabIndex = 2;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(210, 94);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(261, 34);
            tbNombre.TabIndex = 3;
            // 
            // btnAceptar
            // 
            btnAceptar.DialogResult = DialogResult.OK;
            btnAceptar.Location = new Point(136, 160);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(161, 49);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(365, 160);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(161, 49);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // ModalDatos
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 253);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(tbNombre);
            Controls.Add(tbDNI);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "ModalDatos";
            Text = "Datos de la persona";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        public TextBox tbDNI;
        public TextBox tbNombre;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}