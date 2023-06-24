using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandRayCast : MonoBehaviour
{
    public Transform Crossheir;
    public LayerMask Lmask;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position,transform.forward, out hit, 1000,Lmask))
        {
            if(hit.collider!=null)
            {
                Crossheir.position = hit.point;
            }
        }
    }
}
