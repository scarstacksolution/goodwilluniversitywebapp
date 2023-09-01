using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Aug31_Ver1_WebAp.Models;
using Aug31_Ver1_WebAp.Interfaces;

namespace Aug31_Ver1_WebAp.Controllers;

public class HomeController : Controller
{
    // Field Properties
    private readonly IPersonRepository _personRepository;
    private readonly ILogger<HomeController> _logger;


    // Constuctor
    public HomeController(IPersonRepository personRepository, ILogger<HomeController> logger)
    {
        _personRepository = personRepository;
        _logger = logger;
    }

    // Methods
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult GetPerson(Person person)
    {
        try
        {
            _logger.LogInformation("Processing request for Student data at: {DT}", DateTime.Now.ToLongTimeString());
            var model = new ViewModel();
            model.Person = _personRepository.GetPersonById(person.id);

            if (model.Person == null)
            {
                _logger.LogWarning("No information found for Student based on Id at: {DT}", DateTime.Now.ToLongTimeString());
                ModelState.AddModelError("person", "there was an issue returning the requested information");
            }

            _logger.LogInformation("Returning Student data at: {DT}", DateTime.Now.ToLongTimeString());
            return View("Index", model);
        }
        catch (Exception ex)
        {
            _logger.LogError("At: {DT}, Exception errror for Student data, was caught: {ex.InnerException}",
                DateTime.Now.ToLongTimeString(), ex.InnerException);
            throw ex.InnerException!;
        }
    }


    public IActionResult Privacy()
    {
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

