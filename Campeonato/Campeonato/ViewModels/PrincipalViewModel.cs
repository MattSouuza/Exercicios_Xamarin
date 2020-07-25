using Campeonato.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Campeonato.ViewModels
{
    public class PrincipalViewModel
    {
        public List<Jogos> Jogos { get; set; }

        public PrincipalViewModel()
        {
            Jogos = new List<Jogos>
            {
                new Jogos
                {
                    Id = 1,
                    PlacarCasa = 3,
                    PlacarVisitante = 4,
                    PenaltisCasa = 0,
                    PenaltisVisitante = 0,
                    Estadio = "Mineirão",
                    Data = DateTime.Now,
                    SelecaoCasa = 1,
                    SelecaoVisitante = 2,
                },

                new Jogos
                {
                    Id = 2,
                    PlacarCasa = 6,
                    PlacarVisitante = 1,
                    PenaltisCasa = 0,
                    PenaltisVisitante = 0,
                    Estadio = "Mineirão",
                    Data  = DateTime.Now,
                    SelecaoCasa = 1,
                    SelecaoVisitante = 2
                }
            };
        }
    }
}
