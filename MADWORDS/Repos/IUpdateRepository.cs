using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MADWORDS.Models;

namespace MADWORDS.Repos
{
    public interface IUpdateRepository
    {
        IQueryable<Update> Updates { get; }  // Read (or retrieve) updates
        void AddUpdate(Update update);  // Create an update
        Update GetUpdateByTitle(string title);  // Retrieve a particular update
    }
}