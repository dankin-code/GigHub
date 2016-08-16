using GigHub.Models;
using System.Collections.Generic;

namespace GigHub.ViewModels
{
    public class GigFormViewModel
    {
        public string Venue { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int Genre { get; set; }
        // this propery is set as an int because it will be the ID for the Genre in the database
        public IEnumerable<Genre> Genres { get; set; }
    }
}