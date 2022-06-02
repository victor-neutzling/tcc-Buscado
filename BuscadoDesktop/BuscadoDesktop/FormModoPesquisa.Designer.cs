namespace BuscadoDesktop
{
    partial class FormModoPesquisa
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
            this.tbBusca = new System.Windows.Forms.TextBox();
            this.resultado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(850, 83);
            this.label1.TabIndex = 1;
            this.label1.Text = "Encontre aqui seu produto";
            // 
            // tbBusca
            // 
            this.tbBusca.BackColor = System.Drawing.Color.White;
            this.tbBusca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBusca.Font = new System.Drawing.Font("Microsoft YaHei", 48F);
            this.tbBusca.Location = new System.Drawing.Point(26, 95);
            this.tbBusca.Name = "tbBusca";
            this.tbBusca.Size = new System.Drawing.Size(836, 85);
            this.tbBusca.TabIndex = 14;
            this.tbBusca.TextChanged += new System.EventHandler(this.tbBusca_TextChanged);
            // 
            // resultado
            // 
            this.resultado.BackColor = System.Drawing.Color.White;
            this.resultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultado.Font = new System.Drawing.Font("Microsoft YaHei", 18.75F);
            this.resultado.FormattingEnabled = true;
            this.resultado.ItemHeight = 32;
            this.resultado.Location = new System.Drawing.Point(26, 186);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(836, 480);
            this.resultado.TabIndex = 15;
            // 
            // FormModoPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BuscadoDesktop.Properties.Resources.photo_1588421357574_87938a86fa28;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(889, 706);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.tbBusca);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormModoPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormModoPesquisa";
            this.Load += new System.EventHandler(this.FormModoPesquisa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBusca;
        private System.Windows.Forms.ListBox resultado;
    }
}