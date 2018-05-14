using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls : MonoBehaviour {

    public CharacterControls theCharacter;

    private Vector3 lastPlayerPosition;

    private float distancetomove;


	// Use this for initialization
	void Start () {
        theCharacter = FindObjectOfType<CharacterControls>();

        lastPlayerPosition = theCharacter.transform.position;

    }
	
	// Update is called once per frame
	void Update () {
        distancetomove = theCharacter.transform.position.x - lastPlayerPosition.x;

        transform.position = new Vector3(transform.position.x + distancetomove, transform.position.y, transform.position.z);

        lastPlayerPosition = theCharacter.transform.position;

	}
}
