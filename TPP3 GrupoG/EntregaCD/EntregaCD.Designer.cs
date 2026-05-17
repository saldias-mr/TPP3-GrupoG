namespace TPP3_GrupoG.Entregas
{
    partial class EntregaCD
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
            dniReceptorTXT = new TextBox();
            lbl_IngreseDNI = new Label();
            numGuiaLIST = new ListView();
            numGuia = new ColumnHeader();
            lbl_Infoencomienda = new Label();
            BuscarBTN = new Button();
            ConfirmBTN = new Button();
            VolverBTN = new Button();
            lbl_NameTutasa = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // dniReceptorTXT
            // 
            dniReceptorTXT.Location = new Point(22, 118);
            dniReceptorTXT.Margin = new Padding(2);
            dniReceptorTXT.Name = "dniReceptorTXT";
            dniReceptorTXT.Size = new Size(239, 27);
            dniReceptorTXT.TabIndex = 0;
            // 
            // lbl_IngreseDNI
            // 
            lbl_IngreseDNI.AutoSize = true;
            lbl_IngreseDNI.Font = new Font("Segoe UI", 10F);
            lbl_IngreseDNI.Location = new Point(22, 94);
            lbl_IngreseDNI.Margin = new Padding(2, 0, 2, 0);
            lbl_IngreseDNI.Name = "lbl_IngreseDNI";
            lbl_IngreseDNI.Size = new Size(118, 23);
            lbl_IngreseDNI.TabIndex = 1;
            lbl_IngreseDNI.Text = " DNI Receptor";
            // 
            // numGuiaLIST
            // 
            numGuiaLIST.Columns.AddRange(new ColumnHeader[] { numGuia });
            numGuiaLIST.Location = new Point(22, 210);
            numGuiaLIST.Margin = new Padding(2);
            numGuiaLIST.Name = "numGuiaLIST";
            numGuiaLIST.Size = new Size(373, 174);
            numGuiaLIST.TabIndex = 2;
            numGuiaLIST.UseCompatibleStateImageBehavior = false;
            numGuiaLIST.View = View.Details;
            // 
            // numGuia
            // 
            numGuia.Text = "Nº Guía";
            numGuia.Width = 90;
            // 
            // lbl_Infoencomienda
            // 
            lbl_Infoencomienda.AutoSize = true;
            lbl_Infoencomienda.Font = new Font("Segoe UI", 12F);
            lbl_Infoencomienda.Location = new Point(22, 178);
            lbl_Infoencomienda.Margin = new Padding(2, 0, 2, 0);
            lbl_Infoencomienda.Name = "lbl_Infoencomienda";
            lbl_Infoencomienda.Size = new Size(119, 28);
            lbl_Infoencomienda.TabIndex = 3;
            lbl_Infoencomienda.Text = "Encomienda";
            // 
            // BuscarBTN
            // 
            BuscarBTN.Location = new Point(277, 118);
            BuscarBTN.Margin = new Padding(2);
            BuscarBTN.Name = "BuscarBTN";
            BuscarBTN.Size = new Size(119, 30);
            BuscarBTN.TabIndex = 4;
            BuscarBTN.Text = "Buscar";
            BuscarBTN.UseVisualStyleBackColor = true;
            BuscarBTN.Click += BuscarBTN_Click;
            // 
            // ConfirmBTN
            // 
            ConfirmBTN.BackColor = Color.Green;
            ConfirmBTN.ForeColor = SystemColors.ButtonHighlight;
            ConfirmBTN.Location = new Point(22, 478);
            ConfirmBTN.Margin = new Padding(2);
            ConfirmBTN.Name = "ConfirmBTN";
            ConfirmBTN.Size = new Size(142, 50);
            ConfirmBTN.TabIndex = 6;
            ConfirmBTN.Text = "Confirmar entrega";
            ConfirmBTN.UseVisualStyleBackColor = false;
            ConfirmBTN.Click += ConfirmarEntregaBTN_Click;
            // 
            // VolverBTN
            // 
            VolverBTN.BackColor = Color.DarkRed;
            VolverBTN.ForeColor = SystemColors.ButtonHighlight;
            VolverBTN.Location = new Point(272, 478);
            VolverBTN.Margin = new Padding(3, 2, 3, 2);
            VolverBTN.Name = "VolverBTN";
            VolverBTN.Size = new Size(123, 50);
            VolverBTN.TabIndex = 7;
            VolverBTN.Text = "Cancelar/Volver";
            VolverBTN.UseVisualStyleBackColor = false;
            VolverBTN.Click += VolverBTN_Click;
            // 
            // lbl_NameTutasa
            // 
            lbl_NameTutasa.Font = new Font("Segoe UI", 16F);
            lbl_NameTutasa.Location = new Point(22, 10);
            lbl_NameTutasa.Name = "lbl_NameTutasa";
            lbl_NameTutasa.Size = new Size(171, 46);
            lbl_NameTutasa.TabIndex = 8;
            lbl_NameTutasa.Text = "TUTASA S.A";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(243, 18);
            label3.Name = "label3";
            label3.Size = new Size(177, 58);
            label3.TabIndex = 9;
            label3.Text = "Registro de Entrega";
            // 
            // EntregaCD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 542);
            Controls.Add(label3);
            Controls.Add(lbl_NameTutasa);
            Controls.Add(VolverBTN);
            Controls.Add(ConfirmBTN);
            Controls.Add(BuscarBTN);
            Controls.Add(lbl_Infoencomienda);
            Controls.Add(numGuiaLIST);
            Controls.Add(lbl_IngreseDNI);
            Controls.Add(dniReceptorTXT);
            Margin = new Padding(2);
            Name = "EntregaCD";
            Text = "Entregas (CD)";
            Load += EntregaCD_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox dniReceptorTXT;
        private Label lbl_IngreseDNI;
        private ListView numGuiaLIST;
        private Label lbl_Infoencomienda;
        private Button BuscarBTN;
        private Button ConfirmBTN;
        private Button VolverBTN;
        public Label lbl_NameTutasa;
        private Label label3;
        private ColumnHeader numGuia;
    }
}