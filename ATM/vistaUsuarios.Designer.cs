namespace ATM
{
    partial class vistaUsuarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsuarioRegistro = new System.Windows.Forms.TextBox();
            this.txtContrasenaRegistro = new System.Windows.Forms.TextBox();
            this.txtDinero = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dtgvUsuarios = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblidUsuario1 = new System.Windows.Forms.Label();
            this.idUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contrasena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dinero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtidUsuario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dinero";
            // 
            // txtUsuarioRegistro
            // 
            this.txtUsuarioRegistro.Location = new System.Drawing.Point(29, 90);
            this.txtUsuarioRegistro.Name = "txtUsuarioRegistro";
            this.txtUsuarioRegistro.Size = new System.Drawing.Size(107, 20);
            this.txtUsuarioRegistro.TabIndex = 3;
            // 
            // txtContrasenaRegistro
            // 
            this.txtContrasenaRegistro.Location = new System.Drawing.Point(32, 148);
            this.txtContrasenaRegistro.Name = "txtContrasenaRegistro";
            this.txtContrasenaRegistro.Size = new System.Drawing.Size(104, 20);
            this.txtContrasenaRegistro.TabIndex = 4;
            // 
            // txtDinero
            // 
            this.txtDinero.Location = new System.Drawing.Point(32, 206);
            this.txtDinero.Name = "txtDinero";
            this.txtDinero.Size = new System.Drawing.Size(104, 20);
            this.txtDinero.TabIndex = 5;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(228, 227);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Agregar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dtgvUsuarios
            // 
            this.dtgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUsuario,
            this.Usuario,
            this.Contrasena,
            this.Dinero});
            this.dtgvUsuarios.Location = new System.Drawing.Point(177, 38);
            this.dtgvUsuarios.Name = "dtgvUsuarios";
            this.dtgvUsuarios.Size = new System.Drawing.Size(492, 165);
            this.dtgvUsuarios.TabIndex = 7;
            this.dtgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvUsuarios_CellClick);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(394, 227);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(551, 227);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblidUsuario1
            // 
            this.lblidUsuario1.AutoSize = true;
            this.lblidUsuario1.Location = new System.Drawing.Point(29, 19);
            this.lblidUsuario1.Name = "lblidUsuario1";
            this.lblidUsuario1.Size = new System.Drawing.Size(51, 13);
            this.lblidUsuario1.TabIndex = 10;
            this.lblidUsuario1.Text = "idUsuario";
            // 
            // idUsuario
            // 
            this.idUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idUsuario.DataPropertyName = "idUsuario";
            this.idUsuario.HeaderText = "idUsuario";
            this.idUsuario.Name = "idUsuario";
            // 
            // Usuario
            // 
            this.Usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Usuario.DataPropertyName = "Usuario";
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            // 
            // Contrasena
            // 
            this.Contrasena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Contrasena.DataPropertyName = "Contrasena";
            this.Contrasena.HeaderText = "Contrasena";
            this.Contrasena.Name = "Contrasena";
            // 
            // Dinero
            // 
            this.Dinero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Dinero.DataPropertyName = "Dinero";
            this.Dinero.HeaderText = "Dinero";
            this.Dinero.Name = "Dinero";
            // 
            // txtidUsuario
            // 
            this.txtidUsuario.Location = new System.Drawing.Point(32, 38);
            this.txtidUsuario.Name = "txtidUsuario";
            this.txtidUsuario.ReadOnly = true;
            this.txtidUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtidUsuario.TabIndex = 11;
            // 
            // vistaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 262);
            this.Controls.Add(this.txtidUsuario);
            this.Controls.Add(this.lblidUsuario1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dtgvUsuarios);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtDinero);
            this.Controls.Add(this.txtContrasenaRegistro);
            this.Controls.Add(this.txtUsuarioRegistro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "vistaUsuarios";
            this.Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsuarioRegistro;
        private System.Windows.Forms.TextBox txtContrasenaRegistro;
        private System.Windows.Forms.TextBox txtDinero;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dtgvUsuarios;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblidUsuario1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contrasena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dinero;
        private System.Windows.Forms.TextBox txtidUsuario;
    }
}