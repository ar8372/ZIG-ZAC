using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class points : MonoBehaviour
{
   public GameObject particle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "pathzone")
        {

            GameObject tod = Instantiate(particle, transform.position, Quaternion.identity);
            Destroy(gameObject);
            Destroy(tod, 1f);
        }
    }
}
