using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RayosRecogidos : MonoBehaviour
{
    public RawImage rayo1cont;
	public RawImage rayo2cont;
	public RawImage rayo3cont;
	public RawImage rayo1rell;
	public RawImage rayo2rell;
	public RawImage rayo3rell;
    public RawImage rayo1contHUD;
	public RawImage rayo2contHUD;
	public RawImage rayo3contHUD;
	public RawImage rayo1rellHUD;
	public RawImage rayo2rellHUD;
	public RawImage rayo3rellHUD;

    // Start is called before the first frame update
    void Start()
    {
		rayo1cont.enabled = true;
		rayo2cont.enabled = true;
		rayo3cont.enabled = true;
		rayo1rell.enabled = false;
		rayo2rell.enabled = false;
		rayo3rell.enabled = false;
    }
    void Update()
    {
        if(rayo1rellHUD.enabled == true) 
        {
            rayo1rell.enabled = true;
            rayo1cont.enabled = false;
        }  
        if(rayo2rellHUD.enabled == true) 
        {
            rayo2rell.enabled = true;
            rayo2cont.enabled = false;
        } 
        if(rayo3rellHUD.enabled == true) 
        {
            rayo3rell.enabled = true;
            rayo3cont.enabled = false;
        }   
    }
}
