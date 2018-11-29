using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Publisher
    {
        private enum booktype { proza, rasskaz, poezia }
        private Publishing publishing;
        private booktype type;
        private string name;
        private int cost;
        private int year;
        private string addres;
        private Autor autor;

        public Publisher()
        {

        }
    }
}
