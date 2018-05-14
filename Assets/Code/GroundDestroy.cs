using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDestroy : MonoBehaviour {

    public GameObject grounddestroy;

	// Use this for initialization
	void Start () {

        grounddestroy = GameObject.Find("GroundDestructionP");

	}
	
	// Update is called once per frame
	void Update () {

        if (transform.position.x < grounddestroy.transform.position.x)
        {
            Destroy(gameObject);
        }

	}
}
