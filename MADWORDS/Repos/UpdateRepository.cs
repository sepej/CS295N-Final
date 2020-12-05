using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MADWORDS.Models;
using Microsoft.EntityFrameworkCore;

namespace MADWORDS.Repos
{
    public class UpdateRepository : IUpdateRepository
    {
        private UpdateContext context;

        // constructor
        public UpdateRepository(UpdateContext c)
        {
            context = c;
        }

        public IQueryable<Update> Updates
        {
            get
            {
                // Get all the Update objects in the Updates DbSet
                // and include the Title object in each Update.
                return context.Updates;
            }
        }

        public void AddUpdate(Update update)
        {
            context.Updates.Add(update);
            context.SaveChanges();
        }

        public Update GetUpdateByTitle(string title)
        {
            throw new NotImplementedException();
        }
    }
}
