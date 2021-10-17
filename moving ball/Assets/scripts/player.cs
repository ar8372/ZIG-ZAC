using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    player instance;
    
    Rigidbody rb;
    public bool gameover;
    
    [SerializeField]
    int speed;
    int a = 0;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        rb = gameObject.GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Start()
    {
        gameover = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, Vector3.down, Color.red);
        if(!Physics.Raycast(transform.position, Vector3.down, 1f))
        {
            gameover = true;
            rb.velocity = new Vector3(0, -20f, 0);
            gameManager.instance.gameover();
            score.instance.cancelinvokescore();
        }
        if (Input.GetMouseButtonDown(0)&& !gameover)
        {
            gameManager.instance.startgame();

            if (a == 0)
            {
                movex();

            }
            else if (a == 1)
            {
                movez();
            }
        }
    }
    void movex()
    {
        rb.velocity = new Vector3(speed, 0, 0);
        a = 1;
    }
    void movez()
    {
        rb.velocity = new Vector3(0,0,speed);
        a = 0;
    }
    
}
