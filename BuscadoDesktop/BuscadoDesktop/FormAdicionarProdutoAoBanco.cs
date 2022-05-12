using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuscadoDesktop
{
    public partial class FormAdicionarProdutoAoBanco : Form
    {
        int id;
        public FormAdicionarProdutoAoBanco(string codigo, int ID)
        {

            InitializeComponent();
            tbCodigo.Text = codigo;
            id = ID;
        }


        private void btConfirmar_Click(object sender, EventArgs e)
        {
            using (var context = new BuscadoEntities())
            {
                //mudar o idempresa posteriormente
                Produto produto = new Produto();
                produto.Nome = tbNome.Text;
                produto.CodigoDeBarras = tbCodigo.Text;
                produto.Imagem = tbLink.Text;
                produto.idEmpresa = 1; //temporario
                context.Produto.Add(produto);
                context.SaveChanges();
                
            }
            MessageBox.Show("Produto adicionado com sucesso!", "Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FormModoEditor formModoEditor = new FormModoEditor(id);
            Hide();
            formModoEditor.ShowDialog();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            FormModoEditor formModoEditor = new FormModoEditor(id);
            Hide();
            formModoEditor.ShowDialog();
        }

        private void tbLink_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
