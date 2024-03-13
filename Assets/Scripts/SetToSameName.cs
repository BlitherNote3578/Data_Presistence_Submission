using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class SetToSameName : MonoBehaviour
{
    private string nameToPrint;
    // Start is called before the first frame update
    void Start()
    {
        SceneManagement.Instance.ReadStringInput("Player");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
