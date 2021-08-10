using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CabinetDestroy : MonoBehaviour
{
    public int cabinetHP = 5;
    public GameObject Health;
    int DamageRate = 2;

    private bool canDamage = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnHit(int damage)
    {
        RaycastHit hit;

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(GetComponent<Camera>().transform.position + GetComponent<Camera>().transform.forward, GetComponent<Camera>().transform.forward, out hit, Mathf.Infinity))
            {
                if (hit.collider.gameObject.tag.Equals("Cabinet"))
                {
                    hit.collider.gameObject.GetComponent<EnemyScript>().OnHit(DamageRate);
                }
            }
        }
    }
}
