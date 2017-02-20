using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Core.Model;
using Core.Extensions;

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
    }
}
