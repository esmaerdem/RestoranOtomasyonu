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
    public partial class Main : Form
    {
        private List<RemoteCustomer> remoteCustomerList = new List<RemoteCustomer>();
        private List<NearCustomer> nearCustomerList = new List<NearCustomer>();

        public Main()
        {
            InitializeComponent();
            CustomerDataSerialized("RemoteCustomers");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "Yonetim" && textBox2.Text == "12345")
            {
                // Show (yonetim)
                Stage stage = new Stage();
                stage.ShowDialog();
            }
            else
            {
                RemoteCustomer result = remoteCustomerList.Single(c => c.UserName == textBox1.Text && c.UserPassword == textBox2.Text);
                if (result != null)
                {
                    if (result.UserRoler == "Remote")
                    {
                        //Bu adam Kafede'dir ve Kafeden Sipiriş vericektir
                        MenuForm menu = new MenuForm(result);
                        menu.ShowDialog();
                    }
                    else if (result.UserRoler == "Near")
                    {
                        Takeaway takeaway = new Takeaway();
                        takeaway.ShowDialog();
                    }
                    else
                    {
                        //Şifreniz Yanlış
                        MessageBox.Show("ŞİFRENİZ YANLIŞTIR");
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı Bulunamadı");
                }
            }
        }

        #region DefaultButtons       
        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }
        #endregion

        #region Helper
        private void CustomerDataSerialized(string typeValue)
        {
            switch (typeValue)
            {
                case "RemoteCustomers":
                    remoteCustomerList.Add(new RemoteCustomer
                    {
                        CustomerName = "Berfe",
                        CustomerSurname = "Aleyna",
                        UserName = "Berfe",
                        UserPassword = "12345",
                        UserRoler = "Remote",
                        Adreess = "Acıbadem",
                        Phone = "5909009090"
                    });

                    remoteCustomerList.Add(new RemoteCustomer
                    {
                        CustomerName = "Ceylan",
                        CustomerSurname = "Asena",
                        UserName = "Ceylan",
                        UserPassword = "12345",
                        UserRoler = "Remote",
                        Adreess = "Kadıkoy",
                        Phone = "5909009090"
                    });

                    remoteCustomerList.Add(new RemoteCustomer
                    {
                        CustomerName = "Hasan",
                        CustomerSurname = "Alakuş",
                        UserName = "Hasan",
                        UserPassword = "12345",
                        UserRoler = "Remote",
                        Adreess = "Mecidiyekoy",
                        Phone = "5909009090"
                    });
                    break;
                case "NearCustomers":
                    break;
            }
        }
        #endregion
    }
}
