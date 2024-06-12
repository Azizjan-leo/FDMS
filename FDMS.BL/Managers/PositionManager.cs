using FDMS.BL.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDMS.BL.Managers
{
    internal class PositionManager
    {
        // Mock api data
        public static ObservableCollection<Position> Positions = new ObservableCollection<Position>()
        {
            new Position(){ Id = 1, Name = "Пожарный", Salary = 50 },
            new Position(){ Id = 2, Name = "Управляющий", Salary = 50 },
            new Position(){ Id = 3, Name = "Автослесарь", Salary = 30 },
            new Position(){ Id = 4, Name = "Повар", Salary = 30 },
            new Position(){ Id = 5, Name = "Уборщица", Salary = 25 },
            new Position(){ Id = 6, Name = "Стажер", Salary = 25 },

        };
        
        public static void AddPosition(string name, decimal salary)
        {
            var position = new Position()
            {
                Id = Positions.Count() + 1,
                Name = name,
                Salary = salary
            };
            Positions.Add(position);
        }
    }
}
