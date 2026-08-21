
using _4_July_2026__HW01_.Model;
using _4_July_2026__HW01_.Repository;

namespace _4_July_2026__HW01_.Service
{
    public class CourceService : ICourceService
    {
    
        private List<Cource> cources = new List<Cource>()
        {
            new Cource { Id = 1, Name = "Mathematics", Duration = "3 months", Credits = 3 },
            new Cource { Id = 2, Name = "Physics", Duration = "4 months", Credits = 4 },
            new Cource { Id = 3, Name = "Chemistry", Duration = "2 months", Credits = 2 }
        };

        public List<Cource> GetAllCources()
        {
            return cources;
        }

        public Cource GetCource(int id)
        {
            return cources.FirstOrDefault(c => c.Id == id);
        }

        public Cource AddCource(Cource cource)
        {
            cource.Id = cources.Max(c => c.Id) + 1;
            cources.Add(cource);
            return cource;
        }

        public Cource UpdateCource(int id, Cource cource)
        {
            var existingCource = cources.FirstOrDefault(c => c.Id == id);
            if (existingCource != null)
            {
                existingCource.Name = cource.Name;
                existingCource.Duration = cource.Duration;
                existingCource.Credits = cource.Credits;
            }
            return existingCource;
        }

        public Cource DeleteCource(int id)
        {
            var cource = cources.FirstOrDefault(c => c.Id == id);
            if (cource != null)
            {
                cources.Remove(cource);
            }
            return cource;
        }
    }
}
