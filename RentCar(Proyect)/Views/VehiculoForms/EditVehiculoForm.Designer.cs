namespace RentCar_Proyect_.UsuarioForms
{
    partial class EditVehiculoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditVehiculoForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.Cbcomb = new System.Windows.Forms.ComboBox();
            this.Cbmodelo = new System.Windows.Forms.ComboBox();
            this.Cbmarca = new System.Windows.Forms.ComboBox();
            this.Cbveh = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbtrans = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtmotor = new System.Windows.Forms.TextBox();
            this.rdstatus = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcolor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.txtchasis = new System.Windows.Forms.TextBox();
            this.txtDescrip = new System.Windows.Forms.TextBox();
            this.txtIdtipo = new System.Windows.Forms.Label();
            this.txtidmarca = new System.Windows.Forms.Label();
            this.txtmodel = new System.Windows.Forms.Label();
            this.txtidcomb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(85, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Editar vehiculo";
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.AutoSize = true;
            this.btnclose.BackColor = System.Drawing.SystemColors.Window;
            this.btnclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(469, 9);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(18, 17);
            this.btnclose.TabIndex = 12;
            this.btnclose.Text = "X";
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // txtId
            // 
            this.txtId.AutoSize = true;
            this.txtId.Location = new System.Drawing.Point(25, 217);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(0, 13);
            this.txtId.TabIndex = 14;
            this.txtId.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightBlue;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(164, 429);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(163, 39);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Cbcomb
            // 
            this.Cbcomb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbcomb.FormattingEnabled = true;
            this.Cbcomb.Location = new System.Drawing.Point(287, 341);
            this.Cbcomb.Name = "Cbcomb";
            this.Cbcomb.Size = new System.Drawing.Size(129, 21);
            this.Cbcomb.TabIndex = 54;
            // 
            // Cbmodelo
            // 
            this.Cbmodelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbmodelo.FormattingEnabled = true;
            this.Cbmodelo.Location = new System.Drawing.Point(287, 172);
            this.Cbmodelo.Name = "Cbmodelo";
            this.Cbmodelo.Size = new System.Drawing.Size(129, 21);
            this.Cbmodelo.TabIndex = 53;
            // 
            // Cbmarca
            // 
            this.Cbmarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbmarca.FormattingEnabled = true;
            this.Cbmarca.Location = new System.Drawing.Point(287, 110);
            this.Cbmarca.Name = "Cbmarca";
            this.Cbmarca.Size = new System.Drawing.Size(129, 21);
            this.Cbmarca.TabIndex = 52;
            this.Cbmarca.SelectedValueChanged += new System.EventHandler(this.Cbmarca_SelectedValueChanged);
            // 
            // Cbveh
            // 
            this.Cbveh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbveh.FormattingEnabled = true;
            this.Cbveh.Location = new System.Drawing.Point(86, 341);
            this.Cbveh.Name = "Cbveh";
            this.Cbveh.Size = new System.Drawing.Size(109, 21);
            this.Cbveh.TabIndex = 51;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(284, 316);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 50;
            this.label12.Text = "Combustible";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(284, 262);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 13);
            this.label11.TabIndex = 49;
            this.label11.Text = "Tipo de transmision";
            // 
            // cbtrans
            // 
            this.cbtrans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtrans.FormattingEnabled = true;
            this.cbtrans.Items.AddRange(new object[] {
            "Automatica",
            "Mecanica"});
            this.cbtrans.Location = new System.Drawing.Point(287, 281);
            this.cbtrans.Name = "cbtrans";
            this.cbtrans.Size = new System.Drawing.Size(129, 21);
            this.cbtrans.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(285, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "Modelo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(285, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "Marca";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(83, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "N° Placa";
            // 
            // txtplaca
            // 
            this.txtplaca.Location = new System.Drawing.Point(86, 281);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(109, 20);
            this.txtplaca.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(83, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "N° Motor";
            // 
            // txtmotor
            // 
            this.txtmotor.Location = new System.Drawing.Point(86, 227);
            this.txtmotor.Name = "txtmotor";
            this.txtmotor.Size = new System.Drawing.Size(109, 20);
            this.txtmotor.TabIndex = 42;
            // 
            // rdstatus
            // 
            this.rdstatus.AutoSize = true;
            this.rdstatus.Location = new System.Drawing.Point(291, 379);
            this.rdstatus.Name = "rdstatus";
            this.rdstatus.Size = new System.Drawing.Size(59, 17);
            this.rdstatus.TabIndex = 41;
            this.rdstatus.Text = "Estado";
            this.rdstatus.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Color";
            // 
            // txtcolor
            // 
            this.txtcolor.Location = new System.Drawing.Point(287, 231);
            this.txtcolor.Name = "txtcolor";
            this.txtcolor.Size = new System.Drawing.Size(63, 20);
            this.txtcolor.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Tipo de vehiculo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Año";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "N° Chasis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Descripcion";
            // 
            // txtyear
            // 
            this.txtyear.Location = new System.Drawing.Point(356, 231);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(60, 20);
            this.txtyear.TabIndex = 34;
            // 
            // txtchasis
            // 
            this.txtchasis.Location = new System.Drawing.Point(86, 172);
            this.txtchasis.Name = "txtchasis";
            this.txtchasis.Size = new System.Drawing.Size(109, 20);
            this.txtchasis.TabIndex = 33;
            // 
            // txtDescrip
            // 
            this.txtDescrip.Location = new System.Drawing.Point(86, 110);
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.Size = new System.Drawing.Size(109, 20);
            this.txtDescrip.TabIndex = 32;
            // 
            // txtIdtipo
            // 
            this.txtIdtipo.AutoSize = true;
            this.txtIdtipo.Location = new System.Drawing.Point(13, 408);
            this.txtIdtipo.Name = "txtIdtipo";
            this.txtIdtipo.Size = new System.Drawing.Size(0, 13);
            this.txtIdtipo.TabIndex = 55;
            this.txtIdtipo.Visible = false;
            // 
            // txtidmarca
            // 
            this.txtidmarca.AutoSize = true;
            this.txtidmarca.Location = new System.Drawing.Point(83, 408);
            this.txtidmarca.Name = "txtidmarca";
            this.txtidmarca.Size = new System.Drawing.Size(0, 13);
            this.txtidmarca.TabIndex = 56;
            this.txtidmarca.Visible = false;
            // 
            // txtmodel
            // 
            this.txtmodel.AutoSize = true;
            this.txtmodel.Location = new System.Drawing.Point(12, 443);
            this.txtmodel.Name = "txtmodel";
            this.txtmodel.Size = new System.Drawing.Size(0, 13);
            this.txtmodel.TabIndex = 57;
            this.txtmodel.Visible = false;
            // 
            // txtidcomb
            // 
            this.txtidcomb.AutoSize = true;
            this.txtidcomb.Location = new System.Drawing.Point(83, 443);
            this.txtidcomb.Name = "txtidcomb";
            this.txtidcomb.Size = new System.Drawing.Size(0, 13);
            this.txtidcomb.TabIndex = 58;
            this.txtidcomb.Visible = false;
            // 
            // EditVehiculoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 480);
            this.Controls.Add(this.txtidcomb);
            this.Controls.Add(this.txtmodel);
            this.Controls.Add(this.txtidmarca);
            this.Controls.Add(this.txtIdtipo);
            this.Controls.Add(this.Cbcomb);
            this.Controls.Add(this.Cbmodelo);
            this.Controls.Add(this.Cbmarca);
            this.Controls.Add(this.Cbveh);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbtrans);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtplaca);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtmotor);
            this.Controls.Add(this.rdstatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtcolor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.txtchasis);
            this.Controls.Add(this.txtDescrip);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditVehiculoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateUserForm";
            this.Load += new System.EventHandler(this.EditVehiculoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label btnclose;
        public System.Windows.Forms.Label txtId;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox Cbcomb;
        public System.Windows.Forms.ComboBox Cbmodelo;
        public System.Windows.Forms.ComboBox Cbmarca;
        public System.Windows.Forms.ComboBox Cbveh;
        public System.Windows.Forms.ComboBox cbtrans;
        public System.Windows.Forms.TextBox txtplaca;
        public System.Windows.Forms.TextBox txtmotor;
        public System.Windows.Forms.CheckBox rdstatus;
        public System.Windows.Forms.TextBox txtcolor;
        public System.Windows.Forms.TextBox txtyear;
        public System.Windows.Forms.TextBox txtchasis;
        public System.Windows.Forms.TextBox txtDescrip;
        public System.Windows.Forms.Label txtIdtipo;
        public System.Windows.Forms.Label txtidmarca;
        public System.Windows.Forms.Label txtmodel;
        public System.Windows.Forms.Label txtidcomb;
    }
}