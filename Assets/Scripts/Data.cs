using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Data : MonoBehaviour
{
    public static Data Instance;
    public string playerName;
    // Start is called before the first frame update
    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        playerName = SceneManagement.Instance.constPlayerName;
        SceneManagement.Instance.constPlayerName = playerName;
    }
    
    
}
