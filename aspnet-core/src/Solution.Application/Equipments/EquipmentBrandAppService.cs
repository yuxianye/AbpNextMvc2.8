using System;
using Solution.Permissions;
using Solution.Equipments.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Solution.Equipments
{
    public class EquipmentBrandAppService : CrudAppService<EquipmentBrand, EquipmentBrandDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateEquipmentBrandDto, CreateUpdateEquipmentBrandDto>,
        IEquipmentBrandAppService
    {
        protected override string GetPolicyName { get; set; } = SolutionPermissions.Equipments.Default;
        protected override string GetListPolicyName { get; set; } = SolutionPermissions.Equipments.Default;
        protected override string CreatePolicyName { get; set; } = SolutionPermissions.Equipments.Create;
        protected override string UpdatePolicyName { get; set; } = SolutionPermissions.Equipments.Update;
        protected override string DeletePolicyName { get; set; } = SolutionPermissions.Equipments.Delete;

        public EquipmentBrandAppService(IRepository<EquipmentBrand, Guid> repository) : base(repository)
        {
        }
    }
}