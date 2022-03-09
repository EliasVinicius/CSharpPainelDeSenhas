using System.ComponentModel.DataAnnotations;

namespace ServiceDesk.API.Models
{
    public class PanelModel
    {
        public int Id { get; set; }

        [Required]
        public string ServiceDesk { get; set; }

        [Required]
        [StringLength(80)]
        public string Password { get; set; }

    }
}
