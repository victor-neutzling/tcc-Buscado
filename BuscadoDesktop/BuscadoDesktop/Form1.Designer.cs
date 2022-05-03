namespace BuscadoDesktop
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.cbModoEditor = new System.Windows.Forms.CheckBox();
            this.cbMostrarSenha = new System.Windows.Forms.CheckBox();
            this.btSair = new System.Windows.Forms.Button();
            this.btLogin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscado Desktop Edition";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Senha";
            // 
            // tbUsuario
            // 
            this.tbUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F);
            this.tbUsuario.Location = new System.Drawing.Point(102, 56);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(309, 26);
            this.tbUsuario.TabIndex = 3;
            this.tbUsuario.TextChanged += new System.EventHandler(this.tbUsuario_TextChanged);
            // 
            // tbSenha
            // 
            this.tbSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSenha.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F);
            this.tbSenha.Location = new System.Drawing.Point(102, 95);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = '●';
            this.tbSenha.Size = new System.Drawing.Size(309, 26);
            this.tbSenha.TabIndex = 4;
            this.tbSenha.TextChanged += new System.EventHandler(this.tbSenha_TextChanged);
            // 
            // cbModoEditor
            // 
            this.cbModoEditor.AutoSize = true;
            this.cbModoEditor.BackColor = System.Drawing.Color.Transparent;
            this.cbModoEditor.Font = new System.Drawing.Font("Microsoft YaHei", 10.25F);
            this.cbModoEditor.ForeColor = System.Drawing.Color.White;
            this.cbModoEditor.Location = new System.Drawing.Point(102, 127);
            this.cbModoEditor.Name = "cbModoEditor";
            this.cbModoEditor.Size = new System.Drawing.Size(113, 24);
            this.cbModoEditor.TabIndex = 5;
            this.cbModoEditor.Text = "Modo editor";
            this.cbModoEditor.UseVisualStyleBackColor = false;
            this.cbModoEditor.CheckedChanged += new System.EventHandler(this.cbModoEditor_CheckedChanged);
            // 
            // cbMostrarSenha
            // 
            this.cbMostrarSenha.AutoSize = true;
            this.cbMostrarSenha.BackColor = System.Drawing.Color.Transparent;
            this.cbMostrarSenha.Font = new System.Drawing.Font("Microsoft YaHei", 10.25F);
            this.cbMostrarSenha.ForeColor = System.Drawing.Color.White;
            this.cbMostrarSenha.Location = new System.Drawing.Point(287, 127);
            this.cbMostrarSenha.Name = "cbMostrarSenha";
            this.cbMostrarSenha.Size = new System.Drawing.Size(124, 24);
            this.cbMostrarSenha.TabIndex = 6;
            this.cbMostrarSenha.Text = "Mostrar senha";
            this.cbMostrarSenha.UseVisualStyleBackColor = false;
            this.cbMostrarSenha.CheckedChanged += new System.EventHandler(this.cbMostrarSenha_CheckedChanged);
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.SystemColors.Window;
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.btSair.Location = new System.Drawing.Point(12, 157);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(75, 23);
            this.btSair.TabIndex = 7;
            this.btSair.Text = "Sair";
            this.btSair.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.SystemColors.Window;
            this.btLogin.FlatAppearance.BorderSize = 0;
            this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogin.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.btLogin.Location = new System.Drawing.Point(336, 157);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(75, 23);
            this.btLogin.TabIndex = 8;
            this.btLogin.Text = "Login";
            this.btLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Visible = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.button1.Location = new System.Drawing.Point(12, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cadastro";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImage = global::BuscadoDesktop.Properties.Resources.photo_1588421357574_87938a86fa28;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(428, 195);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.cbMostrarSenha);
            this.Controls.Add(this.cbModoEditor);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.CheckBox cbModoEditor;
        private System.Windows.Forms.CheckBox cbMostrarSenha;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button button1;
    }
}

