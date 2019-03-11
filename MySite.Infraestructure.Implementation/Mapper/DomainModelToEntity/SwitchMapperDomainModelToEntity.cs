using System;

namespace MySite.Infraestructure.Implementation.Mapper.DomainModelToEntity
{
    public static class SwitchMapperDomainModelToEntity
    {
        public static Mapper GetMapperFor(DomainModelToEntityEnum name, params object[] interfaces)
        {
            switch (name)
            {
                case DomainModelToEntityEnum.ProductDomainModelToEntity:
                    return new DomainProductModelToProductEntity();
                default:
                    throw new NotImplementedException(string.Format("Missing mapper for {0} in MySite.Infraestructure.Implementation.Mapper.DomainModelToEntity.SwitchMapperDomainModelToEntity ", name.ToString()));
            }          
        }
    }
}
