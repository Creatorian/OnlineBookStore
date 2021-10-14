using OnlineBookstore.Data.Entities;
using OnlineBookstore.Repositories.Repositories.Interfaces;
using OnlineBookstore.Services.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookstore.Services
{
    public class PublisherService : IPublisherService
    {
        private readonly IPublisherRepository _ipublisherRepository;

        public PublisherService(IPublisherRepository ipublisherRepository)
        {
            _ipublisherRepository = ipublisherRepository;
        }

        public void Add(Publisher publisher)
        {
            _ipublisherRepository.Add(publisher);
        }

        public void Delete(int PublisherID)
        {
            _ipublisherRepository.Delete(PublisherID);
        }

        public void Edit(Publisher publisher)
        {
            _ipublisherRepository.Edit(publisher);
        }

        public Publisher GetPublisherById(int id)
        {
            var result = _ipublisherRepository.GetPublisherById(id);
            return result;
        }

        public IEnumerable<Publisher> GetPublishers()
        {
            var result = _ipublisherRepository.GetPublishers();
            return result;
        }
    }
}
