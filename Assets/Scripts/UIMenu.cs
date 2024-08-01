using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIMenu : MonoBehaviour
{
    public static TMP_InputField playerName;
    // Start is called before the first frame update
    void Start()
    {
        playerName = GameObject.Find("UsernameInputField").GetComponent<TMP_InputField>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerName.text.Length > 0 && playerName.text != "Enter username...")
        {
            playerName.targetGraphic.color = Color.white;
        }
    }

    public void StartGame()
    {
        if(playerName.text.Length > 0 && playerName.text != "Enter username...")
        {
            DontDestroyOnLoad(playerName); 
            SceneManager.LoadScene(1);
        }else
        {
            Debug.Log("Please enter a name");
            playerName.targetGraphic.color = Color.red;
        }
    }

    public void ExitGame()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
