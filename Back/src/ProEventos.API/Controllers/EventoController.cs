using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
    
    public EventoController()
    {

    }

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
        return new Evento[]{
           new Evento(){
             EventoId = 1,
            Tema = "Angular 15 e .NET 7",
            Local = "Belo Horizonte",
            Lote = "1° Lote",
            QtdPessoas = 250,
            DataEvento = DateTime.Now.AddDays(2).ToString(),
            ImagemURL = "foto.png"
           }
        };
    }
}
