using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracaoDIO.Entities
{
    internal class Ted : Personagem
    {
        public Ted(string name, int age, string serie, string description)
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
