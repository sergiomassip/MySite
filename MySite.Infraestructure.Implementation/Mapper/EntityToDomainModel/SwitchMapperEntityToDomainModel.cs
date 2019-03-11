using MySite.Infraestructure.Implementation.Mapper.DomainModelToEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySite.Infraestructure.Implementation.Mapper.EntityToDomainModel
{
    public static class SwitchMapperEntityToDomainModel
    {
        public static Mapper GetMapperFor(EntityToDomainModelEnum name, params object[] interfaces)
        {
            switch (name)
            {                
                case EntityToDomainModelEnum.ProductEntityToDomainModel:
                    return new ProductEntityToDomainDomainProductModel();
                default:
                    throw new NotImplementedException(string.Format("Missing mapper for {0} in  MySite.Infraestructure.Implementation.Mapper.EntityToDomainModel.SwitchMapperDomainModelToEntity", name.ToString()));
            }
        }
    }
}
