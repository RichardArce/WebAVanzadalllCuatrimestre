using Microsoft.AspNetCore.Mvc;

namespace WebAVanzadalllCuatrimestre.Controllers
{
    public class DuennoController : Controller
    {

        //private readonly IDuennoService _duennoService;



        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> ListarDuenno()
        {
            //var duenno = await _duennoService.ListarDuenno();

            return Json("ok");
        }

        public async Task<IActionResult> GuardarDuenno(/*Duenno dto*/)
        {
            //var duenno = await _duennoService.GuardarDuenno(dto);
            return Json("ok");
        }

        public async Task<IActionResult> EditarDuenno(/*Duenno dto*/)
        {
            //var duenno = await _duennoService.EditarDuenno(dto);
            return Json("ok");
        }

        public async Task<IActionResult> EliminarDuenno(int id)
        {
            //var duenno = await _duennoService.EliminarDuenno(id);
            return Json("ok");
        }





    }
}
