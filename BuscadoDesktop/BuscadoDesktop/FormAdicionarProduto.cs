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
    public partial class FormAdicionarProduto : Form
    {
        int idMercado;
        int idProduto;
        string nome;
        string codigo;
        string ImagemURL;
        public FormAdicionarProduto(int idMercado, int idProduto, string nome, string codigoDeBarras)
        {
            
            InitializeComponent();
            label2.Text = "Nome: " + nome;
            label3.Text = "Codigo: " + codigoDeBarras;
            this.idMercado = idMercado;
            this.idProduto = idProduto;
            this.nome = nome;
            codigo = codigoDeBarras;

            //coloca a imagem do produto na image box
            using (var context = new BuscadoEntities())
            {
                var query = from Produto in context.Produto
                            where Produto.idProduto == idProduto
                            select Produto.Imagem;
                ImagemURL = query.First();


                var query2 = from Setor in context.Setor
                             where Setor.idMercado == idMercado
                             select Setor.Nome;
                BindingSource bs = new BindingSource();
                bs.DataSource = query2.ToList();
                comboSetor.DataSource = bs;
            }
            
            pictureBox1.ImageLocation = ImagemURL;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormModoEditor fme = new FormModoEditor(idMercado);
            Hide();
            fme.ShowDialog();
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            using (var context = new BuscadoEntities())
            {
                Mercado_has_Produto mhp = new Mercado_has_Produto();
                mhp.idMercado = idMercado;
                mhp.idProduto = idProduto;
                mhp.Preco = decimal.Parse(tbPreco.Text);
                mhp.Corredor = tbtbCorredor.Text;
                context.Mercado_has_Produto.Add(mhp);
                context.SaveChanges();

                var query = from Setor in context.Setor
                            where Setor.Nome == comboSetor.Text
                            select Setor.idSetor;

                Mercado_has_Produto_has_Setor mhphs = new Mercado_has_Produto_has_Setor();
                mhphs.idMercado_has_Produto = mhp.idMercado_has_Produto;
                mhphs.idSetor = query.FirstOrDefault();

                
                context.Mercado_has_Produto_has_Setor.Add(mhphs);
                context.SaveChanges();
            }
            MessageBox.Show("Produto Adicionado Com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FormModoEditor cs = new FormModoEditor(idMercado);
            Hide();
            cs.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormCriarSetor cs = new FormCriarSetor(idMercado, idProduto, nome, codigo);
            Close();
            cs.ShowDialog();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
