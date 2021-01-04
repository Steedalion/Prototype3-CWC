using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
	Vector3 startPostion;
	private float offesetX;
    // Start is called before the first frame update
    void Start()
	{
		startPostion = transform.position;
		offesetX = GetComponent<BoxCollider>().size.x/2;
        
    }

    // Update is called once per frame
    void Update()
    {
	    if(transform.position.x < (startPostion.x - offesetX))
	    {
	    	transform.position = startPostion;
	    }
    }
}
