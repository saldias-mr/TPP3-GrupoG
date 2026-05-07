namespace TPP3_GrupoG.RendicionHDRUltimaMilla
{
    partial class Rendicion_de_HDR_Ultima_Milla
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
            dniFletero = new Label();
            buscarFletero = new Button();
            dniFleteroTXT = new TextBox();
            hdrPendiente = new Label();
            guiaAsociada = new Label();
            hdrPendienteLIST = new ListView();
            numHDR = new ColumnHeader();
            tipoHDR = new ColumnHeader();
            domicilioVisitar = new ColumnHeader();
            guiaAsociadaLIST = new ListView();
            resultado = new Label();
            resultadoCMB = new ComboBox();
            confirmarRendicion = new Button();
            emitirResumen = new Button();
            listView1 = new ListView();
            listView2 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // dniFletero
            // 
            dniFletero.AutoSize = true;
            dniFletero.Location = new Point(31, 25);
            dniFletero.Name = "dniFletero";
            dniFletero.Size = new Size(102, 25);
            dniFletero.TabIndex = 0;
            dniFletero.Text = "DNI Fletero";
            // 
            // buscarFletero
            // 
            buscarFletero.Location = new Point(311, 23);
            buscarFletero.Name = "buscarFletero";
            buscarFletero.Size = new Size(111, 40);
            buscarFletero.TabIndex = 1;
            buscarFletero.Text = "Buscar";
            buscarFletero.UseVisualStyleBackColor = true;
            // 
            // dniFleteroTXT
            // 
            dniFleteroTXT.Location = new Point(139, 25);
            dniFleteroTXT.Name = "dniFleteroTXT";
            dniFleteroTXT.Size = new Size(150, 31);
            dniFleteroTXT.TabIndex = 2;
            // 
            // hdrPendiente
            // 
            hdrPendiente.AutoSize = true;
            hdrPendiente.Location = new Point(31, 447);
            hdrPendiente.Name = "hdrPendiente";
            hdrPendiente.Size = new Size(183, 25);
            hdrPendiente.TabIndex = 3;
            hdrPendiente.Text = "Hojas de ruta a rendir";
            // 
            // guiaAsociada
            // 
            guiaAsociada.AutoSize = true;
            guiaAsociada.Location = new Point(647, 447);
            guiaAsociada.Name = "guiaAsociada";
            guiaAsociada.Size = new Size(55, 25);
            guiaAsociada.TabIndex = 4;
            guiaAsociada.Text = "Guías";
            guiaAsociada.Click += guiaAsociada_Click;
            // 
            // hdrPendienteLIST
            // 
            hdrPendienteLIST.Columns.AddRange(new ColumnHeader[] { numHDR, tipoHDR, domicilioVisitar });
            hdrPendienteLIST.FullRowSelect = true;
            hdrPendienteLIST.Location = new Point(31, 475);
            hdrPendienteLIST.MultiSelect = false;
            hdrPendienteLIST.Name = "hdrPendienteLIST";
            hdrPendienteLIST.Size = new Size(608, 256);
            hdrPendienteLIST.TabIndex = 5;
            hdrPendienteLIST.UseCompatibleStateImageBehavior = false;
            hdrPendienteLIST.View = View.Details;
            // 
            // numHDR
            // 
            numHDR.Text = "Nº HDR";
            numHDR.Width = 90;
            // 
            // tipoHDR
            // 
            tipoHDR.Text = "Tipo";
            tipoHDR.Width = 90;
            // 
            // domicilioVisitar
            // 
            domicilioVisitar.Text = "Dirección";
            domicilioVisitar.Width = 90;
            // 
            // guiaAsociadaLIST
            // 
            guiaAsociadaLIST.FullRowSelect = true;
            guiaAsociadaLIST.Location = new Point(647, 475);
            guiaAsociadaLIST.MultiSelect = false;
            guiaAsociadaLIST.Name = "guiaAsociadaLIST";
            guiaAsociadaLIST.Size = new Size(484, 256);
            guiaAsociadaLIST.TabIndex = 6;
            guiaAsociadaLIST.UseCompatibleStateImageBehavior = false;
            guiaAsociadaLIST.View = View.Details;
            // 
            // resultado
            // 
            resultado.AutoSize = true;
            resultado.Location = new Point(44, 760);
            resultado.Name = "resultado";
            resultado.Size = new Size(94, 25);
            resultado.TabIndex = 7;
            resultado.Text = "Resultado:";
            // 
            // resultadoCMB
            // 
            resultadoCMB.FormattingEnabled = true;
            resultadoCMB.Items.AddRange(new object[] { "Entregada", "Retirada", "No entregada", "No retirada", "Incidencia" });
            resultadoCMB.Location = new Point(151, 747);
            resultadoCMB.Name = "resultadoCMB";
            resultadoCMB.Size = new Size(183, 33);
            resultadoCMB.TabIndex = 8;
            // 
            // confirmarRendicion
            // 
            confirmarRendicion.Location = new Point(341, 743);
            confirmarRendicion.Name = "confirmarRendicion";
            confirmarRendicion.Size = new Size(111, 52);
            confirmarRendicion.TabIndex = 11;
            confirmarRendicion.Text = "Confirmar";
            confirmarRendicion.UseVisualStyleBackColor = true;
            // 
            // emitirResumen
            // 
            emitirResumen.Location = new Point(1006, 847);
            emitirResumen.Name = "emitirResumen";
            emitirResumen.Size = new Size(140, 52);
            emitirResumen.TabIndex = 12;
            emitirResumen.Text = "Emitir resumen";
            emitirResumen.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.FullRowSelect = true;
            listView1.Location = new Point(647, 115);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(484, 256);
            listView1.TabIndex = 15;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView2.FullRowSelect = true;
            listView2.Location = new Point(31, 115);
            listView2.MultiSelect = false;
            listView2.Name = "listView2";
            listView2.Size = new Size(608, 256);
            listView2.TabIndex = 14;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nº HDR";
            columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tipo";
            columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Dirección";
            columnHeader3.Width = 90;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 83);
            label1.Name = "label1";
            label1.Size = new Size(277, 25);
            label1.TabIndex = 13;
            label1.Text = "Hojas de ruta a entregar al fletero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(647, 83);
            label2.Name = "label2";
            label2.Size = new Size(55, 25);
            label2.TabIndex = 16;
            label2.Text = "Guías";
            // 
            // Rendicion_de_HDR_Ultima_Milla
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 930);
            Controls.Add(label2);
            Controls.Add(listView1);
            Controls.Add(listView2);
            Controls.Add(label1);
            Controls.Add(emitirResumen);
            Controls.Add(confirmarRendicion);
            Controls.Add(resultadoCMB);
            Controls.Add(resultado);
            Controls.Add(guiaAsociadaLIST);
            Controls.Add(hdrPendienteLIST);
            Controls.Add(guiaAsociada);
            Controls.Add(hdrPendiente);
            Controls.Add(dniFleteroTXT);
            Controls.Add(buscarFletero);
            Controls.Add(dniFletero);
            Name = "Rendicion_de_HDR_Ultima_Milla";
            Text = "Rendición de HDR Última Milla";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label dniFletero;
        private Button buscarFletero;
        private TextBox dniFleteroTXT;
        private Label hdrPendiente;
        private Label guiaAsociada;
        private ListView hdrPendienteLIST;
        private ListView guiaAsociadaLIST;
        private ColumnHeader numHDR;
        private ColumnHeader tipoHDR;
        private ColumnHeader domicilioVisitar;
        private Label resultado;
        private ComboBox resultadoCMB;
        private Button confirmarRendicion;
        private Button emitirResumen;
        private ListView listView1;
        private ListView listView2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label label1;
        private Label label2;
    }
}