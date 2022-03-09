using System.ComponentModel.DataAnnotations;

namespace ServiceDesk.API.ViewModel
{
    public class PanelViewModel
    {
        public int Id { get; set; }

        [Required]
        public int ServiceDesk { get; set; }

        [Required]
        [StringLength(80)]
        public string Password { get; set; }

    }
}
