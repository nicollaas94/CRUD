using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Core.Model;
using Core.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Core.Controllers
{
    public class CrudController : Controller
    {
        private CrudContext context;
        public CrudController(CrudContext context)
        {
            this.context = context;
        }

        public IActionResult Listar()
        {
            return this.context.Candidatos.ToArray().ToJsonResult();
        }

        public IActionResult Cadastrar([FromBody]Candidato cand)
        {

            this.context.Candidatos.Add(cand);
            this.context.SaveChanges();
            return Ok();
        }

        public IActionResult excluir(int candidatoId)
        {
            var candidato = this.context.Candidatos.Where(c => c.CandidatoId == candidatoId).SingleOrDefault();
            this.context.Remove(candidato);
            this.context.SaveChanges();
            return Ok();
        }
        
        public IActionResult pegarCandidato(int candidatoId)
        {
            var candidato = this.context.Candidatos.Include(c => c.Banco).Include(c => c.Conhecimento).Where(c => c.CandidatoId == candidatoId).SingleOrDefault();
            return candidato.ToJsonResult();
        }
    }
}
