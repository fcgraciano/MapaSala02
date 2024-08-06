using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entitidades
{
    public class ProfessoresEntidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }

        public object[] Linha()
        {
            return new object[] { Id, Nome, Apelido };
        }
    }
}
