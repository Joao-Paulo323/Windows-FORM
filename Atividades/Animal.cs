using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PETSHOP
{
    public abstract class Animal
    {
        public string Nome { get; private set; }
        public int Idade { get; private set; }

        protected Animal(string nome, int idade)
        {
            if (string.IsNullOrEmpty(nome)) {
                throw new ArgumentNullException("O nome e Obrigatorio");

            }
            if (idade < 0 || idade > 100)
            {
                throw new ArgumentException("Idade Invalida Digite uma idade valida");
            }
            Nome = nome;
            Idade = idade;
        }
        public abstract string FazerSom();
        public void Comer() => Console.WriteLine(Nome + " esta comendo");
        public override string ToString() => $"{Nome} ({Idade} anos) - {GetType().Name}";
        
            
        }
    }

