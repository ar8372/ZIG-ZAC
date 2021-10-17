using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public GameObject player;

    Vector3 playerpos;
    Vector3 camerapos;
    Vector3 difference;
    // Start is called before the first frame update
    void Start()
    {
        playerpos = player.transform.position;
        camerapos = transform.position;
        difference = playerpos - camerapos;
    }

    // Update is called once per frame
    void Update()
    {
        if (!player.GetComponent<player>().gameover)
        {
            playerpos = player.transform.position;
            Vector3 instance = playerpos - difference;
            transform.position=Vector3.Lerp(camerapos, instance, .1f);
            //camerapos = instance;
            camerapos = transform.position;
        }
        
    }
}
