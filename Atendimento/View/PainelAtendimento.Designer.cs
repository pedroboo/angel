
namespace Atendimento
{
    partial class Form1
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
            this.btn_gerarSenha = new System.Windows.Forms.Button();
            this.btn_listaSenha = new System.Windows.Forms.Button();
            this.btn_chamaSenha = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_adcGuiche = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.guicheChama = new System.Windows.Forms.TextBox();
            this.btn_listaGuiche = new System.Windows.Forms.Button();
            this.listSenha = new System.Windows.Forms.ListView();
            this.listGuiche = new System.Windows.Forms.ListView();
            this.lbQtGuiches = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_gerarSenha
            // 
            this.btn_gerarSenha.Location = new System.Drawing.Point(67, 71);
            this.btn_gerarSenha.Name = "btn_gerarSenha";
            this.btn_gerarSenha.Size = new System.Drawing.Size(75, 23);
            this.btn_gerarSenha.TabIndex = 0;
            this.btn_gerarSenha.Text = "Gerar";
            this.btn_gerarSenha.UseVisualStyleBackColor = true;
            this.btn_gerarSenha.Click += new System.EventHandler(this.btn_gerarSenha_Click);
            // 
            // btn_listaSenha
            // 
            this.btn_listaSenha.Location = new System.Drawing.Point(67, 256);
            this.btn_listaSenha.Name = "btn_listaSenha";
            this.btn_listaSenha.Size = new System.Drawing.Size(75, 23);
            this.btn_listaSenha.TabIndex = 1;
            this.btn_listaSenha.Text = "Listar Senhas";
            this.btn_listaSenha.UseVisualStyleBackColor = true;
            this.btn_listaSenha.Click += new System.EventHandler(this.btn_listaSenha_Click);
            // 
            // btn_chamaSenha
            // 
            this.btn_chamaSenha.Location = new System.Drawing.Point(603, 73);
            this.btn_chamaSenha.Name = "btn_chamaSenha";
            this.btn_chamaSenha.Size = new System.Drawing.Size(75, 23);
            this.btn_chamaSenha.TabIndex = 4;
            this.btn_chamaSenha.Text = "Chamar";
            this.btn_chamaSenha.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Qtde Guichês";
            // 
            // btn_adcGuiche
            // 
            this.btn_adcGuiche.Location = new System.Drawing.Point(241, 227);
            this.btn_adcGuiche.Name = "btn_adcGuiche";
            this.btn_adcGuiche.Size = new System.Drawing.Size(75, 23);
            this.btn_adcGuiche.TabIndex = 7;
            this.btn_adcGuiche.Text = "Adicionar";
            this.btn_adcGuiche.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Guichê";
            // 
            // guicheChama
            // 
            this.guicheChama.Location = new System.Drawing.Point(489, 73);
            this.guicheChama.Name = "guicheChama";
            this.guicheChama.Size = new System.Drawing.Size(67, 20);
            this.guicheChama.TabIndex = 9;
            // 
            // btn_listaGuiche
            // 
            this.btn_listaGuiche.Location = new System.Drawing.Point(477, 256);
            this.btn_listaGuiche.Name = "btn_listaGuiche";
            this.btn_listaGuiche.Size = new System.Drawing.Size(189, 23);
            this.btn_listaGuiche.TabIndex = 11;
            this.btn_listaGuiche.Text = "Lista Atendimento";
            this.btn_listaGuiche.UseVisualStyleBackColor = true;
            // 
            // listSenha
            // 
            this.listSenha.HideSelection = false;
            this.listSenha.Location = new System.Drawing.Point(31, 99);
            this.listSenha.Name = "listSenha";
            this.listSenha.Size = new System.Drawing.Size(145, 151);
            this.listSenha.TabIndex = 12;
            this.listSenha.UseCompatibleStateImageBehavior = false;
            // 
            // listGuiche
            // 
            this.listGuiche.HideSelection = false;
            this.listGuiche.Location = new System.Drawing.Point(415, 102);
            this.listGuiche.Name = "listGuiche";
            this.listGuiche.Size = new System.Drawing.Size(336, 148);
            this.listGuiche.TabIndex = 13;
            this.listGuiche.UseCompatibleStateImageBehavior = false;
            // 
            // lbQtGuiches
            // 
            this.lbQtGuiches.AutoSize = true;
            this.lbQtGuiches.Location = new System.Drawing.Point(261, 168);
            this.lbQtGuiches.Name = "lbQtGuiches";
            this.lbQtGuiches.Size = new System.Drawing.Size(0, 13);
            this.lbQtGuiches.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 308);
            this.Controls.Add(this.lbQtGuiches);
            this.Controls.Add(this.listGuiche);
            this.Controls.Add(this.listSenha);
            this.Controls.Add(this.btn_listaGuiche);
            this.Controls.Add(this.guicheChama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_adcGuiche);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_chamaSenha);
            this.Controls.Add(this.btn_listaSenha);
            this.Controls.Add(this.btn_gerarSenha);
            this.Name = "Form1";
            this.Text = "Painel Atendimento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_gerarSenha;
        private System.Windows.Forms.Button btn_listaSenha;
        private System.Windows.Forms.Button btn_chamaSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_adcGuiche;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox guicheChama;
        private System.Windows.Forms.Button btn_listaGuiche;
        private System.Windows.Forms.ListView listSenha;
        private System.Windows.Forms.ListView listGuiche;
        private System.Windows.Forms.Label lbQtGuiches;
    }
}

