using System;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")] //o caminho da api sera xxxx/api/users (o nome do controller)
public class UsersController(DataContext context) : ControllerBase
{
    //nao precisa pois esta declarado acima na classe
    //private readonly DataContext _context = context; // _ em vez de usar this. para privates

    [HttpGet]//como e um retorno HTTP pode retornar as opcoees do HTTP
        // ex- Badrequest = 4xx
        // ex- NotFound
    public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
    {
        var users= await context.Users.ToListAsync();
    
        return users; //com o actionResult ele ja entende que e OK se tiver algo
    }

    [HttpGet("{id:int}")] // nao pode ter 2 HTTPGETS iguais nno meu controller tem que mudar
    //mudar o route ficaria /api/users/1 1= o id da pessoa
    public async Task<ActionResult<AppUser>> GetUser(int id)
    {
        var user= await context.Users.FindAsync(id);
        if (user == null) return NotFound();

        return user; //com o actionResult ele ja entende que e OK se tiver algo
    }
}

