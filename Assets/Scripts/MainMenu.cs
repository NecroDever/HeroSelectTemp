using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    VisualTreeAsset ListEntryTemplate;

    void OnEnable()
    {
        // The UXML is already instantiated by the UIDocument component
        UIDocument uiDocument = GetComponent<UIDocument>();

        // Initialize the character list controller
        CharacterListController characterListController = new CharacterListController();
        characterListController.InitializeCharacterList(uiDocument.rootVisualElement, ListEntryTemplate);
    }
}
