using Microsoft.AspNetCore.Mvc;
using AcademiaEFC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using X.PagedList;

namespace AcademiaEFC.Controllers
{
    public class AlunoController : Controller
    {
        Context context;
        public AlunoController(Context ctx)
        {
            context = ctx;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
