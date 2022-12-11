using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    bool isPaused;

    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
        isPaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused == false)
            {
                pauseMenu.SetActive(true);
                isPaused = true;
            }
            else
            {
                pauseMenu.SetActive(false);
                isPaused = false;
            }
            
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void BackButton()
    {
        pauseMenu.SetActive(false);    
        isPaused = false;
    }

}
