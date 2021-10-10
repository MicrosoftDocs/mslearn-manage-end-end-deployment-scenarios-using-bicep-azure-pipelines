using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToyCompany.Website.Models;
using ToyCompany.Website.Services;

namespace ToyCompany.Website.Pages
{
    public class ToysModel : PageModel
    {
        private readonly IToyService _toyService;

        public List<Toy> Toys { get; set; }

        public ToysModel(IToyService toyService)
        {
            _toyService = toyService;
        }

        public void OnGet()
        {
            Toys = _toyService.GetToys();
        }
    }
}
