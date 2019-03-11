using MySite.Infraestructure.Implementation.Entities;
using System;

namespace MySite.Infraestructure.Implementation.Mapper.EntityToDomainModel
{
    public class ProductEntityToDomainDomainProductModel : Mapper
    {
        public override TOutput Get<TInput, TOutput>(TInput source)
        {
            var entity = source as Product;
            if (entity == null) { throw new InvalidCastException("Cast to type  MySite.Infraestructure.Implementation.Entities.Product has fail."); }

            return new Domain.Contracts.Models.Product {
                Category=entity.Category,
                Description=entity.Description,
                Id=entity.Id,
                ImageData=entity.ImageData,
                ImageMimeType=entity.ImageMimeType,
                Name=entity.Name,
                Price=entity.Price
            } as TOutput;          
        }
    }
}
