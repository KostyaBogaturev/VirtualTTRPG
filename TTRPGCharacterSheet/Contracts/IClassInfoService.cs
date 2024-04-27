using TTRPGCharacterSheet.Models;

namespace TTRPGCharacterSheet.Contracts
{
    public interface IClassInfoService
    {
        Task<List<CharacterClass>> GetAvailableClassesListAsync();
        Task<CharacterClass> GetClassDetailsAsync(int classId);
    }
}
