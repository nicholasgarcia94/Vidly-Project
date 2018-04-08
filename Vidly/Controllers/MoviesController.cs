using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using System.Data.Entity;
	

namespace Vidly.Controllers
{
	public class MoviesController : Controller
	{

		private ApplicationDbContext _context;

		public MoviesController()
		{
			_context = new ApplicationDbContext();
		}

		protected override void Dispose(bool Disposing)
		{
			_context.Dispose();
		}
		

		//movies
		public ActionResult Index()
		{

			var movie = _context.Movies.Include(m => m.Genre).ToList();


			return View(movie);
		}

		public ActionResult Details(int id)
		{
			var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);

			if (movie == null)
				return HttpNotFound();

			return View(movie);
		}

		public ActionResult Edit(int id)
		{
			return Content("id = " + id);
		}

		private IEnumerable<Movie> GetMovies()
		{
			return new List <Movie>
			{
				new Movie { Name = "Shrek", Id = 1 },
				new Movie { Name = "Wall-e", Id = 2 }
			};
		}

		public ActionResult ByReleaseDate(int year, int month)
		{
			return Content( "Year = " + year + " Month = " + month);
		}

		// GET: Movies/Random
		public ActionResult Random()
		{
			var movie = new Movie() { Name = "Shrek!" };

			var customers = new List<Customer>
			{
				new Customer { Name = "Customer 1"},
				new Customer { Name = "Customer 2"}
			};

			var ViewModel = new RandomMovieViewModel
			{
				Movie = movie,
				Customers = customers
			};

			//var viewResult = new ViewResult();
			//viewResult.ViewData.Model
			return View(ViewModel);

		}
	}
}