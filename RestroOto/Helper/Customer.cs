using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestroOto.Helper
{
    public abstract class Customer
    {
        private string _customerName;
        private string _customerSurname;
        private string _userName;
        private string _userPassword;
        private string _userRole;
        private string _phone;
        private string _adreess;

        public string CustomerName
        {
            get { return _customerName; }
            set { _customerName = value; }
        }

        public string CustomerSurname
        {
            get { return _customerSurname; }
            set { _customerSurname = value; }
        }

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        public string UserPassword
        {
            get { return _userPassword; }
            set { _userPassword = value; }
        }

        public string UserRoler
        {
            get { return _userRole; }
            set { _userRole = value; }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public string Adreess
        {
            get { return _adreess; }
            set { _adreess = value; }
        }
    }

    public class RemoteCustomer : Customer
    {

    }

    public class NearCustomer : Customer
    {

    }
}
