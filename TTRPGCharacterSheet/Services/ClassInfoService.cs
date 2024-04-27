using TTRPGCharacterSheet.Contracts;
using TTRPGCharacterSheet.Models;

namespace TTRPGCharacterSheet.Services
{
    public class ClassInfoService : IClassInfoService
    {
        private List<CharapterClass> classes = new List<CharapterClass>
        {
            new CharapterClass { Id = 1, Name = "Wizard", Description = "Wizard" },
            new CharapterClass { Id = 2, Name = "Rogue", Description = "Rogue" },
            new CharapterClass { Id = 3, Name = "Paladin", Description = "Paladin" }
        };

        public Task<List<CharapterClass>> GetAvailableClassesListAsync()
        {
            return Task.FromResult(classes);
        }

        public Task<CharapterClass> GetClassDetailsAsync(int classId)
        {
            return Task.FromResult(classes.FirstOrDefault(c=>c.Id == classId));
        }
    }
}

