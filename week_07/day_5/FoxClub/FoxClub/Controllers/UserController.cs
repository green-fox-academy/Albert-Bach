//using Microsoft.AspNetCore.Mvc;
//using FoxClub.Models;

//namespace FoxClub.Controllers
//{
//    [Route("/user")]
//    public class UserController : Controller
//    {
//        private User user;

//        public UserController(User user)
//        {
//            this.user = user;
//        }

//        [HttpPost]
//        public IActionResult LoginHandler(User userFromForm)
//        {

//            user.Name = userFromForm.Name;
//            user.Foxes.Add(new Fox()
//            {
//                Name = "Mr.Fox",
//                ListOfTricks = "",
//                Food = "",
//                Drink = "",
//            });
//            return LocalRedirect("/user/" + user.Name);
//        }



//        [HttpGet]
//        [Route("/user/{userName}")]
//        public IActionResult Profile(string userName)
//        {
//            return View(user);
//        }

//        [HttpGet]
//        [Route("/user/nutritionStore")]
//        public IActionResult NutritionStore()
//        {
//            var pokemon = new Pokemon()
//            {
//                Id = 13,
//                Type = PokemonType.Bulbasaur,
//                Level = 8
//            };
//            return View(pokemon);
//        }

//        [HttpPost]
//        [Route("/user/trickCenter")]
//        public IActionResult TrickCenter(Pokemon pokemonFromForm)
//        {
//            user.Pokemons.Add(pokemonFromForm);
//            return LocalRedirect("/user/" + user.Name);
//        }

//    }
//}