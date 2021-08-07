using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class NameInput : MonoBehaviour
{
    public static NameInput nameInput;

    public TMP_InputField inputField;

    public string player_name;

    private void Awake()
    {
        if (nameInput == null)
        {
            nameInput = this;
            DontDestroyOnLoad(gameObject);
        }

        else
        {
            Destroy(gameObject);
        }
    }

    public void StartGame()
    {
        player_name = inputField.text;
        SceneManager.LoadScene("main");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
