namespace RentCar_Proyect_.UsuarioForms
{
    partial class CreateInspeccionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateInspeccionForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dateins = new System.Windows.Forms.DateTimePicker();
            this.Idrenta = new System.Windows.Forms.Label();
            this.cerradura = new System.Windows.Forms.CheckBox();
            this.gomaresp = new System.Windows.Forms.CheckBox();
            this.Gato = new System.Windows.Forms.CheckBox();
            this.cristal = new System.Windows.Forms.CheckBox();
            this.GomadelateraDR = new System.Windows.Forms.CheckBox();
            this.GomadelateraIz = new System.Windows.Forms.CheckBox();
            this.GomatraseraDR = new System.Windows.Forms.CheckBox();
            this.GomatraseraIz = new System.Windows.Forms.CheckBox();
            this.pintura = new System.Windows.Forms.CheckBox();
            this.CantCombus = new System.Windows.Forms.ComboBox();
            this.cbemple = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IdCliente = new System.Windows.Forms.Label();
            this.Idvehiculo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(67, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar inspeccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cantidad combustible";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fecha";
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.AutoSize = true;
            this.btnclose.BackColor = System.Drawing.SystemColors.Window;
            this.btnclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(474, 9);
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
            this.btnSave.Location = new System.Drawing.Point(151, 401);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(163, 39);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dateins
            // 
            this.dateins.Location = new System.Drawing.Point(219, 357);
            this.dateins.Name = "dateins";
            this.dateins.Size = new System.Drawing.Size(200, 20);
            this.dateins.TabIndex = 20;
            // 
            // Idrenta
            // 
            this.Idrenta.AutoSize = true;
            this.Idrenta.Location = new System.Drawing.Point(13, 94);
            this.Idrenta.Name = "Idrenta";
            this.Idrenta.Size = new System.Drawing.Size(0, 13);
            this.Idrenta.TabIndex = 27;
            this.Idrenta.Visible = false;
            // 
            // cerradura
            // 
            this.cerradura.AutoSize = true;
            this.cerradura.Location = new System.Drawing.Point(71, 117);
            this.cerradura.Name = "cerradura";
            this.cerradura.Size = new System.Drawing.Size(101, 17);
            this.cerradura.TabIndex = 28;
            this.cerradura.Text = "Tiene ralladuras";
            this.cerradura.UseVisualStyleBackColor = true;
            // 
            // gomaresp
            // 
            this.gomaresp.AutoSize = true;
            this.gomaresp.Location = new System.Drawing.Point(70, 140);
            this.gomaresp.Name = "gomaresp";
            this.gomaresp.Size = new System.Drawing.Size(131, 17);
            this.gomaresp.TabIndex = 29;
            this.gomaresp.Text = "Tiene goma respuesta";
            this.gomaresp.UseVisualStyleBackColor = true;
            // 
            // Gato
            // 
            this.Gato.AutoSize = true;
            this.Gato.Location = new System.Drawing.Point(70, 163);
            this.Gato.Name = "Gato";
            this.Gato.Size = new System.Drawing.Size(77, 17);
            this.Gato.TabIndex = 31;
            this.Gato.Text = "Tiene gato";
            this.Gato.UseVisualStyleBackColor = true;
            // 
            // cristal
            // 
            this.cristal.AutoSize = true;
            this.cristal.Location = new System.Drawing.Point(69, 186);
            this.cristal.Name = "cristal";
            this.cristal.Size = new System.Drawing.Size(128, 17);
            this.cristal.TabIndex = 32;
            this.cristal.Text = "Tiene rotura de cristal";
            this.cristal.UseVisualStyleBackColor = true;
            // 
            // GomadelateraDR
            // 
            this.GomadelateraDR.AutoSize = true;
            this.GomadelateraDR.Location = new System.Drawing.Point(69, 234);
            this.GomadelateraDR.Name = "GomadelateraDR";
            this.GomadelateraDR.Size = new System.Drawing.Size(177, 17);
            this.GomadelateraDR.TabIndex = 33;
            this.GomadelateraDR.Text = "Estado goma delantera derecha";
            this.GomadelateraDR.UseVisualStyleBackColor = true;
            // 
            // GomadelateraIz
            // 
            this.GomadelateraIz.AutoSize = true;
            this.GomadelateraIz.Location = new System.Drawing.Point(69, 255);
            this.GomadelateraIz.Name = "GomadelateraIz";
            this.GomadelateraIz.Size = new System.Drawing.Size(181, 17);
            this.GomadelateraIz.TabIndex = 34;
            this.GomadelateraIz.Text = "Estado goma delantera Izquierda";
            this.GomadelateraIz.UseVisualStyleBackColor = true;
            // 
            // GomatraseraDR
            // 
            this.GomatraseraDR.AutoSize = true;
            this.GomatraseraDR.Location = new System.Drawing.Point(69, 278);
            this.GomatraseraDR.Name = "GomatraseraDR";
            this.GomatraseraDR.Size = new System.Drawing.Size(165, 17);
            this.GomatraseraDR.TabIndex = 35;
            this.GomatraseraDR.Text = "Estado goma trasera derecha";
            this.GomatraseraDR.UseVisualStyleBackColor = true;
            // 
            // GomatraseraIz
            // 
            this.GomatraseraIz.AutoSize = true;
            this.GomatraseraIz.Location = new System.Drawing.Point(70, 301);
            this.GomatraseraIz.Name = "GomatraseraIz";
            this.GomatraseraIz.Size = new System.Drawing.Size(169, 17);
            this.GomatraseraIz.TabIndex = 36;
            this.GomatraseraIz.Text = "Estado goma trasera Izquierda";
            this.GomatraseraIz.UseVisualStyleBackColor = true;
            // 
            // pintura
            // 
            this.pintura.AutoSize = true;
            this.pintura.Location = new System.Drawing.Point(69, 209);
            this.pintura.Name = "pintura";
            this.pintura.Size = new System.Drawing.Size(94, 17);
            this.pintura.TabIndex = 37;
            this.pintura.Text = "Estado pintura";
            this.pintura.UseVisualStyleBackColor = true;
            // 
            // CantCombus
            // 
            this.CantCombus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CantCombus.FormattingEnabled = true;
            this.CantCombus.Items.AddRange(new object[] {
            "1/4,",
            "1/2",
            "3/4",
            "Lleno"});
            this.CantCombus.Location = new System.Drawing.Point(54, 357);
            this.CantCombus.Name = "CantCombus";
            this.CantCombus.Size = new System.Drawing.Size(121, 21);
            this.CantCombus.TabIndex = 38;
            // 
            // cbemple
            // 
            this.cbemple.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbemple.FormattingEnabled = true;
            this.cbemple.Location = new System.Drawing.Point(298, 136);
            this.cbemple.Name = "cbemple";
            this.cbemple.Size = new System.Drawing.Size(121, 21);
            this.cbemple.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Empleado";
            // 
            // IdCliente
            // 
            this.IdCliente.AutoSize = true;
            this.IdCliente.Location = new System.Drawing.Point(362, 234);
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.Size = new System.Drawing.Size(0, 13);
            this.IdCliente.TabIndex = 41;
            this.IdCliente.Visible = false;
            // 
            // Idvehiculo
            // 
            this.Idvehiculo.AutoSize = true;
            this.Idvehiculo.Location = new System.Drawing.Point(326, 287);
            this.Idvehiculo.Name = "Idvehiculo";
            this.Idvehiculo.Size = new System.Drawing.Size(0, 13);
            this.Idvehiculo.TabIndex = 42;
            this.Idvehiculo.Visible = false;
            // 
            // CreateInspeccionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 467);
            this.Controls.Add(this.Idvehiculo);
            this.Controls.Add(this.IdCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbemple);
            this.Controls.Add(this.CantCombus);
            this.Controls.Add(this.pintura);
            this.Controls.Add(this.GomatraseraIz);
            this.Controls.Add(this.GomatraseraDR);
            this.Controls.Add(this.GomadelateraIz);
            this.Controls.Add(this.GomadelateraDR);
            this.Controls.Add(this.cristal);
            this.Controls.Add(this.Gato);
            this.Controls.Add(this.gomaresp);
            this.Controls.Add(this.cerradura);
            this.Controls.Add(this.Idrenta);
            this.Controls.Add(this.dateins);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateInspeccionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateUserForm";
            this.Load += new System.EventHandler(this.CreateInspeccionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label btnclose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dateins;
        public System.Windows.Forms.Label Idrenta;
        private System.Windows.Forms.CheckBox cerradura;
        private System.Windows.Forms.CheckBox gomaresp;
        private System.Windows.Forms.CheckBox Gato;
        private System.Windows.Forms.CheckBox cristal;
        private System.Windows.Forms.CheckBox GomadelateraDR;
        private System.Windows.Forms.CheckBox GomadelateraIz;
        private System.Windows.Forms.CheckBox GomatraseraDR;
        private System.Windows.Forms.CheckBox GomatraseraIz;
        private System.Windows.Forms.CheckBox pintura;
        private System.Windows.Forms.ComboBox CantCombus;
        private System.Windows.Forms.ComboBox cbemple;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label IdCliente;
        public System.Windows.Forms.Label Idvehiculo;
    }
}