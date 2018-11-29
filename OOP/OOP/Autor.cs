using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Autor
    {
        private string surname;
        private string name;
        private string secondname;
        private string phone;
        string address;

        public override int GetHashCode()
        {
            return name.GetHashCode() + surname.GetHashCode() + secondname.GetHashCode();
        }
    }
}
