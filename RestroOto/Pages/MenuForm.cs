using RestroOto.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestroOto.Helper;

namespace RestroOto
{
    public partial class MenuForm : Form
    {
        private List<Product> productList = new List<Product>();

        //Label Config
        private List<Label> viweLabelName = new List<Label>();
        private List<Label> viweLabelPrice = new List<Label>();

        //Textbox Config
        private List<TextBox> viewTextBoxPiece = new List<TextBox>();
        private List<TextBox> viewTextBoxPrice = new List<TextBox>();
        private RemoteCustomer RefCustomers;
        public MenuForm()
        {
            InitializeComponent();
            setLabelConfig();
            setTextConfig();
            SoapCrealiziation();
        }

        public MenuForm(RemoteCustomer rCustomer)
        {
            InitializeComponent();
            setLabelConfig();
            setTextConfig();
            SoapCrealiziation();
            RefCustomers = rCustomer;
            MessageBox.Show(RefCustomers.UserName);
        }

        #region ButtonClickEvents
        #region Default Button       
        private void button1_Click(object sender, EventArgs e)
        {
            SoapCrealiziation();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PastyCrealiziation();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DessertCrealiziation();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DrinkCrealiziation();
        }
        #endregion
        #region Artırma ve Azaltma
        private void Increase(object sender, EventArgs e)
        {
            Button ButtonValue = sender as Button;
            label13.Text = ButtonValue.Name;
            switch (ButtonValue.Name)
            {
                case "button5":
                    viewTextBoxPiece[0].Text += 10;
                    break;
                case "button6":
                    viewTextBoxPiece[1].Text += 12;
                    break;
                case "button7":
                    viewTextBoxPiece[2].Text += 15;
                    break;
                case "button8":
                    viewTextBoxPiece[3].Text += 13;
                    break;
                case "button9":
                    viewTextBoxPiece[4].Text += 10;
                    break;
                case "button10":
                    viewTextBoxPiece[5].Text += 15;
                    break;
            }
        }

        private void Decrease(object sender, EventArgs e, string s)
        {
            Button ButtonValue = sender as Button;
            label13.Text = ButtonValue.Name;
            switch (ButtonValue.Name)
            {
                case "button5":
                    viewTextBoxPiece[6].Text += 10;
                    break;
                case "button6":
                    viewTextBoxPiece[7].Text += 12;
                    break;
                case "button7":
                    viewTextBoxPiece[8].Text += 15;
                    break;
                case "button8":
                    viewTextBoxPiece[9].Text += 13;
                    break;
                case "button9":
                    viewTextBoxPiece[10].Text += 10;
                    break;
                case "button10":
                    viewTextBoxPiece[11].Text += 15;
                    break;
            }
        }

        #endregion

        #endregion

        #region Serialized
        private void SoapCrealiziation()
        {
            DumyDateSerialized("Soap");

            Soap soap = new Soap();
            soap.MenuName = "Çorba";

            for (int i = 0; i < productList.Count; i++)
            {
                soap.Adding(productList[i]);
            }

            label13.Text = soap.MenuName;

            for (int i = 0; i < soap.SoapProductList.Count; i++)
            {
                viweLabelName[i].Text = soap.SoapProductList[i].Name;
                viweLabelPrice[i].Text = soap.SoapProductList[i].Price.ToString();
            }
        }

        private void PastyCrealiziation()
        {
            DumyDateSerialized("Pasty");

            Pasty pasty = new Pasty();
            pasty.MenuName = "Mantı";

            for (int i = 0; i < productList.Count; i++)
            {
                pasty.Adding(productList[i]);
            }

            label13.Text = pasty.MenuName;

            for (int i = 0; i < pasty.PastyProductList.Count; i++)
            {
                viweLabelName[i].Text = pasty.PastyProductList[i].Name;
                viweLabelPrice[i].Text = pasty.PastyProductList[i].Price.ToString();
            }
        }

        private void DessertCrealiziation()
        {
            DumyDateSerialized("Dessert");

            Dessert dessert = new Dessert();
            dessert.MenuName = "Tatlı";

            for (int i = 0; i < productList.Count; i++)
            {
                dessert.Adding(productList[i]);
            }

            label13.Text = dessert.MenuName;

            for (int i = 0; i < dessert.DessertProductList.Count; i++)
            {
                viweLabelName[i].Text = dessert.DessertProductList[i].Name;
                viweLabelPrice[i].Text = dessert.DessertProductList[i].Price.ToString();
            }

        }

