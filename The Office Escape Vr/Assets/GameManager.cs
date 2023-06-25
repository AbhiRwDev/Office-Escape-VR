using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public CupPlacementHolder[] holders;
    public bool IsDoorUnlocked = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!IsDoorUnlocked)
        {
            bool Allcupsfilled = true;
            foreach (var item in holders)
            { 
                
                if(!item.Filled)
                {
                    Allcupsfilled = false;
                    break;
                }
               
            }
            IsDoorUnlocked = Allcupsfilled;
        }
        
    }
}
