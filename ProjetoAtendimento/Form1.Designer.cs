namespace ProjetoAtendimento
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lstSenhas = new System.Windows.Forms.ListBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnListarSenhas = new System.Windows.Forms.Button();
            this.lblGuiche = new System.Windows.Forms.Label();
            this.nudGuicheId = new System.Windows.Forms.NumericUpDown();
            this.btnAdicionarGuiche = new System.Windows.Forms.Button();
            this.lblQtdGuiches = new System.Windows.Forms.Label();
            this.btnChamar = new System.Windows.Forms.Button();
            this.lstAtendimentos = new System.Windows.Forms.ListBox();
            this.btnListarAtendimentos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudGuicheId)).BeginInit();
            this.SuspendLayout();
            // 
            // lstSenhas
            // 
            this.lstSenhas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstSenhas.FormattingEnabled = true;
            this.lstSenhas.ItemHeight = 17;
            this.lstSenhas.Location = new System.Drawing.Point(20, 60);
            this.lstSenhas.Name = "lstSenhas";
            this.lstSenhas.Size = new System.Drawing.Size(250, 259);
            this.lstSenhas.TabIndex = 0;
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(20, 20);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(100, 30);
            this.btnGerar.TabIndex = 1;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // btnListarSenhas
            // 
            this.btnListarSenhas.Location = new System.Drawing.Point(20, 330);
            this.btnListarSenhas.Name = "btnListarSenhas";
            this.btnListarSenhas.Size = new System.Drawing.Size(250, 30);
            this.btnListarSenhas.TabIndex = 2;
            this.btnListarSenhas.Text = "Listar Senhas";
            this.btnListarSenhas.UseVisualStyleBackColor = true;
            this.btnListarSenhas.Click += new System.EventHandler(this.btnListarSenhas_Click);
            // 
            // lblGuiche
            // 
            this.lblGuiche.AutoSize = true;
            this.lblGuiche.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGuiche.Location = new System.Drawing.Point(300, 30);
            this.lblGuiche.Name = "lblGuiche";
            this.lblGuiche.Size = new System.Drawing.Size(55, 19);
            this.lblGuiche.TabIndex = 3;
            this.lblGuiche.Text = "Guichê:";
            // 
            // nudGuicheId
            // 
            this.nudGuicheId.Location = new System.Drawing.Point(360, 30);
            this.nudGuicheId.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudGuicheId.Name = "nudGuicheId";
            this.nudGuicheId.Size = new System.Drawing.Size(60, 23);
            this.nudGuicheId.TabIndex = 4;
            this.nudGuicheId.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAdicionarGuiche
            // 
            this.btnAdicionarGuiche.Location = new System.Drawing.Point(430, 25);
            this.btnAdicionarGuiche.Name = "btnAdicionarGuiche";
            this.btnAdicionarGuiche.Size = new System.Drawing.Size(100, 30);
            this.btnAdicionarGuiche.TabIndex = 5;
            this.btnAdicionarGuiche.Text = "Adicionar";
            this.btnAdicionarGuiche.UseVisualStyleBackColor = true;
            this.btnAdicionarGuiche.Click += new System.EventHandler(this.btnAdicionarGuiche_Click);
            // 
            // lblQtdGuiches
            // 
            this.lblQtdGuiches.AutoSize = true;
            this.lblQtdGuiches.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblQtdGuiches.Location = new System.Drawing.Point(540, 30);
            this.lblQtdGuiches.Name = "lblQtdGuiches";
            this.lblQtdGuiches.Size = new System.Drawing.Size(19, 21);
            this.lblQtdGuiches.TabIndex = 6;
            this.lblQtdGuiches.Text = "0";
            // 
            // btnChamar
            // 
            this.btnChamar.Location = new System.Drawing.Point(580, 25);
            this.btnChamar.Name = "btnChamar";
            this.btnChamar.Size = new System.Drawing.Size(100, 30);
            this.btnChamar.TabIndex = 7;
            this.btnChamar.Text = "Chamar";
            this.btnChamar.UseVisualStyleBackColor = true;
            this.btnChamar.Click += new System.EventHandler(this.btnChamar_Click);
            // 
            // lstAtendimentos
            // 
            this.lstAtendimentos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstAtendimentos.FormattingEnabled = true;
            this.lstAtendimentos.ItemHeight = 17;
            this.lstAtendimentos.Location = new System.Drawing.Point(300, 60);
            this.lstAtendimentos.Name = "lstAtendimentos";
            this.lstAtendimentos.Size = new System.Drawing.Size(380, 259);
            this.lstAtendimentos.TabIndex = 8;
            // 
            // btnListarAtendimentos
            // 
            this.btnListarAtendimentos.Location = new System.Drawing.Point(300, 330);
            this.btnListarAtendimentos.Name = "btnListarAtendimentos";
            this.btnListarAtendimentos.Size = new System.Drawing.Size(380, 30);
            this.btnListarAtendimentos.TabIndex = 9;
            this.btnListarAtendimentos.Text = "Listar Atendimentos";
            this.btnListarAtendimentos.UseVisualStyleBackColor = true;
            this.btnListarAtendimentos.Click += new System.EventHandler(this.btnListarAtendimentos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 381);
            this.Controls.Add(this.btnListarAtendimentos);
            this.Controls.Add(this.lstAtendimentos);
            this.Controls.Add(this.btnChamar);
            this.Controls.Add(this.lblQtdGuiches);
            this.Controls.Add(this.btnAdicionarGuiche);
            this.Controls.Add(this.nudGuicheId);
            this.Controls.Add(this.lblGuiche);
            this.Controls.Add(this.btnListarSenhas);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.lstSenhas);
            this.Name = "Form1";
            this.Text = "Projeto Atendimento";
            ((System.ComponentModel.ISupportInitialize)(this.nudGuicheId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSenhas;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnListarSenhas;
        private System.Windows.Forms.Label lblGuiche;
        private System.Windows.Forms.NumericUpDown nudGuicheId;
        private System.Windows.Forms.Button btnAdicionarGuiche;
        private System.Windows.Forms.Label lblQtdGuiches;
        private System.Windows.Forms.Button btnChamar;
        private System.Windows.Forms.ListBox lstAtendimentos;
        private System.Windows.Forms.Button btnListarAtendimentos;
    }
}
