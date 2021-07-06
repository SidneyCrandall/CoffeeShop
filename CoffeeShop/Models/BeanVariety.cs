/*This Mocel was copied from the chapter
    This model is used to label the data for our app*/

using System.ComponentModel.DataAnnotations;

namespace CoffeeShop.Models
{
    public class BeanVariety
    {
        public int Id { get; set; }

        // When a form of any kind is requested Inforomation will need to be filled in. 
        // Thi Required ensures that a user inputs the correct data to be accept by the serve
        [Required]
        // This is the parameter foe that input. It must be at 3 characters long but no longer that 50
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        // Similar to above 
        [Required]
        [StringLength(255, MinimumLength = 3)]
        public string Region { get; set; }

        // Notes are not required for entry into the database.
        // This means that a user can leave this blank and continue on
        public string Notes { get; set; }
    }
}
