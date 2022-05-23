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
    public partial class FormEditarOferta : Form
    {
        int idmercado;
        public FormEditarOferta(string descricao, int idmercado)
        {
            InitializeComponent();
            using (var context = new BuscadoEntities())
            {
                var query = from Oferta in context.Oferta
                            join Mercado_has_Produto in context.Mercado_has_Produto on Oferta.idMercado_has_Produto equals Mercado_has_Produto.idMercado_has_Produto
                            join Produto in context.Produto on Mercado_has_Produto.idProduto equals Produto.idProduto
                            where Oferta.Descricao == descricao
                            select Produto.Imagem;
                var query2 = from Oferta in context.Oferta
                            join Mercado_has_Produto in context.Mercado_has_Produto on Oferta.idMercado_has_Produto equals Mercado_has_Produto.idMercado_has_Produto
                            join Produto in context.Produto on Mercado_has_Produto.idProduto equals Produto.idProduto
                            where Oferta.Descricao == descricao
                            select Produto.CodigoDeBarras;
                
                this.idmercado = idmercado;
                pictureBox2.ImageLocation = query.FirstOrDefault();
                tbCodigodeBarras.Text = query2.FirstOrDefault();
                tbCodigodeBarras.Enabled = false;
            }
        }

        private void btCriar_Click(object sender, EventArgs e)
        {
            using (var context = new BuscadoEntities())
            {
                if (String.IsNullOrEmpty(tbDescricao.Text))
                {
                    MessageBox.Show("Adicione uma descrição.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var query = from Oferta in context.Oferta
                                join Mercado_has_Produto in context.Mercado_has_Produto on Oferta.idMercado_has_Produto equals Mercado_has_Produto.idMercado_has_Produto
                                join Produto in context.Produto on Mercado_has_Produto.idProduto equals Produto.idProduto
                                where Produto.CodigoDeBarras == tbCodigodeBarras.Text
                                select Oferta.idOferta;

                    Oferta o = new Oferta() { idOferta = query.FirstOrDefault() };
                    context.Oferta.Attach(o);
                    o.Descricao = tbDescricao.Text;
                    context.SaveChanges();
                    MessageBox.Show("Oferta editada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    using (var tela = new FormModoEditor(idmercado))
                    {
                        this.Hide();
                        tela.ShowDialog();
                    }
                }

            }
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            using (var tela = new FormModoEditor(idmercado))
            {
                this.Hide();
                tela.ShowDialog();
            }

        }
    }
}
