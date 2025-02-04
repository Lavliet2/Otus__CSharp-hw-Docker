using Microsoft.AspNetCore.Mvc;
using HWDocker.Data;
using HWDocker.Models;
using Microsoft.EntityFrameworkCore;

namespace HWDocker.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MenuController : ControllerBase
{
    private readonly AppDbContext _context;

    public MenuController(AppDbContext context) => _context = context;

    [HttpGet]
    public async Task<ActionResult<IEnumerable<MenuItem>>> GetMenu() =>
        await _context.MenuItems.ToListAsync();
}
