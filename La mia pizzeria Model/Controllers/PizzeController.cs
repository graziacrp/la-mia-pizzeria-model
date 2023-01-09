using Microsoft.AspNetCore.Mvc;

namespace La_mia_pizzeria_Model.Controllers
{
    public class PizzeController: Controller
    {

        public IActionResult Index()
        {
            List<Pizze> listaDellePizze = PizzeData.GetPizze();

            return View("Index", listaDellePizze);
        }

        public IActionResult Details(int id)
        {
            List<Pizze> listaDellePizze = PizzeData.GetPizze();

            foreach(Pizze pizze in listaDellePizze)
            {
                if (pizze.Id==id)
                {
                    return View(pizze);
                }
            }

            return NotFound("La pizza con l'id cercato non esiste");
        }

       
    }
}
