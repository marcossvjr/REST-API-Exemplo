using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace API_REST_Exemplo.Controllers
{
    [Route("api/[controller]")]
    public class JogoController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Json(DBFake.Tbl_Jogo);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Jogo jogo = DBFake.Tbl_Jogo.FirstOrDefault(j => j.Id == id);
            if (jogo != null) return Json(jogo);
            else return NotFound();
        }

        [HttpPost]
        public IActionResult Post([FromForm] string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                return BadRequest();

            if (DBFake.Tbl_Jogo.FirstOrDefault(j => j.Nome == nome) != null)
                return BadRequest();

            Jogo jogo = new Jogo(nome);
            DBFake.Tbl_Jogo.Add(jogo);

            
            return Created(new System.Uri($"{Request.Path}{jogo.Id}", System.UriKind.Relative), jogo);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromForm] string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                return BadRequest();

            Jogo jogo = DBFake.Tbl_Jogo.FirstOrDefault(j => j.Id == id);
            if (jogo != null)
            {
                jogo.Nome = nome;
                return Ok(jogo);
            }
            else return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Jogo jogo = DBFake.Tbl_Jogo.FirstOrDefault(j => j.Id == id);
            if (jogo != null)
            {
                DBFake.Tbl_Jogo.Remove(jogo);
                return Ok();
            }
            else return NotFound();
        }
    }
}
