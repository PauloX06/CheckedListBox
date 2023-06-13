using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CarregarItens();
        }

        private void CarregarItens()
        {
            ck2.Items.Add("Pasta de dente");
            ck2.Items.Add("Fita Led");
            ck2.Items.Add("Hamburger");
            ck2.Items.Add("Pizza");
            ck2.Items.Add("Lasanha");
        }
        

        private void button2_Click_1(object sender, EventArgs e)
        {
            string itens = "";
            foreach (var item in ck2.CheckedItems)
            {
                 itens += item.ToString() + "\n";
            }

            MessageBox.Show("Itens selecionados:\n" + itens);
        }
    }
}
