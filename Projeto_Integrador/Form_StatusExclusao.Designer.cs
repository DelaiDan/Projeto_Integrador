namespace Projeto_Integrador
{
    partial class Form_StatusExclusao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_StatusExclusao));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Troca = new System.Windows.Forms.Button();
            this.btn_Venda = new System.Windows.Forms.Button();
            this.btn_Repasse = new System.Windows.Forms.Button();
            this.btn_Consignado = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Outro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Qual seria o Motivo da Exclusão?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Troca
            // 
            this.btn_Troca.Location = new System.Drawing.Point(114, 85);
            this.btn_Troca.Name = "btn_Troca";
            this.btn_Troca.Size = new System.Drawing.Size(92, 28);
            this.btn_Troca.TabIndex = 1;
            this.btn_Troca.Text = "Troca";
            this.btn_Troca.UseVisualStyleBackColor = true;
            this.btn_Troca.Click += new System.EventHandler(this.btn_Troca_Click);
            // 
            // btn_Venda
            // 
            this.btn_Venda.Location = new System.Drawing.Point(114, 142);
            this.btn_Venda.Name = "btn_Venda";
            this.btn_Venda.Size = new System.Drawing.Size(92, 28);
            this.btn_Venda.TabIndex = 2;
            this.btn_Venda.Text = "Venda";
            this.btn_Venda.UseVisualStyleBackColor = true;
            this.btn_Venda.Click += new System.EventHandler(this.btn_Venda_Click);
            // 
            // btn_Repasse
            // 
            this.btn_Repasse.Location = new System.Drawing.Point(281, 85);
            this.btn_Repasse.Name = "btn_Repasse";
            this.btn_Repasse.Size = new System.Drawing.Size(92, 28);
            this.btn_Repasse.TabIndex = 3;
            this.btn_Repasse.Text = "Repasse";
            this.btn_Repasse.UseVisualStyleBackColor = true;
            this.btn_Repasse.Click += new System.EventHandler(this.btn_Repasse_Click);
            // 
            // btn_Consignado
            // 
            this.btn_Consignado.Location = new System.Drawing.Point(281, 142);
            this.btn_Consignado.Name = "btn_Consignado";
            this.btn_Consignado.Size = new System.Drawing.Size(92, 28);
            this.btn_Consignado.TabIndex = 4;
            this.btn_Consignado.Text = "Consignado";
            this.btn_Consignado.UseVisualStyleBackColor = true;
            this.btn_Consignado.Click += new System.EventHandler(this.btn_Consignado_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(281, 202);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(92, 28);
            this.btn_Cancelar.TabIndex = 5;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Outro
            // 
            this.btn_Outro.Location = new System.Drawing.Point(114, 202);
            this.btn_Outro.Name = "btn_Outro";
            this.btn_Outro.Size = new System.Drawing.Size(92, 28);
            this.btn_Outro.TabIndex = 6;
            this.btn_Outro.Text = "Erro/Outro";
            this.btn_Outro.UseVisualStyleBackColor = true;
            this.btn_Outro.Click += new System.EventHandler(this.btn_Outro_Click);
            // 
            // Form_StatusExclusao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 250);
            this.Controls.Add(this.btn_Outro);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Consignado);
            this.Controls.Add(this.btn_Repasse);
            this.Controls.Add(this.btn_Venda);
            this.Controls.Add(this.btn_Troca);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_StatusExclusao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Motivo da Exclusão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Troca;
        private System.Windows.Forms.Button btn_Venda;
        private System.Windows.Forms.Button btn_Repasse;
        private System.Windows.Forms.Button btn_Consignado;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Outro;
    }
}