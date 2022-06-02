namespace BuscadoDesktop
{
    partial class FormModoEditor
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbAdicionarProduto = new System.Windows.Forms.TextBox();
            this.btAdicionarProduto = new System.Windows.Forms.Button();
            this.btEditarProduto = new System.Windows.Forms.Button();
            this.comboBoxOferta = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btEditarOferta = new System.Windows.Forms.Button();
            this.btCriarOferta = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btCadastrarAdm = new System.Windows.Forms.Button();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbConfirmarSenha = new System.Windows.Forms.TextBox();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.cbModoTouchscreen = new System.Windows.Forms.CheckBox();
            this.labelMercado = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(209, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modo Editor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código de barras";
            // 
            // tbAdicionarProduto
            // 
            this.tbAdicionarProduto.BackColor = System.Drawing.Color.White;
            this.tbAdicionarProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAdicionarProduto.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F);
            this.tbAdicionarProduto.Location = new System.Drawing.Point(6, 32);
            this.tbAdicionarProduto.Name = "tbAdicionarProduto";
            this.tbAdicionarProduto.Size = new System.Drawing.Size(279, 33);
            this.tbAdicionarProduto.TabIndex = 2;
            this.tbAdicionarProduto.Click += new System.EventHandler(this.labelMercado_Click);
            this.tbAdicionarProduto.TextChanged += new System.EventHandler(this.tbAdicionarProduto_TextChanged);
            // 
            // btAdicionarProduto
            // 
            this.btAdicionarProduto.BackColor = System.Drawing.Color.White;
            this.btAdicionarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdicionarProduto.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.btAdicionarProduto.Location = new System.Drawing.Point(6, 71);
            this.btAdicionarProduto.Name = "btAdicionarProduto";
            this.btAdicionarProduto.Size = new System.Drawing.Size(89, 26);
            this.btAdicionarProduto.TabIndex = 3;
            this.btAdicionarProduto.Text = "Adicionar";
            this.btAdicionarProduto.UseVisualStyleBackColor = false;
            this.btAdicionarProduto.Click += new System.EventHandler(this.btAdicionarProduto_Click);
            // 
            // btEditarProduto
            // 
            this.btEditarProduto.BackColor = System.Drawing.Color.White;
            this.btEditarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditarProduto.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.btEditarProduto.Location = new System.Drawing.Point(101, 71);
            this.btEditarProduto.Name = "btEditarProduto";
            this.btEditarProduto.Size = new System.Drawing.Size(89, 26);
            this.btEditarProduto.TabIndex = 6;
            this.btEditarProduto.Text = "Editar";
            this.btEditarProduto.UseVisualStyleBackColor = false;
            // 
            // comboBoxOferta
            // 
            this.comboBoxOferta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxOferta.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F);
            this.comboBoxOferta.FormattingEnabled = true;
            this.comboBoxOferta.Location = new System.Drawing.Point(19, 256);
            this.comboBoxOferta.Name = "comboBoxOferta";
            this.comboBoxOferta.Size = new System.Drawing.Size(212, 33);
            this.comboBoxOferta.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 14F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ofertas";
            // 
            // btEditarOferta
            // 
            this.btEditarOferta.BackColor = System.Drawing.Color.White;
            this.btEditarOferta.FlatAppearance.BorderSize = 0;
            this.btEditarOferta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditarOferta.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.btEditarOferta.Location = new System.Drawing.Point(19, 295);
            this.btEditarOferta.Name = "btEditarOferta";
            this.btEditarOferta.Size = new System.Drawing.Size(101, 26);
            this.btEditarOferta.TabIndex = 9;
            this.btEditarOferta.Text = "Editar";
            this.btEditarOferta.UseVisualStyleBackColor = false;
            this.btEditarOferta.Click += new System.EventHandler(this.btEditarOferta_Click);
            // 
            // btCriarOferta
            // 
            this.btCriarOferta.BackColor = System.Drawing.Color.White;
            this.btCriarOferta.FlatAppearance.BorderSize = 0;
            this.btCriarOferta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCriarOferta.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.btCriarOferta.Location = new System.Drawing.Point(237, 256);
            this.btCriarOferta.Name = "btCriarOferta";
            this.btCriarOferta.Size = new System.Drawing.Size(82, 33);
            this.btCriarOferta.TabIndex = 10;
            this.btCriarOferta.Text = "Criar Oferta";
            this.btCriarOferta.UseVisualStyleBackColor = false;
            this.btCriarOferta.Click += new System.EventHandler(this.btCriarOferta_Click);
            // 
            // btCadastrarAdm
            // 
            this.btCadastrarAdm.BackColor = System.Drawing.Color.White;
            this.btCadastrarAdm.FlatAppearance.BorderSize = 0;
            this.btCadastrarAdm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrarAdm.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.btCadastrarAdm.Location = new System.Drawing.Point(19, 174);
            this.btCadastrarAdm.Name = "btCadastrarAdm";
            this.btCadastrarAdm.Size = new System.Drawing.Size(101, 26);
            this.btCadastrarAdm.TabIndex = 12;
            this.btCadastrarAdm.Text = "Cadastrar";
            this.btCadastrarAdm.UseVisualStyleBackColor = false;
            this.btCadastrarAdm.Click += new System.EventHandler(this.btCadastrarAdm_Click);
            // 
            // tbSenha
            // 
            this.tbSenha.BackColor = System.Drawing.Color.White;
            this.tbSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSenha.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F);
            this.tbSenha.Location = new System.Drawing.Point(19, 110);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Size = new System.Drawing.Size(212, 26);
            this.tbSenha.TabIndex = 11;
            // 
            // tbUsuario
            // 
            this.tbUsuario.BackColor = System.Drawing.Color.White;
            this.tbUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F);
            this.tbUsuario.Location = new System.Drawing.Point(19, 78);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(212, 26);
            this.tbUsuario.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 14F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cadastrar Administrador";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 14F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(237, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Senha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 14F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(237, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Usuário";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 14F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(237, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "C. Senha";
            // 
            // tbConfirmarSenha
            // 
            this.tbConfirmarSenha.BackColor = System.Drawing.Color.White;
            this.tbConfirmarSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbConfirmarSenha.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F);
            this.tbConfirmarSenha.Location = new System.Drawing.Point(19, 142);
            this.tbConfirmarSenha.Name = "tbConfirmarSenha";
            this.tbConfirmarSenha.Size = new System.Drawing.Size(212, 26);
            this.tbConfirmarSenha.TabIndex = 19;
            this.tbConfirmarSenha.TextChanged += new System.EventHandler(this.tbConfirmarSenha_TextChanged);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // cbModoTouchscreen
            // 
            this.cbModoTouchscreen.AutoSize = true;
            this.cbModoTouchscreen.BackColor = System.Drawing.Color.Transparent;
            this.cbModoTouchscreen.Font = new System.Drawing.Font("Microsoft YaHei", 10.25F);
            this.cbModoTouchscreen.ForeColor = System.Drawing.Color.White;
            this.cbModoTouchscreen.Location = new System.Drawing.Point(19, 202);
            this.cbModoTouchscreen.Name = "cbModoTouchscreen";
            this.cbModoTouchscreen.Size = new System.Drawing.Size(255, 24);
            this.cbModoTouchscreen.TabIndex = 20;
            this.cbModoTouchscreen.Text = "Modo touchscreen - em progesso";
            this.cbModoTouchscreen.UseVisualStyleBackColor = false;
            // 
            // labelMercado
            // 
            this.labelMercado.AutoSize = true;
            this.labelMercado.BackColor = System.Drawing.Color.Transparent;
            this.labelMercado.Font = new System.Drawing.Font("Microsoft YaHei", 14F);
            this.labelMercado.ForeColor = System.Drawing.Color.White;
            this.labelMercado.Location = new System.Drawing.Point(61, 560);
            this.labelMercado.Name = "labelMercado";
            this.labelMercado.Size = new System.Drawing.Size(82, 25);
            this.labelMercado.TabIndex = 21;
            this.labelMercado.Text = "Usuário";
            this.labelMercado.Click += new System.EventHandler(this.labelMercado_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbAdicionarProduto);
            this.groupBox1.Controls.Add(this.btAdicionarProduto);
            this.groupBox1.Controls.Add(this.btEditarProduto);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.1F);
            this.groupBox1.Location = new System.Drawing.Point(13, 448);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 105);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.button2.Location = new System.Drawing.Point(196, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 26);
            this.button2.TabIndex = 7;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Produtos";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.button1.Location = new System.Drawing.Point(13, 559);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 26);
            this.button1.TabIndex = 24;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.button3.Location = new System.Drawing.Point(126, 295);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 26);
            this.button3.TabIndex = 25;
            this.button3.Text = "Excluir";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.button4.Location = new System.Drawing.Point(126, 174);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 26);
            this.button4.TabIndex = 26;
            this.button4.Text = "Excluir";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.button5.Location = new System.Drawing.Point(126, 391);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(105, 26);
            this.button5.TabIndex = 31;
            this.button5.Text = "Excluir";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.button6.Location = new System.Drawing.Point(237, 352);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(82, 33);
            this.button6.TabIndex = 30;
            this.button6.Text = "Criar Setor";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.button7.Location = new System.Drawing.Point(19, 391);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(101, 26);
            this.button7.TabIndex = 29;
            this.button7.Text = "Editar";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 14F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(14, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 25);
            this.label9.TabIndex = 28;
            this.label9.Text = "Setores";
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(19, 352);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 33);
            this.comboBox1.TabIndex = 27;
            // 
            // FormModoEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BuscadoDesktop.Properties.Resources.photo_1588421357574_87938a86fa28;
            this.ClientSize = new System.Drawing.Size(338, 600);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelMercado);
            this.Controls.Add(this.cbModoTouchscreen);
            this.Controls.Add(this.tbConfirmarSenha);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.btCadastrarAdm);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.btCriarOferta);
            this.Controls.Add(this.btEditarOferta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxOferta);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormModoEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscado - modo editor ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAdicionarProduto;
        private System.Windows.Forms.Button btAdicionarProduto;
        private System.Windows.Forms.Button btEditarProduto;
        private System.Windows.Forms.ComboBox comboBoxOferta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btEditarOferta;
        private System.Windows.Forms.Button btCriarOferta;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btCadastrarAdm;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbConfirmarSenha;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.CheckBox cbModoTouchscreen;
        private System.Windows.Forms.Label labelMercado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}