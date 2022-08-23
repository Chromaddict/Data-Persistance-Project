using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class MainUI : MonoBehaviour
{
    public TextMeshProUGUI highScoreText;
    // Start is called before the first frame update
    void Start()
    {

        highScoreText.text = "High Score: " + SaveSystem.Instance.highScore + " Name: " + SaveSystem.Instance.playerName;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
