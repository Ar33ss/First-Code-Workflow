using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstWorkFlow.Models
{
    public class ComicBook
    {
        public ComicBook()
        {
            Artists = new List<Artist>();

        }

        public int Id { get; set; }
        public int SeriesId { get; set; }
        public int IssueNumber { get; set; }
        public string Description { get; set; }
        public DateTime PublishedOn { get; set; }
        public decimal? AverageRating { get; set; }

        public Series Series { get; set; } // one-to-many
        public ICollection<Artist> Artists { get; set; } // many-to-many

        public string DisplayText {

            get {
                return $"{Series?.Title} #{IssueNumber}";
            }
        }
    }
}
