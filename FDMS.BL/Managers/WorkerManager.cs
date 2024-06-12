using FDMS.BL.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDMS.Model.Entities
{
    public class WorkerManager
    {
        // Mock api data
        public static ObservableCollection<Worker> Workers = new ObservableCollection<Worker>()
        {
            new Worker(1, "Скворцов Александр", "alex@gmail.com"),
            new Worker(2, "Вилисов Михаил Юрьевич", "mx123@gmail.com"),
            new Worker(3, "Гаденко Владислав Владимирович", "glavgad@gmail.com"),
            new Worker(4, "Климов Петр Михайлович", "tsar777@gmail.com"),
            new Worker(5, "Андропов Алексей Андреевич", "alexgeometry@gmail.com"),
            new Worker(6, "Бобровский Дмитрий Львович", "notkurwajustbober@gmail.com"),
            new Worker(7, "Репин Евгений Федерович", "repagen@gmail.com"),
            new Worker(8, "Седокина Алина", "salina086@gmail.com"),
        };

        public static void AddWorker(string name, string email) 
        { 
            var id = Workers.Count() + 1;
            var worker = new Worker(id, name, email);
            Workers.Add(worker);
        }

        
    }
}
