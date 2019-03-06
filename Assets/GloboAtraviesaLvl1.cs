using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GloboAtraviesaLvl1 : MonoBehaviour
{
    // Start is called before the first frame update

    public Collider2D col;
    public Collider2D colKaze;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(col.IsTouching(colKaze))
        {
                col.isTrigger = true;
        }
        
    }


}
