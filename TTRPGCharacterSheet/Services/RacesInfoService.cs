using TTRPGCharacterSheet.Contracts;
using TTRPGCharacterSheet.Models;

namespace TTRPGCharacterSheet.Services
{
    public class RacesInfoService : IRacesInfoService
    {
        private List<Race> races = new List<Race>
        {
            new Race { Id = 1, Name = "Elf", Description = "Elf" },
            new Race { Id = 2, Name = "Dwarf", Description = "Dwarf" },
            new Race { Id = 3, Name = "Human", Description = "Human" }
        };

        public Task<List<Race>> GetAvailableRacesListAsync()
        {
            return Task.FromResult(races);
        }

        public Task<Race> GetRaceDetailsAsync(int raceId)
        {
            return Task.FromResult(races.FirstOrDefault(r => r.Id == raceId));
        }
    }
}

