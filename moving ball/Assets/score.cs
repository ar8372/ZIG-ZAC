using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour
{
    public int Score = 0;
    public int highestscore;
    public static score instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Score", Score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void increamentscore()
    {
        Score =Score+1;
    }
    public void invokeincreamentscore()
    {
        InvokeRepeating("increamentscore", .1f, 1f);
    }
    public void cancelinvokescore()
    {
        CancelInvoke("increamentscore");
        PlayerPrefs.SetInt("Score", Score);
        if (PlayerPrefs.HasKey("highestscore"))
        {
            if (Score > PlayerPrefs.GetInt("highestscore"))
            {
                PlayerPrefs.SetInt("highestscore", Score);
            }
            else
            {
                
            }
            
        }
        else
        {
            PlayerPrefs.SetInt("highestscore", Score);
        }

    }

}
