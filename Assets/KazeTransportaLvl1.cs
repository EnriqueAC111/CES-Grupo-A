using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KazeTransportaLvl1 : MonoBehaviour
{
    // Start is called before the first frame update

    HingeJoint2D hj;
    public Rigidbody2D rbTuerca;
    Animator anim;
    void Start()
    {
       hj = GetComponent<HingeJoint2D>(); 
       anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(hj.connectedBody == rbTuerca )
        {
            anim.SetBool("TuercaCogida", true);
        }
        
    }
}
