using System.ComponentModel.DataAnnotations;

namespace Assignment5Project.Models
{
    public class Music
    {
        //view model for music database
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Length { get; set; }
        public decimal Price { get; set; }

    }
}
