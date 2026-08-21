using _8_Aug_2026.Models;

namespace _8_Aug_2026.Repository
{
    public interface IBatchService
    {
        List<Batch> GetBatchs();
        Batch Addbatch(Batch batch);
        Batch UpdateBatch(int id ,Batch batch);
        Batch DeleteBatch(int id);

    }
}
