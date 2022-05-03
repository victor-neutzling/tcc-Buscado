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
    public partial class FormModoEditor : Form
    {
        public static bool IsEmpty<T>(List<T> list)
        {
            if (list == null)
            {
                return true;
            }

            return !list.Any();
        }
        //idMercado - usar para distinguir qual mercado está logado
        int idMercado;
        public FormModoEditor(int id)
        {
            InitializeComponent();
            idMercado = id;
            using (var context = new BuscadoEntities())
            {
                var query = from Mercado in context.Mercado
                            where Mercado.idMercado == id
                            select Mercado.Nome;
                labelMercado.Text = query.FirstOrDefault();
            }
        }

        private void btAdicionarProduto_Click(object sender, EventArgs e)
        {
            List<int> q;
            using(var context = new BuscadoEntities())
            {
                var query = from Produto in context.Produto
                            where Produto.CodigoDeBarras == tbAdicionarProduto.Text
                            select Produto.idProduto;
                q = query.ToList();
            }
            if(IsEmpty(q))
            {
                DialogResult dialog = MessageBox.Show("Este produto Não existe No banco de produtos, Deseja Adicioná-lo\n\nAntes de adicionar o produto,  verifique se o código foi digitado corretamente.", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(dialog == DialogResult.Yes)
                {
                    //tela de adicionar produto no banco, nao no mercado
                    FormAdicionarProdutoAoBanco formAdicionarProdutoAoBanco = new FormAdicionarProdutoAoBanco(tbAdicionarProduto.Text, idMercado);
                    Hide();
                    formAdicionarProdutoAoBanco.ShowDialog();


                }
                else
                {
                    return;
                }
            }
            int id;
            string nome;
            using (var context = new BuscadoEntities())
            {
                var query = from Produto in context.Produto
                            where Produto.CodigoDeBarras == tbAdicionarProduto.Text
                            select Produto.idProduto;
                id = query.FirstOrDefault();
                var query2 = from Produto in context.Produto
                            where Produto.CodigoDeBarras == tbAdicionarProduto.Text
                            select Produto.Nome;
                nome = query2.FirstOrDefault();
            }
            FormAdicionarProduto fap = new FormAdicionarProduto(idMercado, id, nome, tbAdicionarProduto.Text);
            Hide();
                fap.ShowDialog();    
        }

        private void labelMercado_Click(object sender, EventArgs e)
        {

        }

        private void tbAdicionarProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbAdicionarProduto_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btEditarOferta_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja sair?", "sair", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                Hide();
                Form1 f = new Form1();
                f.ShowDialog();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (var context = new BuscadoEntities())
            {
                var query = from Administrador in context.Administrador
                            select Administrador.Nome;
                if(query.ToList().Count() == 1)
                {
                    MessageBox.Show("Não é possível excluir o único administrador cadastrado no sistema. Para excluir este administrador, adicione outro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    //nao sei se funciona -- testar depois.
                    DialogResult dr = MessageBox.Show("Tem certeza que deseja excluir este administrador?", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        var query2 = from Administrador in context.Administrador
                                     where Administrador.Nome == tbUsuario.Text
                                     select Administrador.id;

                        Administrador adm = new Administrador() {id = query2.FirstOrDefault() };
                        context.Administrador.Attach(adm);
                        context.Administrador.Remove(adm);
                        context.SaveChanges();
                    }
                }
            }
        }

        private void tbConfirmarSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
