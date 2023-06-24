using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupPlacementHolder : MonoBehaviour
{
    public bool Filled;

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
        if(other.CompareTag("Cup"))
        {
            Filled = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Cup"))
        {
            Filled = false;
        }
    }
}
