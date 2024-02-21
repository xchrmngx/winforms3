using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace наследованиеКлассов
{
    public class Область : Место
    {
        public string area;
        public Область(string population, string name,string area) : base (name,population)
        {
            this.area = area;
        }   

        public override string Info()
        {
            return $"Название области:{name}, население: {population}, площадь: {area}";
        }
    }
}
