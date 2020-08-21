using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject winText;
    public GameObject Button;
    public GameObject loseText;
    public GameObject timer;
    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        //SceneManager.UnloadSceneAsync("Start Menus");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void scoreUp()
    {
        score++;
        if(score >= 4)
        {
            win();
        }
    }

    void win()
    {
        winText.SetActive(true);
        Button.SetActive(true);
         timer.GetComponent<Timer>().stop();
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }

    public void lose()
    {
        loseText.SetActive(true);
        Button.SetActive(true);
        timer.SetActive(false);
        timer.GetComponent<Timer>().stop();
    }
}
