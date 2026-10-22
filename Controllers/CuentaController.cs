using Microsoft.AspNetCore.Mvc;
using PROYECTO_MoneyUp.Models;

namespace PROYECTO_MoneyUp.Controllers;

public class CuentaController : Controller
{
    [HttpGet]
    public IActionResult IniciarSesion() => View();

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult IniciarSesion(IniciarSesionViewModel model)
    {
        if (!ModelState.IsValid) return View(model);
        ModelState.AddModelError(string.Empty, "El acceso estará disponible cuando conectemos la base de datos.");
        return View(model);
    }

    [HttpGet]
    public IActionResult Registrarse() => View();

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Registrarse(RegistroViewModel model)
    {
        if (!ModelState.IsValid) return View(model);
        ModelState.AddModelError(string.Empty, "El registro estará disponible cuando conectemos la base de datos.");
        return View(model);
    }
}
