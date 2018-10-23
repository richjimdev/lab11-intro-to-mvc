using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMVCApp.Models
{
    /// <summary>
    /// Class to hold informaton about our Person of the Year
    /// </summary>
    public class TimePerson
    {
        public int Year { get; set; }
        public string Honor { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int Birth_Year { get; set; }
        public int DeathYear { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Context { get; set; }

        /// <summary>
        /// This logic will grab all People from the given years and return it as a list. It is static because it belongs to the class, not any instantiated objects.
        /// </summary>
        /// <param name="begYear">The starting year</param>
        /// <param name="endYear">The ending year</param>
        /// <returns>Returns a list of people for the given years</returns>
        public static List<TimePerson> GetPersons(int begYear, int endYear)
        {
            List<TimePerson> people = new List<TimePerson>(); //Creating a list to store results
            string path = Environment.CurrentDirectory; //Set the root to the current directory
            string newPath = Path.GetFullPath(Path.Combine(path, @"wwwroot\personOfTheYear.csv")); //combines root with the csv file in our wwwroot
            string[] myFile = File.ReadAllLines(newPath); //gets all the data from the csv file

            for (int i = 1; i < myFile.Length; i++) //iterating through the result of all data
            {
                string[] fields = myFile[i].Split(','); //Splits each person result into an array for getting all info
                people.Add(new TimePerson //adds a new TimePerson using the split array of data per person
                {
                    Year = Convert.ToInt32(fields[0]),
                    Honor = fields[1],
                    Name = fields[2],
                    Country = fields[3],
                    Birth_Year = (fields[4] == "") ? 0 : Convert.ToInt32(fields[4]),
                    DeathYear = (fields[5] == "") ? 0 : Convert.ToInt32(fields[5]),
                    Title = fields[6],
                    Category = fields[7],
                    Context = fields[8],
                });
            }

            // finally, filter out results from the entire array made from the csv file and only give back the results within the requested years.
            List<TimePerson> listofPeople = people.Where(p => (p.Year >= begYear) && (p.Year <= endYear)).ToList();
            return listofPeople; //Making those results into a list and returning that list
        }
    }
}
