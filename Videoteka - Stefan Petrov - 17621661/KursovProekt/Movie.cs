using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovProekt
{
    class Movie
    {
        private int Id;
        private string MovieTitle;
        private int Year;
        private string Director;
        private string Country;
        private int NumberOfCopies;
        private float RentForWeek;

        public Movie(int id, string movieTitle, int year, string director, string country, int numberOfCopies, float rentForWeek)
        {
            Id = id;
            MovieTitle = movieTitle;
            Year = year;
            Director = director;
            Country = country;
            NumberOfCopies = numberOfCopies;
            RentForWeek = rentForWeek;
        }
        public int GetId()
        {
            return Id;
        }
        public string GetMovieTitle()
        {
            return MovieTitle;
        }
        public int GetYear()
        {
            return Year;
        }
        public string GetDirector()
        {
            return Director;
        }
        public string GetCountry()
        {
            return Country;
        }
        public int GetNumberOfCopies()
        {
            return NumberOfCopies;
        }
        public float GetRentForWeek()
        {
            return RentForWeek;
        }
        public void SetId(int id)
        {
            Id = id;
        }
        public void SetMovieTitle(string movietitle)
        {
            MovieTitle = movietitle;
        }
        public void SetYear(int year)
        {
            Year = year;
        }
        public void SetDirector(string director) 
        {
            Director = director;
        }
        public void SetCountry(string country)
        {
            Country = country;
        }
        public void SetNumberOfCopies(int num)
        {
            NumberOfCopies = num;
        }
        public void SetRentForWeek(float rent)
        {
            RentForWeek = rent;
        }
    }
}
