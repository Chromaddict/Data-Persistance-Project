using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
    public TMP_InputField playerName;
    // Start is called before the first frame update
    void Start()
    {
        playerName.text = "Enter name...";
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {

            SaveSystem.Instance.SetCurrentPlayerName(playerName.text);
            gameObject.SetActive(false);
            SceneManager.LoadScene(1);

            
        }
    }
}
