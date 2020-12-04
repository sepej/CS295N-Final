using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MADWORDS.Models;

namespace MADWORDS.Repos
{
    public interface IMadwordRepository
    {
        IQueryable<Madword> Madwords { get; }  // Read (or retrieve) madwords
        void AddMadword(Madword madword);  // Create a madword
        Madword GetMadwordByTitle(string title);  // Retrieve a particular madword
    }
}