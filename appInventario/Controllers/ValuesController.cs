using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using appInventario.Context;
using appInventario.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Runtime.Serialization;
using Microsoft.IdentityModel.Tokens;

namespace appInventario.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {

        private readonly AppDbContext context;

        public ValuesController(AppDbContext context)
        {
            this.context = context;
        }


        // GET api/values
        [HttpGet]
        public ActionResult Get()
        {

            //var myRecipes = context.Colaboradores.FromSql("SELECT * FROM COLABORADOR ").ToList();


            var query = (from colaborador in context.Set<Colaborador>()
                            join rol in context.Set<Rol>()
                                on colaborador.CodigoRolActual equals rol.CodigoRol
                            select new {
                                colaborador.Matricula,
                                colaborador.Nombre,
                                colaborador.Apellido,
                                rol.NombreRol
                                        }).AsQueryable();

            return Content(JsonConvert.SerializeObject(query));

        }

        private JsonResult JsonResult(List<Colaborador> myRecipes)
        {
            throw new NotImplementedException();
        }

        private IQueryable<Colaborador> JsonResult(IQueryable<object> query)
        {
            throw new NotImplementedException();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
