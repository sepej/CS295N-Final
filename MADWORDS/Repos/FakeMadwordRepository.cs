using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MADWORDS.Models;

namespace MADWORDS.Repos
{
    public class FakeMadwordRepository : IMadwordRepository
    {
        List<Madword> madwords = new List<Madword>();

        public IQueryable<Madword> Madwords
        {
            get { return madwords.AsQueryable<Madword>(); }
        }


        public void AddMadword(Madword madword)
        {
            madword.MadwordID = madwords.Count;
            madwords.Add(madword);
        }

        public Madword GetMadwordByTitle(string title)
        {
            throw new NotImplementedException();
        }
    }
}
