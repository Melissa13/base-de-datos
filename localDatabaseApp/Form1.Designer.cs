namespace localDatabaseApp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.usuarios = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.labelMatricula = new System.Windows.Forms.Label();
            this.matriculaInt = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.labelApellido = new System.Windows.Forms.Label();
            this.textPass = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usuarios
            // 
            this.usuarios.FormattingEnabled = true;
            this.usuarios.ItemHeight = 31;
            this.usuarios.Location = new System.Drawing.Point(100, 167);
            this.usuarios.Name = "usuarios";
            this.usuarios.Size = new System.Drawing.Size(298, 252);
            this.usuarios.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(232, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 38);
            this.textBox1.TabIndex = 2;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(175, 100);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(128, 44);
            this.Search.TabIndex = 3;
            this.Search.Text = "Buscar";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(568, 341);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(119, 44);
            this.buttonInsert.TabIndex = 4;
            this.buttonInsert.Text = "Insertar";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // labelMatricula
            // 
            this.labelMatricula.AutoSize = true;
            this.labelMatricula.Location = new System.Drawing.Point(466, 167);
            this.labelMatricula.Name = "labelMatricula";
            this.labelMatricula.Size = new System.Drawing.Size(131, 32);
            this.labelMatricula.TabIndex = 5;
            this.labelMatricula.Text = "matricula";
            this.labelMatricula.Click += new System.EventHandler(this.label2_Click);
            // 
            // matriculaInt
            // 
            this.matriculaInt.Location = new System.Drawing.Point(625, 167);
            this.matriculaInt.Name = "matriculaInt";
            this.matriculaInt.Size = new System.Drawing.Size(158, 38);
            this.matriculaInt.TabIndex = 6;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(625, 211);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(158, 38);
            this.textNombre.TabIndex = 8;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(466, 211);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(115, 32);
            this.labelNombre.TabIndex = 7;
            this.labelNombre.Text = "Nombre";
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(625, 255);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(158, 38);
            this.textApellido.TabIndex = 10;
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(466, 255);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(119, 32);
            this.labelApellido.TabIndex = 9;
            this.labelApellido.Text = "Apellido";
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(625, 299);
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(158, 38);
            this.textPass.TabIndex = 12;
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(466, 299);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(162, 32);
            this.labelPass.TabIndex = 11;
            this.labelPass.Text = "Contraseña";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 637);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.matriculaInt);
            this.Controls.Add(this.labelMatricula);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usuarios);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Sql database access";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox usuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Label labelMatricula;
        private System.Windows.Forms.TextBox matriculaInt;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.Label labelPass;
    }
}

