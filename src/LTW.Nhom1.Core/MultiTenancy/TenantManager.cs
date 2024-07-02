using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using LTW.Nhom1.Authorization.Users;
using LTW.Nhom1.Editions;

namespace LTW.Nhom1.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}
