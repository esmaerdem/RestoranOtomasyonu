using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestroOto.Helper
{
    public abstract class Menu
    {
        private string _menuName;

        public string MenuName
        {
            get { return _menuName + " Menusu"; }
            set { _menuName = value; }
        }

        public abstract void Adding(Product product);

        public virtual void Deleting(Product product)
        {
            //Tum Listeyi Temizle 
        }
    }


    public class Soap : Menu
    {
        public List<Product> SoapProductList = new List<Product>();

        public override void Adding(Product product)
        {
            SoapProductList.Add(product);
        }

        public override void Deleting(Product product)
        {
            SoapProductList.Clear();
        }
    }

    public class Pasty : Menu
    {
        public List<Product> PastyProductList = new List<Product>();

        public override void Adding(Product product)
        {
            PastyProductList.Add(product);
        }
    }

    public class Dessert : Menu
    {
        public List<Product> DessertProductList = new List<Product>();

        public override void Adding(Product product)
        {
            DessertProductList.Add(product);
        }
    }

    public class Drink : Menu
    {
        public List<Product> DrinkProductList = new List<Product>();

        public override void Adding(Product product)
        {
            DrinkProductList.Add(product);
        }
    }

    public class Product
    {
        public string Name;
        public int Price;
    }
}