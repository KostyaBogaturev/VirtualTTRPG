namespace TTRPGCharacterSheet.Models
{
    public class AbilityInfo
    {
        public string Name { get; init; }
        public int BaseValue { get; set; }
        public bool ProficiencyInSavingThrow { get; set; }
        public int SavingThrowBonus { get; set; }
        public List<Skill> Skills { get; set; }
    }

    public class Skill
    {
        public string Name { get; init; }
        public int AdditionalBonus { get; set; }
        public ProficiencyLevel Proficiency { get; set; }
    }

    public enum ProficiencyLevel
    {
        None,
        JakeOfAllTrades,
        Proficiency,
        Expertise
    }
}
