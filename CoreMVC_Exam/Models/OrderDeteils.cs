using System.ComponentModel.DataAnnotations;

namespace CoreMVC_Exam.Models
{
    public class OrderDeteils
    {
        [Key]
        public string IdOrder { get; set; }

        public string? IdProduct { get; set; }

        public string? Brand { get; set; }

        public string? IdClient { get; set; }

        public string? ClientName { get; set; }

        public string? StartDate { get; set; }

        public string? EndDate { get; set; }

        public string? Price { get; set; }
    }
}
