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
    public partial class FormCriarSetor : Form
    {
        int idMercado;
        int idProduto;
        string nome;
        string codigo;
        public FormCriarSetor(int idMercado, int idProduto, string nome, string codigo)
        {
            InitializeComponent();
            this.idMercado = idMercado;
            this.idProduto = idProduto;
            this.nome = nome;
            this.codigo = codigo;
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            FormAdicionarProduto fap = new FormAdicionarProduto(idMercado, idProduto, nome, codigo);
            Hide();
            fap.ShowDialog();
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            using (var context = new BuscadoEntities())
            {
                Setor s = new Setor();
                s.Nome = tbSetor.Text;
                s.idMercado = idMercado;
                context.Setor.Add(s);
                context.SaveChanges();
            }
            MessageBox.Show("Setor Adicionado Com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FormAdicionarProduto fap = new FormAdicionarProduto(idMercado, idProduto, nome, codigo);
            Hide();
            fap.ShowDialog();
        }
    }
}
