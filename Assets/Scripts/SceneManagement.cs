using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor;
using UnityEngine.SceneManagement;


public class SceneManagement : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public string constPlayerName;
    public static SceneManagement Instance;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        nameText.text = ("Welcome: " + constPlayerName + "!");
    }
    public void ExitApp()
    {
        Application.Quit();
    }
    public void StartApp()
    {
        SceneManager.LoadScene(1);
    }
    public void ReadStringInput(string name)
    {
        constPlayerName = name;
        Debug.Log("your name is: " + constPlayerName);
    }
}
