using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public static gameManager instance;

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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void startgame()
    {
        
        UIManager.instance.gamestart();
        score.instance.invokeincreamentscore();
        spawnPaths.instance.invokesp();
    }
    public void gameover()
    {
        //Invoke("UIManager.instance.gameover()", 1f);
        UIManager.instance.gameover();
    }
}
