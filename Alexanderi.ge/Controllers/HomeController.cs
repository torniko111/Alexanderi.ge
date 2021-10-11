using Alexanderi.ge.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alexanderi.ge.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILeatherProductRepository _leatherProductRepository;

        public HomeController(ILeatherProductRepository leatherProductRepository)
        {
            _leatherProductRepository = leatherProductRepository;
        }









        public string Index()
        {
           return _leatherProductRepository.GetLeatherProduct(1).Name;
        }
    }
}
