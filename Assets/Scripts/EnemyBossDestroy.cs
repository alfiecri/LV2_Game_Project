using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBossDestroy : MonoBehaviour
{
    int bulletsAbsorbed = 12;
    int health = 25;
    int healSelf = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag==("Bullet"))
        {
            bulletsAbsorbed--;
            if (bulletsAbsorbed <= 0)
            {
                if (health <=15)
                {
                    healSelf++;
                }

                if (healSelf == 1)
                {
                    health = 25;
                }

                if (health <=0)
                {

                }
            }
        }
    }
}
