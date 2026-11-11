namespace LaVeloz.Ui
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNOMBRE = new System.Windows.Forms.TextBox();
            this.btnACEPTAR = new System.Windows.Forms.Button();
            this.btnELIMINAR = new System.Windows.Forms.Button();
            this.btnMODIFICAR = new System.Windows.Forms.Button();
            this.lblDESTINO = new System.Windows.Forms.Label();
            this.cmbDESTINO = new System.Windows.Forms.ComboBox();
            this.btnREGISTRARDESTINO = new System.Windows.Forms.Button();
            this.lblINFORMACION = new System.Windows.Forms.Label();
            this.txtINFORMACION = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // Título
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(343, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "LA VELOZ";

            // DNI
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(91, 107);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(30, 16);
            this.lblDNI.TabIndex = 1;
            this.lblDNI.Text = "DNI";

            this.txtDNI.Location = new System.Drawing.Point(206, 101);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(285, 22);
            this.txtDNI.TabIndex = 2;

            // Nombre
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "NOMBRE";

            this.txtNOMBRE.Location = new System.Drawing.Point(206, 155);
            this.txtNOMBRE.Name = "txtNOMBRE";
            this.txtNOMBRE.Size = new System.Drawing.Size(285, 22);
            this.txtNOMBRE.TabIndex = 4;

            // Destino
            this.lblDESTINO.AutoSize = true;
            this.lblDESTINO.Location = new System.Drawing.Point(88, 206);
            this.lblDESTINO.Name = "lblDESTINO";
            this.lblDESTINO.Size = new System.Drawing.Size(67, 16);
            this.lblDESTINO.TabIndex = 5;
            this.lblDESTINO.Text = "DESTINO";

            this.cmbDESTINO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDESTINO.FormattingEnabled = true;
            this.cmbDESTINO.Items.AddRange(new object[] {
                "Córdoba Capital",
                "Villa Carlos Paz",
                "Alta Gracia",
                "Río Cuarto",
                "Villa María",
                "Jesús María",
                "Cosquín",
                "La Falda",
                "Villa General Belgrano",
                "Mina Clavero"
            });
            this.cmbDESTINO.Location = new System.Drawing.Point(206, 206);
            this.cmbDESTINO.Name = "cmbDESTINO";
            this.cmbDESTINO.Size = new System.Drawing.Size(285, 24);
            this.cmbDESTINO.TabIndex = 6;

            // Aceptar
            this.btnACEPTAR.Location = new System.Drawing.Point(76, 247);
            this.btnACEPTAR.Name = "btnACEPTAR";
            this.btnACEPTAR.Size = new System.Drawing.Size(137, 37);
            this.btnACEPTAR.TabIndex = 7;
            this.btnACEPTAR.Text = "ACEPTAR";
            this.btnACEPTAR.UseVisualStyleBackColor = true;
            this.btnACEPTAR.Click += new System.EventHandler(this.btnACEPTAR_Click);

            // Eliminar
            this.btnELIMINAR.Location = new System.Drawing.Point(76, 295);
            this.btnELIMINAR.Name = "btnELIMINAR";
            this.btnELIMINAR.Size = new System.Drawing.Size(180, 37);
            this.btnELIMINAR.TabIndex = 8;
            this.btnELIMINAR.Text = "ELIMINAR PASAJERO";
            this.btnELIMINAR.UseVisualStyleBackColor = true;
            this.btnELIMINAR.Click += new System.EventHandler(this.btnELIMINAR_Click);

            // Modificar
            this.btnMODIFICAR.Location = new System.Drawing.Point(363, 247);
            this.btnMODIFICAR.Name = "btnMODIFICAR";
            this.btnMODIFICAR.Size = new System.Drawing.Size(190, 37);
            this.btnMODIFICAR.TabIndex = 9;
            this.btnMODIFICAR.Text = "MODIFICAR PASAJERO";
            this.btnMODIFICAR.UseVisualStyleBackColor = true;
            this.btnMODIFICAR.Click += new System.EventHandler(this.btnMODIFICAR_Click);

            // Registrar destino
            this.btnREGISTRARDESTINO.Location = new System.Drawing.Point(363, 295);
            this.btnREGISTRARDESTINO.Name = "btnREGISTRARDESTINO";
            this.btnREGISTRARDESTINO.Size = new System.Drawing.Size(217, 37);
            this.btnREGISTRARDESTINO.TabIndex = 10;
            this.btnREGISTRARDESTINO.Text = "REGISTRAR DESTINO";
            this.btnREGISTRARDESTINO.UseVisualStyleBackColor = true;
            this.btnREGISTRARDESTINO.Click += new System.EventHandler(this.btnREGISTRARDESTINO_Click);

            // Información
            this.lblINFORMACION.AutoSize = true;
            this.lblINFORMACION.Location = new System.Drawing.Point(91, 341);
            this.lblINFORMACION.Name = "lblINFORMACION";
            this.lblINFORMACION.Size = new System.Drawing.Size(100, 16);
            this.lblINFORMACION.TabIndex = 11;
            this.lblINFORMACION.Text = "INFORMACION";

            this.txtINFORMACION.Location = new System.Drawing.Point(91, 373);
            this.txtINFORMACION.Multiline = true;
            this.txtINFORMACION.Name = "txtINFORMACION";
            this.txtINFORMACION.ReadOnly = true;
            this.txtINFORMACION.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtINFORMACION.Size = new System.Drawing.Size(742, 192);
            this.txtINFORMACION.TabIndex = 12;

            // Formulario
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 619);

            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNOMBRE);
            this.Controls.Add(this.lblDESTINO);
            this.Controls.Add(this.cmbDESTINO);
            this.Controls.Add(this.btnACEPTAR);
            this.Controls.Add(this.btnELIMINAR);
            this.Controls.Add(this.btnMODIFICAR);
            this.Controls.Add(this.btnREGISTRARDESTINO);
            this.Controls.Add(this.lblINFORMACION);
            this.Controls.Add(this.txtINFORMACION);

            this.Name = "Form1";
            this.Text = "LA VELOZ";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNOMBRE;
        private System.Windows.Forms.Button btnACEPTAR;
        private System.Windows.Forms.Button btnELIMINAR;
        private System.Windows.Forms.Button btnMODIFICAR;
        private System.Windows.Forms.Label lblDESTINO;
        private System.Windows.Forms.ComboBox cmbDESTINO;
        private System.Windows.Forms.Button btnREGISTRARDESTINO;
        private System.Windows.Forms.Label lblINFORMACION;
        private System.Windows.Forms.TextBox txtINFORMACION;
    }
}