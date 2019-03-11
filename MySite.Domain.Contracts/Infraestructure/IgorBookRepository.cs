using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySite.Domain.Contracts.Infraestructure
{
    public class IgorBookInfoRetriever : IIgorBookInfoRetriever
    {

        private IIgorRepository _igorRepository;
        public IgorBookRepository(IIgorRepository igorRepository)
        {
            _igorRepository = igorRepository;
        }

        public IEnumerable<Book> getBestSellerBooks(int count)
        {
            _igorRepository.GetAll<MySite.Infraestructure.Implementation.Entities.Book>();
        }
    }
}
