using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestroOto
{
    public partial class CashTransaction : Form
    {
        public CashTransaction()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Stage stage = new Stage();
            stage.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Siparişiniz Oluşturulmuştur.");
        }
    }
}
