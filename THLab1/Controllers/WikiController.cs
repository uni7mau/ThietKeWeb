using Microsoft.AspNetCore.Mvc;
using THLab1.Models;

namespace THLab1.Controllers
{
    public class WikiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Characters()
        {
            var characters = new List<Character>();
            var char1 = new Character();
            char1.strength = 50;
            char1.agility = 50;
            char1.something = 50;
            char1.charPicUrl = "/images/tempcharacter.jpg";

            var char2 = new Character();
            char2.strength = 100;
            char2.agility = 36;
            char2.something = 9;
            char1.charPicUrl = "/images/tempcharacter2.jpg";

            characters.Add(char1);
            characters.Add(char2);

            return View(characters);
        }

        public IActionResult Weapons()
        {
            var weapons = new List<Weapon>();
            var weap1 = new Weapon();
            weap1.hpBonus = 100;
            weap1.attackBonus = 50;
            weap1.weapPicUrl = "/images/tempweapon.jpg";

            var weap2 = new Weapon();
            weap2.hpBonus = 49;
            weap2.attackBonus = 53;
            weap1.weapPicUrl = "/images/tempweapon2.jpg";

            weapons.Add(weap1);
            weapons.Add(weap2);

            return View(weapons);
        }

        public IActionResult Maps()
        {
            return View();
        }
    }
}
