using System.Collections.Generic;

namespace FDMS.BL.Entities
{
    public class Position
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public List<Worker> Workers { get; set; }
    }
}
