namespace ej1
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
            lsbListar = new ListBox();
            btnListar = new Button();
            btnAgregar = new Button();
            btnVer = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // lsbListar
            // 
            lsbListar.FormattingEnabled = true;
            lsbListar.ItemHeight = 28;
            lsbListar.Location = new Point(12, 12);
            lsbListar.Name = "lsbListar";
            lsbListar.Size = new Size(473, 424);
            lsbListar.TabIndex = 0;
            lsbListar.Visible = false;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(498, 42);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(148, 62);
            btnListar.TabIndex = 1;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(498, 122);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(148, 62);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnVer
            // 
            btnVer.Location = new Point(498, 200);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(148, 62);
            btnVer.TabIndex = 3;
            btnVer.Text = "Ver";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(498, 280);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(148, 62);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(498, 362);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(148, 62);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 454);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnVer);
            Controls.Add(btnAgregar);
            Controls.Add(btnListar);
            Controls.Add(lsbListar);
            Font = new Font("Segoe UI", 15F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Ejercicio 1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lsbListar;
        private Button btnListar;
        private Button btnAgregar;
        private Button btnVer;
        private Button btnModificar;
        private Button btnEliminar;
    }
}
