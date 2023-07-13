using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gnk_invest_test.Models;
using Microsoft.AspNetCore.Mvc;

namespace gnk_invest_test.Controllers
{
    public class HomeController : Controller
    {
        private readonly InvestDatacontext _context;

        public HomeController(InvestDatacontext context)
        {
            _context = context;
        }

        public IActionResult GetDealsWithContractors()
        {
            var deals = _context.Sales
                .Select(sale => new Sale
                {
                    Id = sale.Id,
                    Name = sale.Name,
                    Contractor = new Contractor
                    {
                        Id = sale.Contractor.Id,
                        Name = sale.Contractor.Name
                    }
                })
                .ToList();

            return View(deals);
        }

        public IActionResult GetDealsWithContractorsAndAddresses()
        {
            var deals = _context.Sales
                .Select(sale => new Sale
                {
                    Id = sale.Id,
                    Name = sale.Name,
                    Contractor = new Contractor
                    {
                        Id = sale.Contractor.Id,
                        Name = sale.Contractor.Name,
                        LegalAddress = sale.Contractor.LegalAddress,
                        PostalAddress = sale.Contractor.PostalAddress
                    }
                })
                .ToList();

            return View(deals);
        }

        public IActionResult GetDealsWithContractorsAndAddressesAndDeathInfo()
        {
            var deals = _context.Sales
                .Select(sale => new Sale
                {
                    Id = sale.Id,
                    Name = sale.Name,
                    Contractor = new Contractor
                    {
                        Id = sale.Contractor.Id,
                        Name = sale.Contractor.Name,
                        LegalAddress = sale.Contractor.LegalAddress,
                        PostalAddress = sale.Contractor.PostalAddress,
                        ContractorIndividual = new ContractorIndividual
                        {
                            OtmetkaOSmertiZaemschika = sale.Contractor.ContractorIndividual.OtmetkaOSmertiZaemschika,
                            DataSmertiZaemschika = sale.Contractor.ContractorIndividual.DataSmertiZaemschika,
                            Bankrot = sale.Contractor.ContractorIndividual.Bankrot
                        }
                    }
                })
                .ToList();

            return View(deals);
        }
    }
}