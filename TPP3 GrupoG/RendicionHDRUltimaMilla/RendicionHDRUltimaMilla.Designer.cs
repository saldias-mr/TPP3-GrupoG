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
            guiaAsociadaLIST = new ListView();
            numHDR = new ColumnHeader();
            tipoHDR = new ColumnHeader();
            domicilioVisitar = new ColumnHeader();
            resultado = new Label();
            resultadoCMB = new ComboBox();
            motivoIncidencia = new Label();
            motivoIncidenciaTXT = new TextBox();
            confirmarRendicion = new Button();
            emitirResumen = new Button();
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
            buscarFletero.Size = new Size(112, 34);
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
            hdrPendiente.Location = new Point(31, 95);
            hdrPendiente.Name = "hdrPendiente";
            hdrPendiente.Size = new Size(118, 25);
            hdrPendiente.TabIndex = 3;
            hdrPendiente.Text = "Hojas de ruta";
            // 
            // guiaAsociada
            // 
            guiaAsociada.AutoSize = true;
            guiaAsociada.Location = new Point(397, 98);
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
            hdrPendienteLIST.Location = new Point(31, 126);
            hdrPendienteLIST.MultiSelect = false;
            hdrPendienteLIST.Name = "hdrPendienteLIST";
            hdrPendienteLIST.Size = new Size(274, 255);
            hdrPendienteLIST.TabIndex = 5;
            hdrPendienteLIST.UseCompatibleStateImageBehavior = false;
            hdrPendienteLIST.View = View.Details;
            // 
            // guiaAsociadaLIST
            // 
            guiaAsociadaLIST.FullRowSelect = true;
            guiaAsociadaLIST.Location = new Point(397, 126);
            guiaAsociadaLIST.MultiSelect = false;
            guiaAsociadaLIST.Name = "guiaAsociadaLIST";
            guiaAsociadaLIST.Size = new Size(172, 255);
            guiaAsociadaLIST.TabIndex = 6;
            guiaAsociadaLIST.UseCompatibleStateImageBehavior = false;
            guiaAsociadaLIST.View = View.Details;
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
            domicilioVisitar.Text = "Domicilio";
            domicilioVisitar.Width = 90;
            // 
            // resultado
            // 
            resultado.AutoSize = true;
            resultado.Location = new Point(31, 400);
            resultado.Name = "resultado";
            resultado.Size = new Size(94, 25);
            resultado.TabIndex = 7;
            resultado.Text = "Resultado:";
            // 
            // resultadoCMB
            // 
            resultadoCMB.FormattingEnabled = true;
            resultadoCMB.Items.AddRange(new object[] { "Entregada", "Retirada", "No entregada", "No retirada", "Incidencia" });
            resultadoCMB.Location = new Point(123, 392);
            resultadoCMB.Name = "resultadoCMB";
            resultadoCMB.Size = new Size(182, 33);
            resultadoCMB.TabIndex = 8;
            // 
            // motivoIncidencia
            // 
            motivoIncidencia.AutoSize = true;
            motivoIncidencia.Location = new Point(31, 439);
            motivoIncidencia.Name = "motivoIncidencia";
            motivoIncidencia.Size = new Size(73, 25);
            motivoIncidencia.TabIndex = 9;
            motivoIncidencia.Text = "Motivo:";
            // 
            // motivoIncidenciaTXT
            // 
            motivoIncidenciaTXT.Location = new Point(123, 439);
            motivoIncidenciaTXT.Name = "motivoIncidenciaTXT";
            motivoIncidenciaTXT.Size = new Size(182, 31);
            motivoIncidenciaTXT.TabIndex = 10;
            // 
            // confirmarRendicion
            // 
            confirmarRendicion.Location = new Point(311, 482);
            confirmarRendicion.Name = "confirmarRendicion";
            confirmarRendicion.Size = new Size(112, 34);
            confirmarRendicion.TabIndex = 11;
            confirmarRendicion.Text = "Confirmar";
            confirmarRendicion.UseVisualStyleBackColor = true;
            // 
            // emitirResumen
            // 
            emitirResumen.Location = new Point(429, 482);
            emitirResumen.Name = "emitirResumen";
            emitirResumen.Size = new Size(140, 34);
            emitirResumen.TabIndex = 12;
            emitirResumen.Text = "Emitir resumen";
            emitirResumen.UseVisualStyleBackColor = true;
            // 
            // Rendicion_de_HDR_Ultima_Milla
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 528);
            Controls.Add(emitirResumen);
            Controls.Add(confirmarRendicion);
            Controls.Add(motivoIncidenciaTXT);
            Controls.Add(motivoIncidencia);
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
        private Label motivoIncidencia;
        private TextBox motivoIncidenciaTXT;
        private Button confirmarRendicion;
        private Button emitirResumen;
    }
}