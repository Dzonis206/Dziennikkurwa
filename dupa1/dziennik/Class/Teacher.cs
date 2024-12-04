using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dziennik.Class
{
    public class Teacher
    {
        internal readonly object punkty;
        internal readonly object oceny;

        public string imie {  get; set; }
        public string nazwisko {  get; set; }
        public int PESEL {  get; set; }
        public string password {  get; set; }
        public string sala {  get; set; }

        public Teacher() { }
    }
}
