using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MADWORDS.Models;

namespace MADWORDS.Repos
{
    public class FakeUpdateRepository : IUpdateRepository
    {
        List<Update> updates = new List<Update>();

        public IQueryable<Update> Updates
        {
            get { return updates.AsQueryable<Update>(); }
        }


        public void AddUpdate(Update update)
        {
            update.UpdateID = updates.Count;
            updates.Add(update);
        }

        public Update GetUpdateByTitle(string title)
        {
            throw new NotImplementedException();
        }
    }
}