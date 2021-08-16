using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    Button startButton;

    private void OnEnable()
    {
        var rootVisualElement = GetComponent<UIDocument>().rootVisualElement;

        startButton = rootVisualElement.Q<Button>("start-button");
        startButton.RegisterCallback<ClickEvent>(ev => StartGame());
    }

    private void StartGame()
    {
        SceneManager.LoadScene(1);
    }

}
