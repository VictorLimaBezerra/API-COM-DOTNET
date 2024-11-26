using API_COM_DOTNET.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_COM_DOTNET.Controllers;

[ApiController]
[Route("[controller]")]

public class FilmeController : ControllerBase
{
    private static List<Filme> filmes = new List<Filme>();
    private static int filmeId = 0;

    [HttpPost]
    public IActionResult AdicionarFilme([FromBody] Filme filme)
    {
        filme.Id = filmeId++;
        filmes.Add(filme);
        return CreatedAtAction(nameof(LerFilmeId), new { id = filme.Id }, filme);
    }

    [HttpGet]

    //Para escolher algo diretente do padrao --> ?skip=numero de elementos q passou&take=numero de elementos por pagina
    //Ex.: {{baseUrl}}/Filme?skip=2&take=5
    public IEnumerable<Filme> LerFilmes([FromQuery] int skip = 0, [FromQuery] int take = 5)
    {
        return filmes.Skip(skip).Take(take);
    }


    [HttpGet("{id}")]

    public IActionResult? LerFilmeId(int id)
    {
        var filme = filmes.FirstOrDefault(filme => filme.Id == id);
        if (filme == null) return NotFound();
        return Ok(filme);
    }


}
