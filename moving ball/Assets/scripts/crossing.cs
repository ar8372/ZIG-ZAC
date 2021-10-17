using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crossing : MonoBehaviour
{
    GameObject fall;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerExit(Collider a)
    {
        if (a.gameObject.tag == "pathzone")
        {
            Invoke("falling", .2f);
            //falling();
        }
    }

    private void falling()
    {
        GetComponentInParent<Rigidbody>().useGravity = true;
        GetComponentInParent<Rigidbody>().isKinematic = false;
        Destroy(transform.parent.gameObject, 2f);
    }
}
