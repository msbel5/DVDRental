﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DVDRental.Models;
using System.Web.Mvc;
using DVDRental.Dtos;

namespace DVDRental.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        public IHttpActionResult CreateNewRental(NewRentalDto newRental )
        {

            if (newRental.MovieIds.Count == 0)
                return BadRequest("No movie Ids have been given.");

            var customer = _context.Customers.SingleOrDefault(c => c.Id == newRental.CustomerId);

            if (customer == null)
                return BadRequest("CustomerId is not valid.");

            var movies = _context.Movies.Where(m => newRental.MovieIds.Contains(m.Id)).ToList();

            if (movies.Count!= newRental.MovieIds.Count)
            {
                return BadRequest("One or more MovieIds are invalid.");
            }


            foreach (var movie in movies)
            {
                if (movie.NumberAvailable==0)
                {
                    return BadRequest("Movie is not available.");
                }

                movie.NumberAvailable--;

                var rental = new Rental {Customer = customer, Movie = movie, DateRented = DateTime.Now};

                _context.Rentals.Add(rental);
            }

            _context.SaveChanges();

            return Ok();

        }
    }
}
