using Microsoft.AspNetCore.Mvc;
using WeatherAPI.Models;

namespace WeatherAPI.Controllers
{
    public class WeatherForecastController : Controller
    {
        [HttpGet]
        public IActionResult SearchByCity()
        {
            var viewModel = new SearchByCity();
            return View();
        }

        public IActionResult SearchByCity(SearchByCity model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("City", "WeatherForecast", new { city = model.CityName });    
            }
            return View(model);
        }

        public IActionResult City(string city)
        {
            City viewModel = new City();
            return View(viewModel);
        }
    }
}
