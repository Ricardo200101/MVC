using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using fistApplication.Models;

namespace fistApplication.Controllers
{
    public class PersonalController : Controller
    
    {
        public IActionResult Index(){
            Personal personal = new Personal(); 
            personal.name = "Ricardo "; 
            personal.lastname = "Alvarez "; 
            personal.age =21 ; 
            personal.number =77216638 ; 
            personal.main = "victoralvarez.ra@gmail.com " ; 
            personal.address ="El Salvador, San miguel"; 


            return View(personal); 
        }

    }
    }