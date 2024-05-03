using TTRPGCharacterSheet.Enums;

namespace TTRPGCharacterSheet.Models
{
    public class CharacterAttributesModel
    {
        public AbilitiesGenerationMode Mode { get; set; } = AbilitiesGenerationMode.StandartArray;
        public List<CharacterAttributeModel> Attributes { get; set; }
    }

    public class CharacterAttributeModel
    {
        public CharacterAttribute? Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
    }
}
