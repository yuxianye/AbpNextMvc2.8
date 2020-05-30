using System;
using System.Threading.Tasks;
using Solution.Qualities;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace Solution.EntityFrameworkCore.Qualities
{
    public class QualityInspectResultRepositoryTests : SolutionEntityFrameworkCoreTestBase
    {
        private readonly IRepository<QualityInspectResult, Guid> _qualityInspectResultRepository;

        public QualityInspectResultRepositoryTests()
        {
            _qualityInspectResultRepository = GetRequiredService<IRepository<QualityInspectResult, Guid>>();
        }

        [Fact]
        public async Task Test1()
        {
            await WithUnitOfWorkAsync(async () =>
            {
                // Arrange

                // Act

                //Assert
            });
        }
    }
}
