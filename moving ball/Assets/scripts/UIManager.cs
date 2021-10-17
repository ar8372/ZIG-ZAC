using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text scoreS;
    public Text scoreSS;
    public Text highscore;

    public GameObject gameoverpanel;
    public GameObject fallingpanel;
    public GameObject restartbutton;
    public GameObject exitbutton;

    public GameObject gamestartpanel;
    public GameObject taptoPlay;
    public static UIManager instance;
    int i = 0;
    private void Awake()
    {
        //UIManager instance;
        if (instance == null)
        {
            instance = this;
        }

        scoreS.text = PlayerPrefs.GetInt("highestscore").ToString();
    }
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        //scoreS.text = score.instance.Score.ToString();
        //scoreSS.text = score.instance.Score.ToString();
        //highscore.text = score.instance.highestscore.ToString();
    }
    public void gamestart()
    {
        
        taptoPlay.SetActive(false);
        // when we want to make it stop at some frame in between and not make it invisible ...taptoPlay.GetComponent<Animator>().enabled = false;
        gamestartpanel.GetComponent<Animator>().Play("Up");
       
    }
    public void gameover()
    {
        highscore.text = PlayerPrefs.GetInt("highestscore").ToString();
        scoreSS.text = PlayerPrefs.GetInt("Score").ToString();
        Invoke("invokegameoverpanel", .2f);
       // was popping very early...gameoverpanel.SetActive(true);
        fallingpanel.SetActive(true);
        restartbutton.SetActive(true);
        exitbutton.SetActive(true);
    }
    public void restart()
    {
        SceneManager.LoadScene(0);
    }
    public void exitgame()
    {
        Application.Quit();
    }
    void invokegameoverpanel()
    {
        gameoverpanel.SetActive(true);
    }
}
