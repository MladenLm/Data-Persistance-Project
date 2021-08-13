using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class SaveManger : MonoBehaviour
{
    public static SaveManger Instance;

    public string playerName;
    public int score;
    public string bestPlayer;
    public int highScore;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
        LoadScore();
    }
    
     [System.Serializable] class Leaderboard
    {
        public string name;
        public int score;
    }

    public void SaveScore()
    {
        Leaderboard data = new Leaderboard();
        data.name = bestPlayer;
        data.score = highScore;

        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            Leaderboard data = JsonUtility.FromJson<Leaderboard>(json);

            highScore = data.score;
            bestPlayer = data.name;
        }
    }

    public void NewHighScore()
    {
        if (score > highScore)
        {
            highScore = score;
            bestPlayer = playerName;
        }
    }
}
