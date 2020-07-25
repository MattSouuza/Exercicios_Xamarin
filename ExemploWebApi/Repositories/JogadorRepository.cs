using ExemploWebApi.Contexts;
using ExemploWebApi.Domains;
using ExemploWebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploWebApi.Repositories
{
    public class JogadorRepository : IJogadorRepository
    {
        WebApiBdContext ctx = new WebApiBdContext();

        public void Atualizar(int id, Jogador jogadorNovo)
        {
            Jogador jogadorBuscado = ctx.Jogador.Find(id);

            jogadorBuscado.Nome = jogadorNovo.Nome;
            jogadorBuscado.Nascimento = jogadorNovo.Nascimento;
            jogadorBuscado.Posicao = jogadorNovo.Posicao;
            jogadorBuscado.Qtdefaltas = jogadorNovo.Qtdefaltas;
            jogadorBuscado.QtdecartoesAmarelo = jogadorNovo.QtdecartoesAmarelo;
            jogadorBuscado.QtdecartoesVermelho = jogadorNovo.QtdecartoesVermelho;
            jogadorBuscado.Informacoes = jogadorNovo.Informacoes;
            jogadorBuscado.NumeroCamisa = jogadorNovo.NumeroCamisa;
            jogadorBuscado.Foto = jogadorNovo.Foto;
            jogadorBuscado.SelecaoId = jogadorNovo.SelecaoId;

            ctx.Jogador.Update(jogadorBuscado);

            ctx.SaveChanges();
        }

        public void Cadastrar(Jogador jogadorNovo)
        {
            ctx.Jogador.Add(jogadorNovo);

            ctx.SaveChanges();
        }

        public Jogador ListarPorId(int id)
        {
            return ctx.Jogador.FirstOrDefault(j => j.Id == id);
        }

        public List<Jogador> ListarTodos()
        {
            return ctx.Jogador.ToList();
        }

        public void Remover(int id)
        {
            Jogador jogadorBuscado = ctx.Jogador.Find(id);
            
            ctx.Jogador.Remove(jogadorBuscado);

            ctx.SaveChanges();
        }
    }
}
