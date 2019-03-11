using MySite.Domain.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySite.Domain.Contracts.Infraestructure
{
    public interface IIgorBookInfoRetriever
    {
        IEnumerable<Book> getBestSellerBooks(int count);
    }
}
