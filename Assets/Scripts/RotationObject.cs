using UnityEngine;
using System.Collections;

public class RotationObject : MonoBehaviour {
    
    public float speed = 3;
    Rigidbody body;

    void Awake()
    {
        body = GetComponent<Rigidbody>();
    }

	void Start () {
	
	}

    void Update()
    {
        RotationInput();
    }

    void RotationInput()
    {
        Vector3 rotVector = new Vector3(0, 0, 0);

        if (Input.GetButton("Fire1") || (Input.GetKey(KeyCode.LeftArrow)) || (Input.GetKey(KeyCode.A)))
        {
            rotVector.z += speed;
            transform.Rotate(rotVector);

        }

        if (Input.GetButton("Fire2") || (Input.GetKey(KeyCode.RightArrow)) || (Input.GetKey(KeyCode.D)))
        {
            rotVector.z -= speed;
            this.transform.Rotate(rotVector);
        }  
    }

	void FixedUpdate () {
        //float rotInput = Input.GetAxis("Horizontal");
        //body.AddTorque(0, 0, rotInput * rotForce);
	}
}
