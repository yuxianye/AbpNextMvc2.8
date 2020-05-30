using System;
using Solution.Permissions;
using Solution.Enterprises.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Solution.Enterprises
{
    public class EnterpriseWorkCenterAppService : CrudAppService<EnterpriseWorkCenter, EnterpriseWorkCenterDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateEnterpriseWorkCenterDto, CreateUpdateEnterpriseWorkCenterDto>,
        IEnterpriseWorkCenterAppService
    {
        protected override string GetPolicyName { get; set; } = SolutionPermissions.Enterprises.Default;
        protected override string GetListPolicyName { get; set; } = SolutionPermissions.Enterprises.Default;
        protected override string CreatePolicyName { get; set; } = SolutionPermissions.Enterprises.Create;
        protected override string UpdatePolicyName { get; set; } = SolutionPermissions.Enterprises.Update;
        protected override string DeletePolicyName { get; set; } = SolutionPermissions.Enterprises.Delete;

        public EnterpriseWorkCenterAppService(IRepository<EnterpriseWorkCenter, Guid> repository) : base(repository)
        {
        }
    }
}