using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace наследованиеКлассов
{
    public class Мегаполис : Город
    {
        public string Skyscrapers;

        public Мегаполис(string Skyscrapers, string name, string population, string mayor) : base (name, population, mayor)
        {
            this.Skyscrapers = Skyscrapers;
        }
        public override string Info()
        {
            return $"Название мегаполиса: {name}, население: {population}, количество небоскрёбов: {Skyscrapers}";
        }
    }
}
