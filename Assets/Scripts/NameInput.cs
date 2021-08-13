using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class NameInput : MonoBehaviour
{
    public static NameInput nameInput;

    public InputField inputField;

    public string nameOfPlayer;

    public Text inputText;
    public Text loadedName;

    private void Update()
    {
        nameOfPlayer = PlayerPrefs.GetString(name);
        loadedName.text = nameOfPlayer;
    }


    public void SetName()
    {
        PlayerPrefs.SetString("name", inputText.text);
        PlayerPrefs.Save();
    }


    public void StartGame()
    {
        SceneManager.LoadScene("main");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
