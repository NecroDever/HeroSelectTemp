using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CharacterListEntryController
{
    Label NameLabel;

    public void SetVisualElement(VisualElement visualElement)
    {
        NameLabel = visualElement.Q<Label>("character-name");
    }

    public void SetCharacterData(CharacterData characterData)
    {
        NameLabel.text = characterData.CharacterName;
    }
}