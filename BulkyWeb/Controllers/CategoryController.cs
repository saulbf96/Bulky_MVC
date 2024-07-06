using BulkyWeb.Data;
using BulkyWeb.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Controllers
{//este es el controlador de categorya 
    public class CategoryController : Controller
    {
        //esto es un mvc controller empty

        //iniciamos la conexion 
        private readonly ApplicationDbContext _context;
        public CategoryController(ApplicationDbContext context) 
        { 
            _context = context;
        
        }
        public IActionResult Index()
        {
            //mostrar datos 
            List<Category> objCategoryList = _context.Categories.ToList();
            return View(objCategoryList);
        }
    }
}
