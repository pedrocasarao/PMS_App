using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PMS_App.Models
{
    public class Usuario
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public decimal QtdHorasNominais { get; set; }
        public decimal QtdHorasDisponiveis { get; set; }

    }
}