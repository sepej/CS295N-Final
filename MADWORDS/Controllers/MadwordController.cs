﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MADWORDS.Models;
using MADWORDS.Repos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MADWORDS.Controllers
{
    public class MadwordController : Controller
    {
        IMadwordRepository repo;

        public MadwordController(IMadwordRepository r)
        {
            repo = r;
        }

        public IActionResult Index()
        {
            List<Madword> madwords = repo.Madwords.ToList<Madword>(); // Use ToList to convert the IQueryable to a list
            
            return View(madwords);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Madword(Madword model)
        {
            model.MadwordDate = DateTime.Now;
            // Store the model in the database
            repo.AddMadword(model);

            return View(model);
        }

        public IActionResult Madwords()
        {
            //get all madwords in the database
            List<Madword> madwords = repo.Madwords.ToList<Madword>(); // Use ToList to convert the IQueryable to a list
            
            return View(madwords);
        }
    }
}