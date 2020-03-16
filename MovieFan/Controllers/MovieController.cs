using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MovieFan.Models;

namespace MovieFan.Controllers
{
    public class MovieController : Controller
    {
        private readonly moviefanContext db;

        public MovieController(moviefanContext db)
        {
            this.db = db;
        }

        // GET: Movie
        public ActionResult Index()
        {
            List<Movies> movies = db.Movies
                .Include(m => m.Category)
                .Include(m => m.Rating)
                .ToList();
            return View(movies);
        }

        // GET: Movie/Details/5
        public ActionResult Details(int id)
        {
            Movies movie = db.Movies
                .Include(m => m.Category)
                .Include(m => m.Rating)
                .Include(m => m.UserLikeMovie)
                .ThenInclude(u => u.User)
                .SingleOrDefault(m => m.Id == id);

            ViewBag.CategoryId = db.Categories.Select(m => new SelectListItem { Text = m.Name, Value = m.Id.ToString() }).ToList();
            ViewBag.RatingId = db.Ratings.Select(r => new SelectListItem { Text = r.Name, Value = r.Id.ToString() }).ToList();

            return View(movie);
        }

        // GET: Movie/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Movie/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Movie/Edit/5
        public ActionResult Edit(int id)
        {
            Movies movie = db.Movies
                .Include(m => m.Category)
                .Include(m => m.Rating)
                .SingleOrDefault(m => m.Id == id);

            ViewBag.CategoryId = db.Categories.Select(m => new SelectListItem { Text = m.Name, Value = m.Id.ToString() }).ToList();
            ViewBag.RatingId = db.Ratings.Select(r => new SelectListItem { Text = r.Name, Value = r.Id.ToString() }).ToList();

            return View(movie);
        }

        // POST: Movie/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult<Movies> Edit(int id, Movies movie)
        {
            try
            {
                db.Update(movie);
                db.SaveChanges();
                TempData["Update"] = movie.Title + " à bien été modifié";

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                TempData["Update"] = movie.Title + "n'a pas été modifié";
                return View();
            }
        }

        // GET: Movie/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Movie/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}