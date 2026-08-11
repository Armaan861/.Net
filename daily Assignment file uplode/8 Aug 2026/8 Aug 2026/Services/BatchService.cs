using _8_Aug_2026.Data;
using _8_Aug_2026.Models;
using _8_Aug_2026.Repository;
using System.Reflection.Metadata.Ecma335;

namespace _8_Aug_2026.Services
{
    public class BatchService : IBatchService
    {
        private readonly AppDbContext appDbContext;
        public BatchService (AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        Batch IBatchService.Addbatch(Batch batch)
        {
            appDbContext.Batches.Add(batch);
            appDbContext.SaveChanges();
            return batch;
        }
        

        Batch IBatchService.DeleteBatch(int id)
        {
            var Batch = appDbContext.Batches.Find(id);
            if(Batch != null)
            {
                appDbContext.Batches.Remove(Batch);
                appDbContext.SaveChanges();
            }
            return Batch;
        }

        List<Batch> IBatchService.GetBatchs()
        {
            return appDbContext.Batches.ToList();
        }

        Batch IBatchService.UpdateBatch(int id, Batch batch)
        {
            var exesting = appDbContext.Batches.Find(id);
            if (exesting != null) 
            {
                appDbContext.Entry(exesting).CurrentValues.SetValues(batch);
                appDbContext.SaveChanges();
            }
            return batch;
        }
    }
}
