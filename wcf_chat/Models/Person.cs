namespace Wcf.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string Patronymic { get; set; } = string.Empty;
        public string DateOfBirth { get; set; } = string.Empty;
        public int Phone { get; set; }
        public string City { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public int House { get; set; }
        public int? Room { get; set; }
        // а как ходить без костылей?
        public string Address 
        { get
            {
                return  $"г.{City} ул. {Street} д.{House} {Room}";
            }
            set
            {

            }
        } 
    }
}
