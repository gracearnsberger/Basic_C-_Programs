using CarInsurance.Models;
using CarInsurance.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace CarInsurance.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CalculateQuote(string firstName, string lastName, string emailAddress, 
                                            string dOB, string dUI, string coverage, int speedingTicket,
                                            string carYear, string carMake, string carModel)
        {
            //redirects user to the error page if the values they enter are null or empty
            if(string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress) ||
                string.IsNullOrEmpty(dOB) || string.IsNullOrEmpty(dUI) || string.IsNullOrEmpty(coverage) ||
                string.IsNullOrEmpty(carYear) || string.IsNullOrEmpty(carMake) || string.IsNullOrEmpty(carModel))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                using(InsuranceEntities db = new InsuranceEntities())
                {
                    //set up vars 
                    DateTime Today = DateTime.Today;
                    int Year = Convert.ToInt32(Today.Year);
                    int birthYear = Convert.ToInt32(dOB);
                    int age = Year - birthYear;
                    int carsYear = Convert.ToInt32(carYear);
                    int quote;

                    //start with a base of $50/month
                    int startQuote = 50;

                    //if the user is 18 and under, add $100 to monthly total
                    if (age < 18 || age == 18)
                    {
                        startQuote += 100;
                    }

                    //if the user is between 19 and 25, add $50 to monthly total
                    else if (age > 19 && age < 25 || age == 25 || age == 19)
                    {
                        startQuote += 50;
                    }

                    //if the user is over 25, add $25 to monthly total
                    else if (age > 25)
                    {
                        startQuote += 25;
                    }

                    //if the car's year is before 2000, add $25 to monthly total
                    //if the car's year is after 2015, add $25 to monthly total
                    if (carsYear < 2000 || carsYear > 2015)
                    {
                        startQuote += 25;
                    }

                    //if the car's Make is a Porsche, add $25 to the price
                    //if the car's Make is a Porsche and its model is a 911 Carrera, add an additional $25 
                    if (carMake == "Porsche" || carMake == "porsche" && carModel == "911 Carrera")
                    {
                        if (carMake == "Porsche" || carMake == "porsche")
                        {
                            startQuote += 25;
                        }
                        startQuote += 50;
                    }

                    //add $10 to monthly total for every speeding ticket the user has
                    if (speedingTicket > 0)
                    {
                        startQuote += 10 * speedingTicket;
                    }

                    //if the user has ever had a DUI, add 25% to the total
                    if (dUI == "Yes" || dUI == "yes" || dUI == "Yeah" || dUI == "yeah")
                    {
                        startQuote = Convert.ToInt32(startQuote * 1.25);
                    }

                    //If it's full coverage, add 50% to the total
                    if (coverage == "Full Coverage" || coverage == "full coverage" ||
                        coverage == "Full coverage" || coverage == "full Coverage")
                    {
                        startQuote = Convert.ToInt32(startQuote * 1.5);
                    }

                    //calculate quote and add to database
                    quote = startQuote;

                    var quotes = new Quote();
                    quotes.FirstName = firstName;
                    quotes.LastName = lastName;
                    quotes.EmailAddress = emailAddress;
                    quotes.DOB = dOB;
                    quotes.DUI = dUI;
                    quotes.Coverage = coverage;
                    quotes.SpeedingTicket = speedingTicket;
                    quotes.CarYear = carYear;
                    quotes.CarMake = carMake;
                    quotes.CarModel = carModel;
                    quotes.Quote1 = Convert.ToString(quote);

                    db.Quotes.Add(quotes);
                    db.SaveChanges();

                }
                return View("Quote");
            }
        }

        //create an Admin view for a site administrator. this page must:
        //show all quotes issued, along with the user's first name, last name, and email address.
        public ActionResult Admin()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var quotes = db.Quotes;
                var adminQuotesVm = new List<AdminVm>();
                foreach (var user in quotes)
                {
                    var adminquote = new AdminVm();
                    adminquote.FirstName = user.FirstName;
                    adminquote.LastName = user.LastName;
                    adminquote.EmailAddress = user.EmailAddress;
                    adminquote.Quote = user.Quote1;
                    adminQuotesVm.Add(adminquote);
                }
                return View(adminQuotesVm);
            }
        }
    }
}