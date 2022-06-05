using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrbanAreasProject.ViewModels;
using UrbanAreasProject.Models;
using Microsoft.AspNetCore.Authorization;
using System.Text.Json;


namespace UrbanAreasProject.Controllers
{
    /// <summary>
    /// Controller for rating table
    /// </summary>
    public class RatingController : Controller
    {
        private readonly UserContext db;
        public RatingController(UserContext context)
        {
            db = context;
        }

        /// <summary>
        /// Index page (rating table)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="country"></param>
        /// <param name="region"></param>
        /// <param name="sortOrder"></param>
        /// <returns>View users table</returns>
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Index(string name, string country, string region, SortState sortOrder = SortState.NameAsc)
        {
            User curuser = await db.Users.FirstOrDefaultAsync(user => user.UserName == User.Identity.Name);

            var cities = JsonSerializer.Deserialize<List<DataCity>>(curuser.RatingCities);

            if (!String.IsNullOrEmpty(name) && !String.IsNullOrEmpty(country) && !String.IsNullOrEmpty(region))
            {
                cities = cities.Where(p => p.Name.Contains(name) && p.Country.Contains(country) && p.Region.Contains(region)).ToList();
            }
            if (!String.IsNullOrEmpty(name) && !String.IsNullOrEmpty(country) && String.IsNullOrEmpty(region))
            {
                cities = cities.Where(p => p.Name.Contains(name) && p.Country.Contains(country)).ToList();
            }
            if (!String.IsNullOrEmpty(name) && String.IsNullOrEmpty(country) && !String.IsNullOrEmpty(region))
            {
                cities = cities.Where(p => p.Name.Contains(name) && p.Region.Contains(region)).ToList();
            }
            if (String.IsNullOrEmpty(name) && !String.IsNullOrEmpty(country) && !String.IsNullOrEmpty(region))
            {
                cities = cities.Where(p => p.Country.Contains(country) && p.Region.Contains(region)).ToList();
            }
            if (String.IsNullOrEmpty(name) && String.IsNullOrEmpty(country) && !String.IsNullOrEmpty(region))
            {
                cities = cities.Where(p => p.Region.Contains(region)).ToList();
            }
            if (String.IsNullOrEmpty(name) && !String.IsNullOrEmpty(country) && String.IsNullOrEmpty(region))
            {
                cities = cities.Where(p => p.Country.Contains(country)).ToList();
            }
            if (!String.IsNullOrEmpty(name) && String.IsNullOrEmpty(country) && String.IsNullOrEmpty(region))
            {
                cities = cities.Where(p => p.Name.Contains(name)).ToList();
            }

            switch (sortOrder)
            {
                case SortState.NameDesc:
                    cities = cities.OrderByDescending(s => s.Name).ToList();
                    break;
                case SortState.PopulationAsc:
                    cities = cities.OrderBy(s => s.Population).ToList();
                    break;
                case SortState.PopulationDesc:
                    cities = cities.OrderByDescending(s => s.Population).ToList();
                    break;
                case SortState.LatitudeAsc:
                    cities = cities.OrderBy(s => Convert.ToDouble(s.Latitude)).ToList();
                    break;
                case SortState.LatitudeDesc:
                    cities = cities.OrderByDescending(s => Convert.ToDouble(s.Latitude)).ToList();
                    break;
                case SortState.LongitudeAsc:
                    cities = cities.OrderBy(s => Convert.ToDouble(s.Longitude)).ToList();
                    break;
                case SortState.LongitudeDesc:
                    cities = cities.OrderByDescending(s => Convert.ToDouble(s.Longitude)).ToList();
                    break;
                default:
                    cities = cities.OrderBy(s => s.Name).ToList();
                    break;
            }

            IndexViewModel viewModel = new IndexViewModel
            {
                SortViewModel = new SortViewModel(sortOrder),
                FilterViewModel = new FilterViewModel(name, country, region),
                Cities = cities
            };
            return View(viewModel);
        }

