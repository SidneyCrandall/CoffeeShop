/*This model is used to label the data for our app and set requirements for forms*/

using System.ComponentModel.DataAnnotations;

namespace CoffeeShop.Models
{
    public class Coffee
    {
        // Users dont input an id. The ids are usually added through the server request
        public int Id { get; set; }

        // Similar to the BeanVariety Model, we need to make some required input for users
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }

        // Although this will be a name when user interact with the form,
        // We first have to use the foreign key to connect them
        public int BeanVarietyId { get; set; }

        // This is the whole entity of the bean for the coffee. We want to at least hold on to the info of the table
        public BeanVariety BeanVariety { get; set; }

    }
}
