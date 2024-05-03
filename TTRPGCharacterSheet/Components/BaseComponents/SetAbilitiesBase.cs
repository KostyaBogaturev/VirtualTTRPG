using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System.Collections.Generic;
using TTRPGCharacterSheet.Enums;
using TTRPGCharacterSheet.Models;

namespace TTRPGCharacterSheet.Components.BaseComponents
{
    public abstract class SetAbilitiesBase : ComponentBase, IDisposable
    {
        protected EditContext? editContext;
        protected ValidationMessageStore? messageStore;
        protected const string abilitiesFormName = "AbilitiesForm";

        protected Dictionary<string, CharacterAttribute> abilityToName = new()
        {
            {"Strength", CharacterAttribute.Strength},
            {"Dexterity", CharacterAttribute.Dexterity},
            {"Constitution", CharacterAttribute.Constitution},
            {"Intelligence", CharacterAttribute.Intelligence},
            {"Wisdom", CharacterAttribute.Wisdom},
            {"Charisma", CharacterAttribute.Charisma}
        };

        public abstract AbilitiesGenerationMode GenerationMode { get; }

        [Parameter]
        public CharacterAttributesModel CharacterAttributes { get; set; }

        [SupplyParameterFromForm]
        protected CharacterAttributesModel CharacterAttributesFormModel { get; set; }


        protected sealed override void OnInitialized()
        {
            CharacterAttributesFormModel = CharacterAttributes;

            if (GenerationMode != CharacterAttributesFormModel.Mode)
                ResetAttributes();

            CharacterAttributesFormModel.Mode = CharacterAttributes.Mode = GenerationMode;

            editContext = new(CharacterAttributesFormModel);
            editContext.OnValidationRequested += HandleValidationRequested;
            messageStore = new(editContext);

            OnInitializeTemplate();
        }

        protected void ResetAttributes()
        {
            CharacterAttributesFormModel.Attributes = new();
            foreach (CharacterAttribute item in Enum.GetValues(typeof(CharacterAttribute)))
                CharacterAttributesFormModel.Attributes.Add(new CharacterAttributeModel { Id = item, });
        }

        protected void ApplyAttributes()
        {
        }

        protected abstract void HandleValidationRequested(
            object? sender,
            ValidationRequestedEventArgs args);

        protected virtual void OnInitializeTemplate() { }

        public void Dispose()
        {
            if (editContext is not null)
                editContext.OnValidationRequested -= HandleValidationRequested;
        }
    }
}
