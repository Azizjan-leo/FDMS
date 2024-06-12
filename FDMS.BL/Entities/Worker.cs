namespace FDMS.BL.Entities
{
    public class Worker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int PositionId { get; set; }
        public Position Position { get; set; }
        
        public Worker(int id, string name, string email)
        {
            Id=id;
            Name=name;
            Email=email;
        }
    }
}
