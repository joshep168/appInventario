using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using appInventario.Context;
using appInventario.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace appInventario.Controllers
{
    [Route("api/[controller]")]
    public class BuscaColaboradorController : Controller
    {
        private readonly AppDbContext context;

        public BuscaColaboradorController(AppDbContext context) {
            this.context = context;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Colaborador> Get()
        {
            //string squery = "SELECT COL.CO_COLABORADOR CodigoColaborador1,COL.TX_MATRICULA Matricula,COL.TX_NOMBRE Nombre,COL.TX_APELLIDO Apellido,COL.CO_ROL_ACTUAL Rol,ROL.TX_NOMBRE_ROL NombreRol FROM COLABORADOR COL INNER JOIN ROL ON ROL.CO_ROL = COL.CO_ROL_ACTUAL";
            //var xquery = context.Colaborador.FromSql(squery);


            return context.Colaboradores.ToList();



        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
