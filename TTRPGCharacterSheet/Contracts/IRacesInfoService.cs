using TTRPGCharacterSheet.Models;

namespace TTRPGCharacterSheet.Contracts
{
    public interface IRacesInfoService
    {
        Task<List<Race>> GetAvailableRacesListAsync();
        Task<Race> GetRaceDetailsAsync(int raceId);

    }
}
