namespace SD_330_Demos.Models
{
    public class Brand
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        // one-to-many
        // one brands has many vehicles

        public HashSet<Vehicle> Vehicles = new HashSet<Vehicle>();

    }
}
