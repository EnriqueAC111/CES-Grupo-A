﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Este script sirve para cortar la cuerda. Sigue el movimiento del ratón al mantener el click izquierdo.

public class CortaCuerda : MonoBehaviour
{

    Collider2D col;
	private Vector2 mousePosition;
	//Velocidad del cursor:
	public float moveSpeed = 0.1f;
	// Start is called before the first frame update
	void Start()
	{
        col = GetComponent<Collider2D>();
        gameObject.SetActive(true);
    }

	// Update is called once per frame
	void Update()
	{
        //Para activarlo con el click:
        if (Input.GetMouseButtonDown(0))
        {
            col.enabled = true;

            //Para saber donde está la posición del ratón:
            mousePosition = Input.mousePosition;
            //Donde clickas tienes la posicion de la camara:
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        }

        if (Input.GetMouseButtonUp(0))
        {
            col.enabled = false;
        }
        if (Input.GetMouseButton(0)) {
			//Consola:
			Debug.Log("Mouse");
			//Para saber donde está la posición del ratón:
			mousePosition = Input.mousePosition;
			//Donde clickas tienes la posicion de la camara:
			mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
			//Para que se mueva:
			transform.position = mousePosition;
		}

	}
		
}