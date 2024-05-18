using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class MenuController : MonoBehaviour
{
    public GameObject endPanel;
    
    // Start is called before the first frame update
    void Start()
    {
        //endPanel.transform.GetChild(0).GetComponent<Text>().text
        //    = "";


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartMenu()
    {
        endPanel.SetActive(false);
        TransitionScene(0);
    }
    public void WinGame()
    {
        endPanel.SetActive(true);
        endPanel.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text
            = "You Win!";
    }
    public void LoseGame()
    {
        endPanel.SetActive(true);
        endPanel.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text
            = "Game over...";
    }

    public void TransitionScene (int level)
    {
        
        SceneManager.LoadScene(level);
    }
    public void CloseGame()
    {
        // Close the application
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

}
