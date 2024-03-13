using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class HighScore : MonoBehaviour
{
    public Text text;
    private int highscore = 1;
    private string name;

    // Start is called before the first frame update
    void Awake()
    {
        LoadScore();
        text.text = ("Best Score: " + name + ", " + highscore);
        Debug.Log("datra loaded and name + highscore set");
    }

    // Update is called once per frame
    void Update()
    {
        if (MainManager.Instance.m_Points > highscore)
        {
            text.text = ("Best Score: " + Data.Instance.playerName + ", " + MainManager.Instance.m_Points);
            highscore = MainManager.Instance.m_Points;
            SaveScore();
        }

    }
    [System.Serializable]
    class SaveData
    {
        public int highscore;
        public string name;
    }

    public void SaveScore()
    {
        SaveData data = new SaveData();
        data.highscore = highscore;
        data.name = Data.Instance.playerName;

        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }
    public void LoadScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if ( File.Exists(path) )
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            highscore = data.highscore;
            name = data.name;
        }
    }
}
