using Microsoft.AspNetCore.Mvc;
using Synevo_test_project.Data;
using Synevo_test_project.Entites;
using Synevo_test_project.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Synevo_test_project.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPokemonOrderRepository _repository;
        public HomeController(IPokemonOrderRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            return View();
        }

        
        [HttpPost]
        public IActionResult Post([FromForm] PokemonOrderModel order)
        {
             if (string.IsNullOrEmpty(order.Email))
           {
                ModelState.AddModelError(nameof(order.Email),"Please enter your email");
            }

            if (string.IsNullOrEmpty(order.Name))
            {
                ModelState.AddModelError(nameof(order.Email), "Please enter your name");
            }

            if (ModelState.IsValid) { 
                var newItem = new PokemonOrder { Email = order.Email, Name = order.Name, Phone = order.Phone, CreatedTime = DateTime.UtcNow };
                _repository.Insert(newItem);
                SendingEmail.Send(newItem);
                return RedirectToAction(nameof(Feed));
                
              
           }
            else
            {
                 return  View("Index"); 
            }
        }
                
     
        public IActionResult Feed()
        {
            var result = _repository.GetAll();
            return View(result);
        }
    }
}
