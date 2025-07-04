using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sinhxuongrong : MonoBehaviour
{
    // noi sinh ra
    //Instantiate(Obejct sinh ra, vi tri sinh ra)
    // bo demn nguoc
    float coundown;
    public float timeDuration;
    public GameObject xuongfrefabs;

    private void Start()
    {
        coundown = 1f;

    }
    private void Update()
    {
        coundown -= Time.deltaTime;// tru di 1s theo thoi gian
        if(coundown <= 0)
        {
            Instantiate(xuongfrefabs, new Vector3 ( 12f, 0, 0), Quaternion.identity );
            coundown = timeDuration;
        }
        

    }
        
     
    

    

       


}

