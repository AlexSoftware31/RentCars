namespace RentCar_Proyect_.UsuarioForms
{
    partial class CreateVehiculoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateVehiculoForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescrip = new System.Windows.Forms.TextBox();
            this.txtchasis = new System.Windows.Forms.TextBox();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcolor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.rdstatus = new System.Windows.Forms.CheckBox();
            this.txtmotor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbtrans = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Cbveh = new System.Windows.Forms.ComboBox();
            this.Cbmarca = new System.Windows.Forms.ComboBox();
            this.Cbmodelo = new System.Windows.Forms.ComboBox();
            this.Cbcomb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(90, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar vehiculo";
            // 
            // txtDescrip
            // 
            this.txtDescrip.Location = new System.Drawing.Point(84, 123);
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.Size = new System.Drawing.Size(109, 20);
            this.txtDescrip.TabIndex = 1;
            // 
            // txtchasis
            // 
            this.txtchasis.Location = new System.Drawing.Point(84, 185);
            this.txtchasis.Name = "txtchasis";
            this.txtchasis.Size = new System.Drawing.Size(109, 20);
            this.txtchasis.TabIndex = 2;
            // 
            // txtyear
            // 
            this.txtyear.Location = new System.Drawing.Point(354, 244);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(60, 20);
            this.txtyear.TabIndex = 3;
            this.txtyear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtyear_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "N° Chasis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Año";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tipo de vehiculo";
            // 
            // txtcolor
            // 
            this.txtcolor.Location = new System.Drawing.Point(285, 244);
            this.txtcolor.Name = "txtcolor";
            this.txtcolor.Size = new System.Drawing.Size(63, 20);
            this.txtcolor.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(282, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Color";
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
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightBlue;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(162, 430);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(163, 39);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rdstatus
            // 
            this.rdstatus.AutoSize = true;
            this.rdstatus.Location = new System.Drawing.Point(289, 392);
            this.rdstatus.Name = "rdstatus";
            this.rdstatus.Size = new System.Drawing.Size(59, 17);
            this.rdstatus.TabIndex = 15;
            this.rdstatus.Text = "Estado";
            this.rdstatus.UseVisualStyleBackColor = true;
            // 
            // txtmotor
            // 
            this.txtmotor.Location = new System.Drawing.Point(84, 240);
            this.txtmotor.Name = "txtmotor";
            this.txtmotor.Size = new System.Drawing.Size(109, 20);
            this.txtmotor.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "N° Motor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(84, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "N° Placa";
            // 
            // txtplaca
            // 
            this.txtplaca.Location = new System.Drawing.Point(84, 294);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(109, 20);
            this.txtplaca.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(283, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Marca";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(283, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Modelo";
            // 
            // cbtrans
            // 
            this.cbtrans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtrans.FormattingEnabled = true;
            this.cbtrans.Items.AddRange(new object[] {
            "Automatica",
            "Mecanica"});
            this.cbtrans.Location = new System.Drawing.Point(285, 294);
            this.cbtrans.Name = "cbtrans";
            this.cbtrans.Size = new System.Drawing.Size(129, 21);
            this.cbtrans.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(282, 278);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Tipo de transmision";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(282, 329);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Combustible";
            // 
            // Cbveh
            // 
            this.Cbveh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbveh.FormattingEnabled = true;
            this.Cbveh.Location = new System.Drawing.Point(84, 354);
            this.Cbveh.Name = "Cbveh";
            this.Cbveh.Size = new System.Drawing.Size(109, 21);
            this.Cbveh.TabIndex = 28;
            // 
            // Cbmarca
            // 
            this.Cbmarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbmarca.FormattingEnabled = true;
            this.Cbmarca.Location = new System.Drawing.Point(285, 123);
            this.Cbmarca.Name = "Cbmarca";
            this.Cbmarca.Size = new System.Drawing.Size(129, 21);
            this.Cbmarca.TabIndex = 29;
            this.Cbmarca.SelectedValueChanged += new System.EventHandler(this.Cbmarca_SelectedValueChanged);
            // 
            // Cbmodelo
            // 
            this.Cbmodelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbmodelo.FormattingEnabled = true;
            this.Cbmodelo.Location = new System.Drawing.Point(285, 185);
            this.Cbmodelo.Name = "Cbmodelo";
            this.Cbmodelo.Size = new System.Drawing.Size(129, 21);
            this.Cbmodelo.TabIndex = 30;
            // 
            // Cbcomb
            // 
            this.Cbcomb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbcomb.FormattingEnabled = true;
            this.Cbcomb.Location = new System.Drawing.Point(285, 354);
            this.Cbcomb.Name = "Cbcomb";
            this.Cbcomb.Size = new System.Drawing.Size(129, 21);
            this.Cbcomb.TabIndex = 31;
            // 
            // CreateVehiculoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 480);
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
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtcolor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.txtchasis);
            this.Controls.Add(this.txtDescrip);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateVehiculoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateUserForm";
            this.Load += new System.EventHandler(this.CreateVehiculoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescrip;
        private System.Windows.Forms.TextBox txtchasis;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcolor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label btnclose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox rdstatus;
        private System.Windows.Forms.TextBox txtmotor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtplaca;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbtrans;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox Cbveh;
        private System.Windows.Forms.ComboBox Cbmarca;
        private System.Windows.Forms.ComboBox Cbmodelo;
        private System.Windows.Forms.ComboBox Cbcomb;
    }
}