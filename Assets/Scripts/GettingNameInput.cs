using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GettingNameInput : MonoBehaviour
{
    public string m_PlayerName;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        m_PlayerName = PlayerPrefs.GetString("name", "No Name");
    }

    void OnGUI()
    {
        //Fetch the PlayerPrefs settings and output them to the screen using Labels
        GUI.Label(new Rect(50, 50, 200, 30), "Name: " + m_PlayerName);
    }
}
