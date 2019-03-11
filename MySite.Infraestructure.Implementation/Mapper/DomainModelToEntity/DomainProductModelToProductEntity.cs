using MySite.Domain.Contracts.Models;
using System;

namespace MySite.Infraestructure.Implementation.Mapper.DomainModelToEntity
{
    public class DomainProductModelToProductEntity : Mapper
    {
        public override TOutput Get<TInput,TOutput>(TInput source)
        {
            var domainModel = source as Product;
            if (domainModel == null) { throw new InvalidCastException("Cast to type  MySite.Domain.Contracts.Models.Product has fail."); }

            return new Entities.Product {
                Id = domainModel.Id,
                Name =domainModel.Name,
                Price=domainModel.Price,
                Category=domainModel.Category,               
                Description=domainModel.Description,
                ImageData=domainModel.ImageData,
                ImageMimeType=domainModel.ImageMimeType
            } as TOutput;
           
        }
    }
}
