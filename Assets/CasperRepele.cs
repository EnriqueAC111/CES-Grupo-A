using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CasperRepele : MonoBehaviour
{
    // Start is called before the first frame update
    
    PointEffector2D pe;
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
        pe = GetComponent<PointEffector2D>();
        pe.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        pe.enabled = true;
        anim.SetBool("Tocado", true);
        Debug.Log("TOOOOOOCAO");
    }

    private void OnMouseUp()
    {
        pe.enabled = false;
        anim.SetBool("Tocado", false);
    }
}
