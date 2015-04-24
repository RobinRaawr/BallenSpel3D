using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    public GameObject target;
    Vector3 offset;

	void Start () {

        offset = transform.position - target.transform.position;


	
	}
	
	void Update () {

        transform.position = target.transform.position + offset;
	
	}
}
