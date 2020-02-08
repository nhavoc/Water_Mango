using PWM.Models;
using System.Data.Entity;

namespace PWM.Data
{
    public class DataContext:DbContext
    {
        public DataContext():base("PWMDatabase")    {      }

        public DbSet<Plant> Plants { get; set; }
    }
}