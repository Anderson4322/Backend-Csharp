using Microsoft.AspNetCore.Mvc;

namespace Back_end_Smarthub.Controllers;

[ApiController]
[Route("api/clientes")]
public class ClientesController : ControllerBase
{
    [HttpGet]
    public IActionResult Listar()
    {
        var clientes = new[]
        {
            new
            {
                id = 1,
                nome = "Anderson",
                telefone = "16999999999"
            },
            new
            {
                id = 2,
                nome = "João",
                telefone = "16988888888"
            }
        };

        return Ok(clientes);
    }

    [HttpGet("{id}")]
    public IActionResult Buscar(int id)
    {
        return Ok(new
        {
            id = id,
            nome = "Anderson",
            telefone = "16999999999"
        });
    }

    [HttpPost()]
    public IActionResult Cadastrar([FromBody] dynamic cliente)
    {
       return Ok(new
        {
            nome = cliente.nome,
            email = cliente.email,
            senha = cliente.senha
        });
    }
}