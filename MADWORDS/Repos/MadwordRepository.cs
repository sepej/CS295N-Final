using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MADWORDS.Models;
using Microsoft.EntityFrameworkCore;

namespace MADWORDS.Repos
{
    public class MadwordRepository : IMadwordRepository
    {
        private MadwordContext context;

        // constructor
        public MadwordRepository(MadwordContext c)
        {
            context = c;
        }

        public IQueryable<Madword> Madwords
        {
            get
            {
                // Get all the Madword objects in the Madwords DbSet
                // and include the Author object in each Madword.
                return context.Madwords.Include(madword => madword.Author);
            }
        }

        public void AddMadword(Madword madword)
        {
            context.Madwords.Add(madword);
            context.SaveChanges();
        }

        public Madword GetMadwordByTitle(string title)
        {
            throw new NotImplementedException();
        }
    }
}
