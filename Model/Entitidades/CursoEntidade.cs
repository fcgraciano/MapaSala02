using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entitidades
{
    public class CursoEntidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Turno { get; set; }
        public string Sigla { get; set; }
        public bool Ativo { get; set; }
    }
}
