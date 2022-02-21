using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracaoDIO.Entities
{
    abstract class Personagem
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Serie { get; set; }
        public string Description { get; set; }

        public Personagem()
        {

        }

        public Personagem(string name, int age, string serie, string description)
        {
            Name = name;
            Age = age;
            Serie = serie;
            Description = description;
        }

        public override string ToString()
        {
            return $@"
                    Nome: {Name}
                    Idade: {Age}
                    Série: {Serie}
                    Descrição: {Description}                      
            ";
        }
    }
}
