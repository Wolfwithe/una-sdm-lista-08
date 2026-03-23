using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using AulaMetodoHttp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AulaMetodoHttp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutosController : ControllerBase
    {
        private static List <Produto> produtos  = new();

        [HttpGet]
        public ActionResult <IEnumerable<Produto>> Get()
        {
            return Ok(produtos);
        }
        [HttpPost]
        public  ActionResult<Produto> Post(Produto produto)
        {
            produtos.Add(produto);
            return CreatedAtAction(nameof(Get), new { id = produto.Id }, produto);
        }

        

    }
}