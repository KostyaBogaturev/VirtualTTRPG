namespace TTRPGCharacterSheet.Models
{
    public class CharapterInfoModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Race Race { get; set; }
        public CharapterClass CharapterClass { get; set; }
        public List<AbilityInfo> Abilities { get; set; }

    }

    public class CharapterClass
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class Race
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
