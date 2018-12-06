namespace avaliate.View
{
    partial class GerenciarQuestoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerenciarQuestoes));
            this.gradientPanel1 = new avaliate.gradientPanel();
            this.excluir = new System.Windows.Forms.Button();
            this.labelQuestao = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.titulo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Atualizar = new System.Windows.Forms.Button();
            this.resposta = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.enunciado = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tipoQuestao = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gradientPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(59)))), ((int)(((byte)(209)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(67)))), ((int)(((byte)(184)))));
            this.gradientPanel1.Controls.Add(this.excluir);
            this.gradientPanel1.Controls.Add(this.labelQuestao);
            this.gradientPanel1.Controls.Add(this.groupBox1);
            this.gradientPanel1.Controls.Add(this.comboBox1);
            this.gradientPanel1.Controls.Add(this.pictureBox1);
            this.gradientPanel1.Location = new System.Drawing.Point(1, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1102, 666);
            this.gradientPanel1.TabIndex = 0;
            // 
            // excluir
            // 
            this.excluir.BackColor = System.Drawing.Color.White;
            this.excluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.excluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.excluir.FlatAppearance.BorderSize = 2;
            this.excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excluir.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(59)))), ((int)(((byte)(209)))));
            this.excluir.Location = new System.Drawing.Point(918, 169);
            this.excluir.Name = "excluir";
            this.excluir.Size = new System.Drawing.Size(138, 42);
            this.excluir.TabIndex = 11;
            this.excluir.Text = "Excluir";
            this.excluir.UseVisualStyleBackColor = false;
            this.excluir.Click += new System.EventHandler(this.excluir_Click);
            // 
            // labelQuestao
            // 
            this.labelQuestao.AutoSize = true;
            this.labelQuestao.BackColor = System.Drawing.Color.Transparent;
            this.labelQuestao.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestao.ForeColor = System.Drawing.Color.White;
            this.labelQuestao.Location = new System.Drawing.Point(21, 170);
            this.labelQuestao.Name = "labelQuestao";
            this.labelQuestao.Size = new System.Drawing.Size(226, 33);
            this.labelQuestao.TabIndex = 11;
            this.labelQuestao.Text = "Titulo da Questão : ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.titulo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.Atualizar);
            this.groupBox1.Controls.Add(this.resposta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.enunciado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tipoQuestao);
            this.groupBox1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(11, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1060, 434);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Atualizar Questão";
            // 
            // titulo
            // 
            this.titulo.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(474, 101);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(536, 40);
            this.titulo.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(468, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 33);
            this.label4.TabIndex = 9;
            this.label4.Text = "Título da Questão:";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(543, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 62);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Atualizar
            // 
            this.Atualizar.FlatAppearance.BorderSize = 2;
            this.Atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Atualizar.Location = new System.Drawing.Point(785, 347);
            this.Atualizar.Name = "Atualizar";
            this.Atualizar.Size = new System.Drawing.Size(225, 62);
            this.Atualizar.TabIndex = 7;
            this.Atualizar.Text = "Atualizar Questão";
            this.Atualizar.UseVisualStyleBackColor = true;
            this.Atualizar.Click += new System.EventHandler(this.Atualizar_Click);
            // 
            // resposta
            // 
            this.resposta.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resposta.Location = new System.Drawing.Point(474, 202);
            this.resposta.Name = "resposta";
            this.resposta.Size = new System.Drawing.Size(536, 111);
            this.resposta.TabIndex = 6;
            this.resposta.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(468, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resposta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enunciado:";
            // 
            // enunciado
            // 
            this.enunciado.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enunciado.Location = new System.Drawing.Point(34, 202);
            this.enunciado.Name = "enunciado";
            this.enunciado.Size = new System.Drawing.Size(418, 111);
            this.enunciado.TabIndex = 3;
            this.enunciado.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo da Questão : ";
            // 
            // tipoQuestao
            // 
            this.tipoQuestao.BackColor = System.Drawing.Color.White;
            this.tipoQuestao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tipoQuestao.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoQuestao.FormattingEnabled = true;
            this.tipoQuestao.Items.AddRange(new object[] {
            "Discertativa",
            "Alternativa",
            "Relação"});
            this.tipoQuestao.Location = new System.Drawing.Point(34, 100);
            this.tipoQuestao.Name = "tipoQuestao";
            this.tipoQuestao.Size = new System.Drawing.Size(418, 41);
            this.tipoQuestao.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(257, 170);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(655, 41);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(318, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(556, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // GerenciarQuestoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.gradientPanel1);
            this.Name = "GerenciarQuestoes";
            this.Text = "Gerenciar Questões";
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private gradientPanel gradientPanel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox titulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Atualizar;
        private System.Windows.Forms.RichTextBox resposta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox enunciado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox tipoQuestao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button excluir;
        private System.Windows.Forms.Label labelQuestao;
    }
}