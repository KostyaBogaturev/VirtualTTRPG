using TTRPGCharacterSheet.Models;

namespace TTRPGCharacterSheet.Contracts
{
    public interface IManageCharapterService
    {
        Task CreateCharapter(CharapterInfoModel charapterInfo);

        Task DeleteCharapter(CharapterInfoModel charapterInfo);

        Task EditCharapter(CharapterInfoModel charapterInfo);

    }
}
