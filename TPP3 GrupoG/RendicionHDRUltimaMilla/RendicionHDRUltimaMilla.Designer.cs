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
            guiaAsociadaLISTARendir = new ListView();
            resultado = new Label();
            resultadoCMB = new ComboBox();
            confirmarRendicion = new Button();
            emitirResumen = new Button();
            label1 = new Label();
            label2 = new Label();
            listViewHDR = new ListView();
            listViewGUIASaEntregar = new ListView();
            SuspendLayout();
            // 
            // dniFletero
            // 
            dniFletero.AutoSize = true;
            dniFletero.Location = new Point(22, 15);
            dniFletero.Margin = new Padding(2, 0, 2, 0);
            dniFletero.Name = "dniFletero";
            dniFletero.Size = new Size(66, 15);
            dniFletero.TabIndex = 0;
            dniFletero.Text = "DNI Fletero";
            // 
            // buscarFletero
            // 
            buscarFletero.Location = new Point(218, 14);
            buscarFletero.Margin = new Padding(2);
            buscarFletero.Name = "buscarFletero";
            buscarFletero.Size = new Size(78, 24);
            buscarFletero.TabIndex = 1;
            buscarFletero.Text = "Buscar";
            buscarFletero.UseVisualStyleBackColor = true;
            buscarFletero.Click += buscarFletero_Click;
            // 
            // dniFleteroTXT
            // 
            dniFleteroTXT.Location = new Point(97, 15);
            dniFleteroTXT.Margin = new Padding(2);
            dniFleteroTXT.Name = "dniFleteroTXT";
            dniFleteroTXT.Size = new Size(106, 23);
            dniFleteroTXT.TabIndex = 2;
            // 
            // hdrPendiente
            // 
            hdrPendiente.AutoSize = true;
            hdrPendiente.Location = new Point(22, 268);
            hdrPendiente.Margin = new Padding(2, 0, 2, 0);
            hdrPendiente.Name = "hdrPendiente";
            hdrPendiente.Size = new Size(120, 15);
            hdrPendiente.TabIndex = 3;
            hdrPendiente.Text = "Hojas de ruta a rendir";
            // 
            // guiaAsociada
            // 
            guiaAsociada.AutoSize = true;
            guiaAsociada.Location = new Point(453, 268);
            guiaAsociada.Margin = new Padding(2, 0, 2, 0);
            guiaAsociada.Name = "guiaAsociada";
            guiaAsociada.Size = new Size(36, 15);
            guiaAsociada.TabIndex = 4;
            guiaAsociada.Text = "Guías";
            guiaAsociada.Click += guiaAsociada_Click;
            // 
            // hdrPendienteLIST
            // 
            hdrPendienteLIST.Columns.AddRange(new ColumnHeader[] { numHDR, tipoHDR, domicilioVisitar });
            hdrPendienteLIST.FullRowSelect = true;
            hdrPendienteLIST.Location = new Point(22, 285);
            hdrPendienteLIST.Margin = new Padding(2);
            hdrPendienteLIST.MultiSelect = false;
            hdrPendienteLIST.Name = "hdrPendienteLIST";
            hdrPendienteLIST.Size = new Size(427, 155);
            hdrPendienteLIST.TabIndex = 5;
            hdrPendienteLIST.UseCompatibleStateImageBehavior = false;
            hdrPendienteLIST.View = View.Details;
            hdrPendienteLIST.SelectedIndexChanged += hdrPendienteLIST_SelectedIndexChanged;
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
            // guiaAsociadaLISTARendir
            // 
            guiaAsociadaLISTARendir.FullRowSelect = true;
            guiaAsociadaLISTARendir.Location = new Point(453, 285);
            guiaAsociadaLISTARendir.Margin = new Padding(2);
            guiaAsociadaLISTARendir.MultiSelect = false;
            guiaAsociadaLISTARendir.Name = "guiaAsociadaLISTARendir";
            guiaAsociadaLISTARendir.Size = new Size(340, 155);
            guiaAsociadaLISTARendir.TabIndex = 6;
            guiaAsociadaLISTARendir.UseCompatibleStateImageBehavior = false;
            guiaAsociadaLISTARendir.View = View.Details;
            // 
            // resultado
            // 
            resultado.AutoSize = true;
            resultado.Location = new Point(31, 456);
            resultado.Margin = new Padding(2, 0, 2, 0);
            resultado.Name = "resultado";
            resultado.Size = new Size(62, 15);
            resultado.TabIndex = 7;
            resultado.Text = "Resultado:";
            // 
            // resultadoCMB
            // 
            resultadoCMB.FormattingEnabled = true;
            resultadoCMB.Items.AddRange(new object[] { "Entregada", "Retirada", "No entregada", "No retirada", "Incidencia" });
            resultadoCMB.Location = new Point(106, 448);
            resultadoCMB.Margin = new Padding(2);
            resultadoCMB.Name = "resultadoCMB";
            resultadoCMB.Size = new Size(129, 23);
            resultadoCMB.TabIndex = 8;
            resultadoCMB.SelectedIndexChanged += resultadoCMB_SelectedIndexChanged;
            // 
            // confirmarRendicion
            // 
            confirmarRendicion.Location = new Point(239, 446);
            confirmarRendicion.Margin = new Padding(2);
            confirmarRendicion.Name = "confirmarRendicion";
            confirmarRendicion.Size = new Size(78, 31);
            confirmarRendicion.TabIndex = 11;
            confirmarRendicion.Text = "Confirmar";
            confirmarRendicion.UseVisualStyleBackColor = true;
            // 
            // emitirResumen
            // 
            emitirResumen.Location = new Point(704, 508);
            emitirResumen.Margin = new Padding(2);
            emitirResumen.Name = "emitirResumen";
            emitirResumen.Size = new Size(98, 31);
            emitirResumen.TabIndex = 12;
            emitirResumen.Text = "Emitir resumen";
            emitirResumen.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 50);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(182, 15);
            label1.TabIndex = 13;
            label1.Text = "Hojas de ruta a entregar al fletero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(453, 50);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 16;
            label2.Text = "Guías";
            // 
            // listViewHDR
            // 
            listViewHDR.Location = new Point(22, 68);
            listViewHDR.Name = "listViewHDR";
            listViewHDR.Size = new Size(427, 162);
            listViewHDR.TabIndex = 17;
            listViewHDR.UseCompatibleStateImageBehavior = false;
            listViewHDR.SelectedIndexChanged += listViewHDR_SelectedIndexChanged;
            // 
            // listViewGUIASaEntregar
            // 
            listViewGUIASaEntregar.Location = new Point(455, 68);
            listViewGUIASaEntregar.Name = "listViewGUIASaEntregar";
            listViewGUIASaEntregar.Size = new Size(338, 162);
            listViewGUIASaEntregar.TabIndex = 18;
            listViewGUIASaEntregar.UseCompatibleStateImageBehavior = false;

            // 
            // Rendicion_de_HDR_Ultima_Milla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 558);
            Controls.Add(listViewGUIASaEntregar);
            Controls.Add(listViewHDR);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(emitirResumen);
            Controls.Add(confirmarRendicion);
            Controls.Add(resultadoCMB);
            Controls.Add(resultado);
            Controls.Add(guiaAsociadaLISTARendir);
            Controls.Add(hdrPendienteLIST);
            Controls.Add(guiaAsociada);
            Controls.Add(hdrPendiente);
            Controls.Add(dniFleteroTXT);
            Controls.Add(buscarFletero);
            Controls.Add(dniFletero);
            Margin = new Padding(2);
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
        private ListView guiaAsociadaLISTARendir;
        private ColumnHeader numHDR;
        private ColumnHeader tipoHDR;
        private ColumnHeader domicilioVisitar;
        private Label resultado;
        private ComboBox resultadoCMB;
        private Button confirmarRendicion;
        private Button emitirResumen;
        private Label label1;
        private Label label2;
        private ListView listViewHDR;
        private ListView listViewGUIASaEntregar;
    }
}