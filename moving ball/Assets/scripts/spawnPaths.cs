using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPaths : MonoBehaviour
{
    public GameObject diamond;
    public GameObject path;

    public GameObject p;
    player over;

    float pathsize;
    Vector3 initialpos;

    public static spawnPaths instance;

    
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }

        pathsize = transform.localScale.x;
        for(int i = 0; i < 10; i++)
        {
            spawn();
        }
    }
    private void Awake()
    {
       
        over = p.GetComponent<player>();

       
    }

    public void invokesp()
    {
        InvokeRepeating("spawn", 2f, .3f);
    }

    // Update is called once per frame
    void Update()
    {
        if (over.gameover)
        {
            CancelInvoke("spawn");
        }
        
        //spawn();
    }

    private void spawn()
    {
        initialpos = transform.position;

        int rand = Random.Range(0, 6);
        if (rand < 3)
        {
            //spawnx();
            initialpos = new Vector3(initialpos.x + pathsize, initialpos.y, initialpos.z);
            Instantiate(path, initialpos, Quaternion.identity);
            transform.position = initialpos;
            int ran = Random.Range(0, 10);
            if (ran < 2)
            {
                Vector3 a = transform.position;
                Instantiate(diamond, new Vector3(a.x,a.y+1,a.z), diamond.transform.rotation);
            }
        }
        else if (rand >= 3)
        {
            //spawnz();
            initialpos = new Vector3(initialpos.x , initialpos.y, initialpos.z + pathsize);
            Instantiate(path, initialpos, Quaternion.identity);
            transform.position = initialpos;
            int ran = Random.Range(0, 10);
            if (ran<2)
            {
                Vector3 a = transform.position;
                Instantiate(diamond, new Vector3(a.x, a.y + 1, a.z), diamond.transform.rotation);
            }
        }
    }

   
}
