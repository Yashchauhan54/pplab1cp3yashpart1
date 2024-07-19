using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aspnetcoreapp.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
     public void OnPost()
    {
 
        if (Request.Method.Equals("POST", System.StringComparison.OrdinalIgnoreCase)){


            if(Request.Form["+"]=="+"){
 
                ViewData["sum"]= "The sum of given numbers is: "+ (double.Parse(Request.Form["num1"]) + double.Parse(Request.Form["num2"]));
            }

            if(Request.Form["-"]=="-"){
 
                ViewData["substract"]= "The difference of given numbers is: "+ (double.Parse(Request.Form["num1"]) - double.Parse(Request.Form["num2"]));
            }

            if(Request.Form["*"]=="*"){
 
                ViewData["multiply"]= "The multiplication of given numbers is: "+ (double.Parse(Request.Form["num1"]) * double.Parse(Request.Form["num2"]));
            }

            if(Request.Form["/"]=="/"){
 
                ViewData["division"]= "The division of given numbers is: "+ (double.Parse(Request.Form["num1"]) / double.Parse(Request.Form["num2"]));

            }
 
            if(Request.Form["x^2"]=="x^2"){
 
                ViewData["squares"]= "The Square of given number is: "+ (double.Parse(Request.Form["num1"]) * double.Parse(Request.Form["num1"]));
            }

            if(Request.Form["x^3"] == "x^3"){
        
                ViewData["cubes"] = "The cube of given number is: "+ (Math.Pow(double.Parse(Request.Form["num1"]), 3));

            }
            
            if(Request.Form["x^n"] == "x^n"){
        
                ViewData["powers"] = "The power of given number is: "+ (Math.Pow(double.Parse(Request.Form["num1"]), double.Parse(Request.Form["num2"])));

            }

            
 
        }
 
 
    }
}



