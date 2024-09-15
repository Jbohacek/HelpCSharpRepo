using _11_Webikos.Models;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace _11_Webikos.Controllers
{
    public class UserController : Controller
    {

        public IActionResult GetUser(string name, int vek, bool zije, string prijmeni = "-Nevyplneno-")
        {
            User uzivetel = new User();
            uzivetel.name = name;
            uzivetel.vek = vek;
            uzivetel.zije = zije;

            ViewBag.prijmeni = prijmeni;


            return View(uzivetel);
        }

        [HttpGet]
        public User GetMyString()
        {
            User uzivetel = new User();
            uzivetel.name = "Jakub";
            uzivetel.vek = 20;
            uzivetel.zije = true;

            return uzivetel;
        }

        public IActionResult ShowCreateUser()
        {
            return View();
        }

        [HttpPost]
        public User CreateUser(User ToCoJsemDostal)
        {
            return ToCoJsemDostal;
        }
    }
}
