using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PMS_App.Models
{
    public class Ocorrencia
    {
       public int Id { get; set; }
       public int IdProjeto { get; set; }
       public DateTime DataHora { get; set; }
    }
}