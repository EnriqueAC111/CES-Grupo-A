using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ventilador : MonoBehaviour
{

    PointEffector2D pe;
    Animator anim;
    private Vector2 mousePosition;
    

    // Start is called before the first frame update
    void Start()
    {
        pe = GetComponent<PointEffector2D>();
        pe.enabled = false;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
     /*  void Update()
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        if((Input.GetMouseButton(0)) && (mousePosition = transform.position))
        {
        Debug.Log("tocado");
        pe.enabled = true;
        anim.SetBool("Activado", true);
        }
        if(Input.GetMouseButtonUp(0))
        {
        pe.enabled = false;
        anim.SetBool("Activado", false);
        }


    }
*/
    private void OnMouseDown()
    {
        Debug.Log("tocado");
        pe.enabled = true;
        anim.SetBool("Activado", true);
    }




}