        private void DrinkCrealiziation()
        {
            DumyDateSerialized("Drink");

            Drink drink = new Drink();
            drink.MenuName = "İçecekler";

            for (int i = 0; i < productList.Count; i++)
            {
                drink.Adding(productList[i]);
            }
            label13.Text = drink.MenuName;

            for (int i = 0; i < drink.DrinkProductList.Count; i++)
            {
                viweLabelName[i].Text = drink.DrinkProductList[i].Name;
                viweLabelPrice[i].Text = drink.DrinkProductList[i].Price.ToString();
            }

        }
        #endregion

        #region Helper

        private void setTextConfig()
        {
            viewTextBoxPiece.Add(textBox1);
            viewTextBoxPiece.Add(textBox2);
            viewTextBoxPiece.Add(textBox3);
            viewTextBoxPiece.Add(textBox4);
            viewTextBoxPiece.Add(textBox5);
            viewTextBoxPiece.Add(textBox6);

            viewTextBoxPrice.Add(textBox7);
            viewTextBoxPrice.Add(textBox8);
            viewTextBoxPrice.Add(textBox9);
            viewTextBoxPrice.Add(textBox10);
            viewTextBoxPrice.Add(textBox11);
            viewTextBoxPrice.Add(textBox12);
        }


        private void setLabelConfig()
        {
            viweLabelName.Add(label1);
            viweLabelName.Add(label2);
            viweLabelName.Add(label3);
            viweLabelName.Add(label4);
            viweLabelName.Add(label5);
            viweLabelName.Add(label6);

            viweLabelPrice.Add(label7);
            viweLabelPrice.Add(label8);
            viweLabelPrice.Add(label9);
            viweLabelPrice.Add(label10);
            viweLabelPrice.Add(label11);
            viweLabelPrice.Add(label12);
        }

        private void DumyDateSerialized(string typeValue)
        {
            switch (typeValue)
            {
                case "Soap":
                    productList.Clear();
                    productList.Add(new Product { Name = "Ezogelin Çorbası", Price = 10 });
                    productList.Add(new Product { Name = "Mercimek Çorbası", Price = 10 });
                    productList.Add(new Product { Name = "Yayla Çorbası", Price = 10 });
                    productList.Add(new Product { Name = "Tarhane Çorbası", Price = 10 });
                    productList.Add(new Product { Name = "Mantı Çorbası", Price = 10 });
                    productList.Add(new Product { Name = "Tavuk Çorbası", Price = 10 });
                    break;
                case "Drink":
                    productList.Clear();
                    productList.Add(new Product { Name = "Ayran", Price = 10 });
                    productList.Add(new Product { Name = "Kahve", Price = 10 });
                    productList.Add(new Product { Name = "Soda", Price = 10 });
                    productList.Add(new Product { Name = "Su", Price = 10 });
                    productList.Add(new Product { Name = "Kola", Price = 10 });
                    productList.Add(new Product { Name = "Limonata", Price = 10 });
                    break;
                case "Desert":
                    productList.Clear();
                    productList.Add(new Product { Name = "Hoşmerim", Price = 10 });
                    productList.Add(new Product { Name = "Sutlaç", Price = 10 });
                    productList.Add(new Product { Name = "Kunefe", Price = 10 });
                    productList.Add(new Product { Name = "Baklava", Price = 10 });
                    productList.Add(new Product { Name = "Kek", Price = 10 });
                    productList.Add(new Product { Name = "ŞekerPare", Price = 10 });
                    break;
                case "Pasty":
                    productList.Clear();
                    productList.Add(new Product { Name = "Özbek Mantısı", Price = 10 });
                    productList.Add(new Product { Name = "Karışık Mantı", Price = 10 });
                    productList.Add(new Product { Name = "Çıtır Mantı", Price = 10 });
                    productList.Add(new Product { Name = "Malatya Mantısı", Price = 10 });
                    productList.Add(new Product { Name = "Yoğutlu Mantı", Price = 10 });
                    productList.Add(new Product { Name = "Sade Mantı", Price = 10 });
                    break;
            }
        }
        #endregion

        #region HelperClickButtons         
        private void button19_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Tables tables = new Tables();
            tables.ShowDialog();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            CashTransaction cash = new CashTransaction();
            cash.ShowDialog();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Takeaway takeaway = new Takeaway();
            takeaway.ShowDialog();
        }
        #endregion
    }
}
