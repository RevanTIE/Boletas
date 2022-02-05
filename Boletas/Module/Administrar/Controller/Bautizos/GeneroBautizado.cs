using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletas.Module.Administrar.Controller.Bautizos
{
    public class GeneroBautizado
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public GeneroBautizado(string name, int value)
        {
            Name = name;
            Value = value;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
