using TTRPGCharacterSheet.Contracts;
using TTRPGCharacterSheet.Models;

namespace TTRPGCharacterSheet.Services
{
    public class ManageCharapterService : IManageCharapterService
    {
        public Task CreateCharapter(CharapterInfoModel charapterInfo)
        {
            return Task.FromResult(0);
        }

        public Task DeleteCharapter(CharapterInfoModel charapterInfo)
        {
            throw new NotImplementedException();
        }

        public Task EditCharapter(CharapterInfoModel charapterInfo)
        {
            throw new NotImplementedException();
        }
    }
}
