using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Groundgenerator : MonoBehaviour {

    public GameObject theGround;

    public Transform generationPoint;

    public float distanceBetween;

    private float PlatformWidth;

    public float DistanceBetweenMin;

    public float DistanceBetweenMax;

    // Use this for initialization
    void Start () {
        PlatformWidth = theGround.GetComponent<BoxCollider2D>().size.x;
    }
	
	// Update is called once per frame
	void Update () {

        if (transform.position.x < generationPoint.position.x)

        {
            distanceBetween = Random.Range(DistanceBetweenMin, DistanceBetweenMax);

            transform.position = new Vector3(transform.position.x + PlatformWidth + distanceBetween, transform.position.y, transform.position.z);
            Instantiate(theGround, transform.position, transform.rotation);
        }
    }
}