        /// <summary>
        /// Add City
        /// </summary>
        /// <param name="city"></param>
        /// <returns>View Index</returns>
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Add(DataCity city)
        {
            List<DataCity> cities = new List<DataCity>();
            User curuser = await db.Users.FirstOrDefaultAsync(user => user.UserName == User.Identity.Name);
            if (curuser.RatingCities != null)
                cities = JsonSerializer.Deserialize<List<DataCity>>(curuser.RatingCities);


            cities.Add(city);
            curuser.RatingCities = JsonSerializer.Serialize(cities);
            await db.SaveChangesAsync();
            return RedirectToAction("Index", "Cities");
        }

        /// <summary>
        /// Create City (get)
        /// </summary>
        /// <returns>View Create (form)</returns>
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// Create City (post)
        /// </summary>
        /// <param name="city"></param>
        /// <returns>Redirect to Index</returns>
        [HttpPost]
        public async Task<IActionResult> Create(DataCity city)
        {
            List<DataCity> cities = new List<DataCity>();
            User curuser = await db.Users.FirstOrDefaultAsync(user => user.UserName == User.Identity.Name);
            if (curuser.RatingCities != null)
                cities = JsonSerializer.Deserialize<List<DataCity>>(curuser.RatingCities);

            foreach (var item in cities)
            {
                while (city.Id == item.Id)
                {
                    city.Id = city.Id + 1;
                }
            }

            cities.Add(city);
            curuser.RatingCities = JsonSerializer.Serialize(cities);
            await db.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        /// <summary>
        /// Edit City
        /// </summary>
        /// <param name="id"></param>
        /// <returns>View Edit (form with value about city)</returns>
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id != null)
            {
                List<DataCity> cities = new List<DataCity>();
                User curuser = await db.Users.FirstOrDefaultAsync(user => user.UserName == User.Identity.Name);
                if (curuser.RatingCities != null)
                    cities = JsonSerializer.Deserialize<List<DataCity>>(curuser.RatingCities);

                DataCity city = cities.FirstOrDefault(p => p.Id == id);
                if (city != null)
                    return View(city);
            }
            return NotFound();
        }

        /// <summary>
        /// Edit City
        /// </summary>
        /// <param name="city"></param>
        /// <returns>View Index</returns>
        public async Task<IActionResult> Edit(DataCity city)
        {
            List<DataCity> cities = new List<DataCity>();
            User curuser = await db.Users.FirstOrDefaultAsync(user => user.UserName == User.Identity.Name);
            if (curuser.RatingCities != null)
                cities = JsonSerializer.Deserialize<List<DataCity>>(curuser.RatingCities);

            foreach (var city_ in cities)
            {
                if (city_ != null && city_.Id == city.Id)
                {
                    city_.Name = city.Name;
                    city_.Type = city.Type;
                    city_.Region = city.Region;
                    city_.Country = city.Country;
                    city_.Population = city.Population;
                    city_.Latitude = city.Latitude;
                    city_.Longitude = city.Longitude;
                }
            }
            curuser.RatingCities = JsonSerializer.Serialize(cities);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        /// <summary>
        /// Delete City
        /// </summary>
        /// <param name="id"></param>
        /// <returns>View Index without deleted city</returns>
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                List<DataCity> cities = new List<DataCity>();
                User curuser = await db.Users.FirstOrDefaultAsync(user => user.UserName == User.Identity.Name);
                if (curuser.RatingCities != null)
                    cities = JsonSerializer.Deserialize<List<DataCity>>(curuser.RatingCities);

                DataCity city = cities.FirstOrDefault(p => p.Id == id);
                if (city != null)
                {
                    cities.Remove(city);
                    curuser.RatingCities = JsonSerializer.Serialize(cities);
                    await db.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }
            return NotFound();
        }
    }
}

