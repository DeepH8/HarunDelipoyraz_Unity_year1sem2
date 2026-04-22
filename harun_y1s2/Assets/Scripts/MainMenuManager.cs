using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Debug.Log("Menu scene opened");
    }

    public void PlayButton()
    {
        Debug.Log("Play button pressed.");
        SceneManager.LoadScene("PlayScene");
    }
}
