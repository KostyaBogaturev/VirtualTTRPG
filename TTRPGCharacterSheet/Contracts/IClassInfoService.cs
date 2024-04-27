using TTRPGCharacterSheet.Models;

namespace TTRPGCharacterSheet.Contracts
{
    public interface IClassInfoService
    {
        Task<List<CharapterClass>> GetAvailableClassesListAsync();
        Task<CharapterClass> GetClassDetailsAsync(int classId);
    }
}
