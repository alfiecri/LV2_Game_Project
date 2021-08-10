
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCabinet : MonoBehaviour
{
    public float cabinetHP = 5;

    // Start is called before the first frame update
    public void TakeDamage(float amount)
    {
        cabinetHP -= amount;
        if (cabinetHP <= 0)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        Destroy(col.gameObject);
    }

    void OnTriggerEnter()
    {
        Destroy(gameObject);
    }

}
    
