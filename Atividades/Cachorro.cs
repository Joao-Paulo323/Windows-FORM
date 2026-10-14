using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PETSHOP
{
    public class Cachorro : Animal
    {
        public Cachorro( string nome, int idade): base(nome, idade){ }
    public override string FazerSom() => "AU AU";
    }
}
