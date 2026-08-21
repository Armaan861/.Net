using _4_July_2026__HW01_.Model;

namespace _4_July_2026__HW01_.Repository
{
    public interface ICourceService
    {
        List<Cource> GetAllCources();
        Cource GetCource(int id);
        Cource AddCource(Cource cource);
        Cource UpdateCource(int id, Cource cource);
        Cource DeleteCource(int id);
    }
}
