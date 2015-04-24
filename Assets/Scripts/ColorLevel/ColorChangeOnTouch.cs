using UnityEngine;
using System.Collections;

public class ColorChangeOnTouch : MonoBehaviour {

    MeshRenderer mesh;
    float rndColor = 1.5f;

	void Awake () {

        mesh = GetComponent<MeshRenderer>();	
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "Player")
        {
            Debug.Log("Touched");
            mesh.material.color = new Color(Random.Range(0, rndColor), Random.Range(0, rndColor), Random.Range(0, rndColor), 1);
        }
    }
	
	void Update () {
	
	}
}
