
using E_1;

using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }



        public IActionResult Index()
        {





            CV mioCV = new CV
            {
                InformazioniPersonali = new InformazioniPersonali
                {
                    Name = "Ivanov",
                    Cognome = "Rominsky",
                    Telefono = "123456789",
                    Email = "mario.rossi@example.com"
                },
                StudiEffettuati = new List<Studi>
                {
                    new Studi
                    {
                        Qualifica = "Laurea in Spionaggio",
                        Istituto = "Università degli Studi di Surguth",
                        Tipo = "Laurea",
                        Dal = new DateTime(2010, 9, 1),
                        Al = new DateTime(2013, 7, 1)
                    }
                },
                Impieghi = new List<Impiego>()
            };

            mioCV.Impieghi.Add(new Impiego
            {
                Esperienza = new Esperienza
                {
                    Azienda = "Tech Company",
                    JobTitle = "Software Developer",
                    Dal = new DateTime(2014, 1, 15),
                    Al = new DateTime(2018, 12, 31),
                    Descrizione = "Sviluppo di applicazioni web",
                    Compiti = "Progettazione e implementazione di nuove funzionalità"
                }
            });

            mioCV.Impieghi.Add(new Impiego
            {
                Esperienza = new Esperienza
                {
                    Azienda = "Innovative Solutions",
                    JobTitle = "Senior Developer",
                    Dal = new DateTime(2019, 1, 1),
                    Al = DateTime.Now,
                    Descrizione = "Gestione di progetti complessi e mentoring per i nuovi assunti",
                    Compiti = "Sviluppo e ottimizzazione di sistemi software, revisione del codice e spionaggio militare"
                }
            });


           
  return View(mioCV);
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
}
