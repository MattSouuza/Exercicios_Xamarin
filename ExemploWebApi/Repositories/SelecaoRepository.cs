﻿using ExemploWebApi.Contexts;
using ExemploWebApi.Domains;
using ExemploWebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace ExemploWebApi.Repositories
{
    public class SelecaoRepository : ISelecaoRepository
    {
        WebApiBdContext ctx = new WebApiBdContext();

        public void Atualizar(int id, Selecao selecaoNova)
        {
            Selecao selecaoBuscada = ctx.Selecao.Find(id);

            selecaoBuscada.Nome = selecaoNova.Nome;
            selecaoBuscada.Bandeira = selecaoNova.Bandeira;
            selecaoBuscada.Uniforme = selecaoNova.Uniforme;
            selecaoBuscada.Escalacao = selecaoNova.Escalacao;

            ctx.Selecao.Update(selecaoBuscada);

            ctx.SaveChanges();
        }

        public void Cadastrar(Selecao selecaoNova)
        {
            ctx.Selecao.Add(selecaoNova);

            ctx.SaveChanges();
        }

        public Selecao ListarPorId(int id)
        {
            return ctx.Selecao.FirstOrDefault(s => s.Id == id);
        }

        public List<Selecao> ListarTodos()
        {
            return ctx.Selecao.ToList();
        }

        public void Remover(int id)
        {
            Selecao selecaoBuscada = ctx.Selecao.Find(id);

            ctx.Selecao.Remove(selecaoBuscada);

            ctx.SaveChanges();
        }
    }
}
