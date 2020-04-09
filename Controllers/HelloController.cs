    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    // using System;

    namespace IntroASP.Controllers
    {
        // public class HelloController : Controller   //inheritance from Controller class
        // {
        //     //for each route this controller is to handle:
        //     [HttpGet]       //request type
        //     [Route("")]     //associated route path leads with "/"
        //     public string Index()
        //     {
        //         return "Hello World from HelloController!";
        //     }

        //     [HttpGet]
        //     [Route("{name}")]
        //     public string name(string name){
        //         return $"Hello, this is {name}!";
        //     }

        //     [HttpGet]
        //     [Route("pizza/{topping}")]
        //     public string toppsings(string topping){
        //         return $"I want {topping} on my pizza!";
        //     }
        // }

        // public class UserController : Controller
        // {
        //     [HttpGet]
        //     [Route("/users")]
        //     public string Users()
        //     {
        //         return "This is the user Page";
        //     }
        // }

        public class PortfolioController : Controller 
        {
            // testing index route with view
            [HttpGet]
            [Route("index")]
            public ViewResult Index(){
                return View();
            }

            // Condense request and route and testing template routing
            // & viewbag(context) functionality
            [HttpGet("")]
            public ViewResult Home(){
                ViewBag.name="Andrew";
                return View();
            }

            [HttpGet("projects")]
            public ViewResult Projects(){
                ViewBag.name="Andrew";
                return View();
            }

            [HttpGet("contact")]
            public ViewResult Contact(){
                ViewBag.name="Andrew";
                return View();
            }

            // learning/testing post request functionality
            [HttpGet("survey")]
            public ViewResult Survey(){
                return View();
            }

            [HttpPost("processForm")]
            public RedirectToActionResult processForm(string name, string location, string language, string comment)
            {
                return RedirectToAction("result", 
                new {Name = name, Location=location, Language=language, Comment=comment});
            }
            [HttpGet("result")]
            public ViewResult Result(string Name, string Location, string Language, string Comment){
                ViewBag.name=Name;
                ViewBag.location=Location;
                ViewBag.language=Language;
                ViewBag.comment=Comment;
                return View();
            }
            
            // Testing Redirect functions
            // public RedirectToActionResult Method(){
            //     return RedirectToAction("OtherMethod", new {Food = "sandwhiches", Quantity = 5});
            // }

            // [HttpGet]
            // [Route("other/{Food}/{Quantity}")]
            // public ViewResult OtherMethod(string Food, int Quantity)
            // {
            //     Console.WriteLine($"I ate {Quantity} {Food}");
            //     return View();
            // }
        }
    }
