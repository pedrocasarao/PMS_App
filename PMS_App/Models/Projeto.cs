using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PMS_App.Models
{
    public class Projeto
    {
        public int Id { get; set; }
        public int IdBR { get; set; }
        public int IdLinx { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int IdOcorrencia { get; set; }
        public DateTime InicioPrevisto { get; set; }
        public DateTime FimPrevisto { get; set; }
        public int IdUsuario { get; set; }
    }
}