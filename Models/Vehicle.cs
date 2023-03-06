namespace SD_330_Demos.Models
{
    public class Vehicle
    {
        /*Id for Primary Key*/
        public int Id { get; set; } 
        public string VehicleModel { get; set; }

        public DateTime Year { get; set; }

        /*Refers to object Customer*/
        public Customer Customer { get; set; }

        /*Refers to Foreng Key */
        public int CustomerId { get; set; }

        // many-to-one
        // many vehicles can belong to one brand

        public Brand Brand { get; set; }   
        public int BrandId { get; set; }
        public Vehicle()
        { 
        
        }
    }
}
