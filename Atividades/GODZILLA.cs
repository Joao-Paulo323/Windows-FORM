using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PETSHOP
{
    public class GODZILLA : Animal
    {
        public GODZILLA(string nome, int idade) : base(nome, idade) { }
        public override string FazerSom() => "Meteoro de desgraçaaaaaaaa";
    }
}
