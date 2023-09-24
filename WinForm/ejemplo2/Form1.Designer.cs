namespace ejemplo2
{
    partial class Form1
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
            this.lbNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbFechaNacimiento = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cbAlergico = new System.Windows.Forms.CheckBox();
            this.lbEdad = new System.Windows.Forms.Label();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.lbColorFavorito = new System.Windows.Forms.Label();
            this.rbtMasculino = new System.Windows.Forms.RadioButton();
            this.rbtFemenino = new System.Windows.Forms.RadioButton();
            this.rbtIndistinto = new System.Windows.Forms.RadioButton();
            this.gpbSexo = new System.Windows.Forms.GroupBox();
            this.cbColorFavorito = new System.Windows.Forms.ComboBox();
            this.btnVerDatos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.gpbSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(111, 40);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(50, 13);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre: ";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(167, 37);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(149, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lbFechaNacimiento
            // 
            this.lbFechaNacimiento.AutoSize = true;
            this.lbFechaNacimiento.Location = new System.Drawing.Point(65, 73);
            this.lbFechaNacimiento.Name = "lbFechaNacimiento";
            this.lbFechaNacimiento.Size = new System.Drawing.Size(96, 13);
            this.lbFechaNacimiento.TabIndex = 2;
            this.lbFechaNacimiento.Text = "Fecha Nacimiento:";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(167, 73);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(149, 20);
            this.dtpFechaNacimiento.TabIndex = 3;
            this.dtpFechaNacimiento.Value = new System.DateTime(2023, 9, 16, 0, 0, 0, 0);
            // 
            // cbAlergico
            // 
            this.cbAlergico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAlergico.AutoSize = true;
            this.cbAlergico.Location = new System.Drawing.Point(167, 120);
            this.cbAlergico.Name = "cbAlergico";
            this.cbAlergico.Size = new System.Drawing.Size(84, 17);
            this.cbAlergico.TabIndex = 4;
            this.cbAlergico.Text = "Es alergico?";
            this.cbAlergico.UseVisualStyleBackColor = true;
            // 
            // lbEdad
            // 
            this.lbEdad.AutoSize = true;
            this.lbEdad.Location = new System.Drawing.Point(126, 238);
            this.lbEdad.Name = "lbEdad";
            this.lbEdad.Size = new System.Drawing.Size(35, 13);
            this.lbEdad.TabIndex = 9;
            this.lbEdad.Text = "Edad:";
            // 
            // nudEdad
            // 
            this.nudEdad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudEdad.Location = new System.Drawing.Point(167, 236);
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(145, 20);
            this.nudEdad.TabIndex = 10;
            // 
            // lbColorFavorito
            // 
            this.lbColorFavorito.AutoSize = true;
            this.lbColorFavorito.Location = new System.Drawing.Point(89, 283);
            this.lbColorFavorito.Name = "lbColorFavorito";
            this.lbColorFavorito.Size = new System.Drawing.Size(72, 13);
            this.lbColorFavorito.TabIndex = 11;
            this.lbColorFavorito.Text = "Color favorito:";
            // 
            // rbtMasculino
            // 
            this.rbtMasculino.AutoSize = true;
            this.rbtMasculino.Location = new System.Drawing.Point(16, 19);
            this.rbtMasculino.Name = "rbtMasculino";
            this.rbtMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbtMasculino.TabIndex = 5;
            this.rbtMasculino.TabStop = true;
            this.rbtMasculino.Text = "Masculino";
            this.rbtMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtFemenino
            // 
            this.rbtFemenino.AutoSize = true;
            this.rbtFemenino.Location = new System.Drawing.Point(108, 19);
            this.rbtFemenino.Name = "rbtFemenino";
            this.rbtFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbtFemenino.TabIndex = 6;
            this.rbtFemenino.TabStop = true;
            this.rbtFemenino.Text = "Femenino";
            this.rbtFemenino.UseVisualStyleBackColor = true;
            // 
            // rbtIndistinto
            // 
            this.rbtIndistinto.AutoSize = true;
            this.rbtIndistinto.Location = new System.Drawing.Point(205, 19);
            this.rbtIndistinto.Name = "rbtIndistinto";
            this.rbtIndistinto.Size = new System.Drawing.Size(67, 17);
            this.rbtIndistinto.TabIndex = 7;
            this.rbtIndistinto.TabStop = true;
            this.rbtIndistinto.Text = "Indistinto";
            this.rbtIndistinto.UseVisualStyleBackColor = true;
            // 
            // gpbSexo
            // 
            this.gpbSexo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbSexo.Controls.Add(this.rbtIndistinto);
            this.gpbSexo.Controls.Add(this.rbtFemenino);
            this.gpbSexo.Controls.Add(this.rbtMasculino);
            this.gpbSexo.Location = new System.Drawing.Point(68, 152);
            this.gpbSexo.Name = "gpbSexo";
            this.gpbSexo.Size = new System.Drawing.Size(293, 66);
            this.gpbSexo.TabIndex = 12;
            this.gpbSexo.TabStop = false;
            this.gpbSexo.Text = "Sexo:";
            // 
            // cbColorFavorito
            // 
            this.cbColorFavorito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbColorFavorito.FormattingEnabled = true;
            this.cbColorFavorito.Location = new System.Drawing.Point(167, 280);
            this.cbColorFavorito.Name = "cbColorFavorito";
            this.cbColorFavorito.Size = new System.Drawing.Size(145, 21);
            this.cbColorFavorito.TabIndex = 13;
            // 
            // btnVerDatos
            // 
            this.btnVerDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerDatos.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnVerDatos.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnVerDatos.FlatAppearance.BorderSize = 3;
            this.btnVerDatos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnVerDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerDatos.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDatos.Location = new System.Drawing.Point(167, 349);
            this.btnVerDatos.Name = "btnVerDatos";
            this.btnVerDatos.Size = new System.Drawing.Size(97, 41);
            this.btnVerDatos.TabIndex = 14;
            this.btnVerDatos.Text = "Ver datos";
            this.btnVerDatos.UseVisualStyleBackColor = false;
            this.btnVerDatos.Click += new System.EventHandler(this.btnVerDatos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Perfil Persona";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(400, 416);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVerDatos);
            this.Controls.Add(this.cbColorFavorito);
            this.Controls.Add(this.gpbSexo);
            this.Controls.Add(this.lbColorFavorito);
            this.Controls.Add(this.nudEdad);
            this.Controls.Add(this.lbEdad);
            this.Controls.Add(this.cbAlergico);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.lbFechaNacimiento);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbNombre);
            this.MaximumSize = new System.Drawing.Size(684, 498);
            this.MinimumSize = new System.Drawing.Size(416, 455);
            this.Name = "Form1";
            this.Text = "Formulario";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            this.gpbSexo.ResumeLayout(false);
            this.gpbSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbFechaNacimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.CheckBox cbAlergico;
        private System.Windows.Forms.Label lbEdad;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.Label lbColorFavorito;
        private System.Windows.Forms.RadioButton rbtMasculino;
        private System.Windows.Forms.RadioButton rbtFemenino;
        private System.Windows.Forms.RadioButton rbtIndistinto;
        private System.Windows.Forms.GroupBox gpbSexo;
        private System.Windows.Forms.ComboBox cbColorFavorito;
        private System.Windows.Forms.Button btnVerDatos;
        private System.Windows.Forms.Label label1;
    }
}

