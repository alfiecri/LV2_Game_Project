
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCabinet : MonoBehaviour
{
    bool PlayerCol = false;

    public GameObject Health;

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerCol = true;
        }
        else
        {
            PlayerCol = false;
        }
    }

    void OnMouseDown()
    {
        if (PlayerCol == true)
        {
            Destroy(gameObject);
            Instantiate(Health, transform.position, Quaternion.identity);
        }
    }
}
    
