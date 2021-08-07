using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NameInput : MonoBehaviour
{
    public Text obj_text;
    public InputField display;

    // Start is called before the first frame update
    void Start()
    {
        
        obj_text.text = PlayerPrefs.GetString("user_name");
    }

    // Update is called once per frame
    void Update()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void Create()
    {
        DontDestroyOnLoad(gameObject);
        obj_text.text = display.text;
        PlayerPrefs.SetString("user_name", obj_text.text);
        PlayerPrefs.Save();
    }
}
