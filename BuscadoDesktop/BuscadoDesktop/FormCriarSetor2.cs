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
    public partial class FormCriarSetor2 : Form
    {
        int idMercado;
        
        public FormCriarSetor2(int idMercado)
        {
            InitializeComponent();
            this.idMercado = idMercado;
            
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
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

            this.Close();
        }
    }
}
