namespace School_program2
{
    partial class Ingreso
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbusuario = new System.Windows.Forms.TextBox();
            this.tbcontraseña = new System.Windows.Forms.TextBox();
            this.cr = new System.Windows.Forms.Label();
            this.cbadmin1 = new System.Windows.Forms.CheckBox();
            this.cbdocente1 = new System.Windows.Forms.CheckBox();
            this.cbalumn1 = new System.Windows.Forms.CheckBox();
            this.btingresar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btingresar);
            this.groupBox1.Controls.Add(this.cbalumn1);
            this.groupBox1.Controls.Add(this.cbdocente1);
            this.groupBox1.Controls.Add(this.cbadmin1);
            this.groupBox1.Controls.Add(this.tbcontraseña);
            this.groupBox1.Controls.Add(this.tbusuario);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 146);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SCHOOL - SOFT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // tbusuario
            // 
            this.tbusuario.Location = new System.Drawing.Point(108, 23);
            this.tbusuario.Name = "tbusuario";
            this.tbusuario.Size = new System.Drawing.Size(257, 23);
            this.tbusuario.TabIndex = 2;
            // 
            // tbcontraseña
            // 
            this.tbcontraseña.Location = new System.Drawing.Point(108, 52);
            this.tbcontraseña.Name = "tbcontraseña";
            this.tbcontraseña.PasswordChar = '*';
            this.tbcontraseña.Size = new System.Drawing.Size(257, 23);
            this.tbcontraseña.TabIndex = 3;
            // 
            // cr
            // 
            this.cr.AutoSize = true;
            this.cr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cr.Location = new System.Drawing.Point(270, 236);
            this.cr.Name = "cr";
            this.cr.Size = new System.Drawing.Size(127, 17);
            this.cr.TabIndex = 1;
            this.cr.Text = "© school-soft 2019";
            this.cr.Click += new System.EventHandler(this.cr_Click);
            // 
            // cbadmin1
            // 
            this.cbadmin1.AutoSize = true;
            this.cbadmin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbadmin1.Location = new System.Drawing.Point(13, 119);
            this.cbadmin1.Name = "cbadmin1";
            this.cbadmin1.Size = new System.Drawing.Size(113, 21);
            this.cbadmin1.TabIndex = 4;
            this.cbadmin1.Text = "administrador";
            this.cbadmin1.UseVisualStyleBackColor = true;
            // 
            // cbdocente1
            // 
            this.cbdocente1.AutoSize = true;
            this.cbdocente1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbdocente1.Location = new System.Drawing.Point(154, 119);
            this.cbdocente1.Name = "cbdocente1";
            this.cbdocente1.Size = new System.Drawing.Size(80, 21);
            this.cbdocente1.TabIndex = 5;
            this.cbdocente1.Text = "Docente";
            this.cbdocente1.UseVisualStyleBackColor = true;
            // 
            // cbalumn1
            // 
            this.cbalumn1.AutoSize = true;
            this.cbalumn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbalumn1.Location = new System.Drawing.Point(271, 119);
            this.cbalumn1.Name = "cbalumn1";
            this.cbalumn1.Size = new System.Drawing.Size(74, 21);
            this.cbalumn1.TabIndex = 6;
            this.cbalumn1.Text = "Alumno";
            this.cbalumn1.UseVisualStyleBackColor = true;
            // 
            // btingresar
            // 
            this.btingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btingresar.Location = new System.Drawing.Point(140, 82);
            this.btingresar.Name = "btingresar";
            this.btingresar.Size = new System.Drawing.Size(94, 31);
            this.btingresar.TabIndex = 7;
            this.btingresar.Text = "< INGRESAR";
            this.btingresar.UseVisualStyleBackColor = true;
            // 
            // btSalir
            // 
            this.btSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.Location = new System.Drawing.Point(347, -3);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(65, 34);
            this.btSalir.TabIndex = 2;
            this.btSalir.Text = "SALIR";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click_1);
            // 
            // Ingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 262);
            this.ControlBox = false;
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.cr);
            this.Controls.Add(this.groupBox1);
            this.Name = "Ingreso";
            this.Text = "Ingreso";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbusuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbcontraseña;
        private System.Windows.Forms.Label cr;
        private System.Windows.Forms.Button btingresar;
        private System.Windows.Forms.CheckBox cbalumn1;
        private System.Windows.Forms.CheckBox cbdocente1;
        private System.Windows.Forms.CheckBox cbadmin1;
        private System.Windows.Forms.Button btSalir;
    }
}

