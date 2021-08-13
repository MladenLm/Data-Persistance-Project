using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor;
#if UNITY_EDITOR
#endif

public class Menu : MonoBehaviour
{
    public InputField nameInput;

    public void StartGame()
    {
        SceneManager.LoadScene("main");
        SaveManger.Instance.playerName = nameInput.text;
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
