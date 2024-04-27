using TTRPGCharacterSheet.Contracts;
using TTRPGCharacterSheet.Models;

namespace TTRPGCharacterSheet.Services
{
    public class ClassInfoService : IClassInfoService
    {
        private List<CharacterClass> classes = new List<CharacterClass>
        {
            new CharacterClass { Id = 1, Name = "Wizard", Description = "Wizard" },
            new CharacterClass { Id = 2, Name = "Rogue", Description = "Rogue" },
            new CharacterClass { Id = 3, Name = "Paladin", Description = "Paladin" }
        };

        public Task<List<CharacterClass>> GetAvailableClassesListAsync()
        {
            return Task.FromResult(classes);
        }

        public Task<CharacterClass> GetClassDetailsAsync(int classId)
        {
            return Task.FromResult(classes.FirstOrDefault(c=>c.Id == classId));
        }
    }
}

