namespace ProjetoSistemaTI18N
{
    partial class Cadastrar
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
            this.label1 = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.estado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cadastrarBotao = new System.Windows.Forms.Button();
            this.voltar = new System.Windows.Forms.Button();
            this.codigo = new System.Windows.Forms.MaskedTextBox();
            this.telefone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("News706 BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // nome
            // 
            this.nome.BackColor = System.Drawing.SystemColors.Highlight;
            this.nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nome.Font = new System.Drawing.Font("News706 BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.nome.Location = new System.Drawing.Point(159, 123);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(191, 28);
            this.nome.TabIndex = 3;
            this.nome.TextChanged += new System.EventHandler(this.nome_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("News706 BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("News706 BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefone";
            // 
            // cidade
            // 
            this.cidade.BackColor = System.Drawing.SystemColors.Highlight;
            this.cidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cidade.Font = new System.Drawing.Font("News706 BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidade.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.cidade.Location = new System.Drawing.Point(161, 215);
            this.cidade.Name = "cidade";
            this.cidade.Size = new System.Drawing.Size(191, 28);
            this.cidade.TabIndex = 7;
            this.cidade.TextChanged += new System.EventHandler(this.cidade_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("News706 BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cidade";
            // 
            // estado
            // 
            this.estado.BackColor = System.Drawing.SystemColors.Highlight;
            this.estado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.estado.Font = new System.Drawing.Font("News706 BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estado.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.estado.Location = new System.Drawing.Point(161, 265);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(191, 28);
            this.estado.TabIndex = 9;
            this.estado.TextChanged += new System.EventHandler(this.estado_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("News706 BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("News706 BT", 18F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(53, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(273, 36);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cadastrar Pessoa";
            // 
            // cadastrarBotao
            // 
            this.cadastrarBotao.BackColor = System.Drawing.Color.IndianRed;
            this.cadastrarBotao.Font = new System.Drawing.Font("News706 BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrarBotao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cadastrarBotao.Location = new System.Drawing.Point(-3, 329);
            this.cadastrarBotao.Name = "cadastrarBotao";
            this.cadastrarBotao.Size = new System.Drawing.Size(395, 46);
            this.cadastrarBotao.TabIndex = 11;
            this.cadastrarBotao.Text = "Cadastrar";
            this.cadastrarBotao.UseVisualStyleBackColor = false;
            this.cadastrarBotao.Click += new System.EventHandler(this.cadastrarBotao_Click);
            // 
            // voltar
            // 
            this.voltar.BackColor = System.Drawing.Color.IndianRed;
            this.voltar.Font = new System.Drawing.Font("News706 BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.voltar.Location = new System.Drawing.Point(-3, 381);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(395, 46);
            this.voltar.TabIndex = 12;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = false;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // codigo
            // 
            this.codigo.BackColor = System.Drawing.SystemColors.Highlight;
            this.codigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.codigo.Font = new System.Drawing.Font("News706 BT", 13.8F, System.Drawing.FontStyle.Bold);
            this.codigo.ForeColor = System.Drawing.SystemColors.Window;
            this.codigo.Location = new System.Drawing.Point(159, 80);
            this.codigo.Mask = "99999";
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(190, 28);
            this.codigo.TabIndex = 13;
            this.codigo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.codigo_MaskInputRejected);
            // 
            // telefone
            // 
            this.telefone.BackColor = System.Drawing.SystemColors.Highlight;
            this.telefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.telefone.Font = new System.Drawing.Font("News706 BT", 13.8F, System.Drawing.FontStyle.Bold);
            this.telefone.ForeColor = System.Drawing.SystemColors.Window;
            this.telefone.Location = new System.Drawing.Point(161, 171);
            this.telefone.Mask = "(99) 99999-9999";
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(189, 28);
            this.telefone.TabIndex = 14;
            this.telefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.telefone_MaskInputRejected);
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 450);
            this.Controls.Add(this.telefone);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.cadastrarBotao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cadastrar";
            this.Text = "Cadastrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox estado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cadastrarBotao;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.MaskedTextBox codigo;
        private System.Windows.Forms.MaskedTextBox telefone;
    }
}