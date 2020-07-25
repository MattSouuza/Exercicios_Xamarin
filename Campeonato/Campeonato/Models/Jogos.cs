using System;
using System.Collections.Generic;
using System.Text;

namespace Campeonato.Models
{
    public class Jogos
    {
        public int Id { get; set; }
        public int SelecaoCasa { get; set; }
        public int SelecaoVisitante { get; set; }
        public int PlacarCasa { get; set; }
        public int PlacarVisitante { get; set; }
        public int PenaltisCasa { get; set; }
        public int PenaltisVisitante { get; set; }
        public DateTime Data { get; set; }
        public string Estadio { get; set; }

        public string DataFormatada
        {
            get
            {
                return Data.ToString("dd/MM/yyyy");
            }
        }

        public override string ToString()
        {
            return $"{SelecaoCasa} {PlacarCasa} X {SelecaoVisitante} {PlacarVisitante}";
        }
    }
}
