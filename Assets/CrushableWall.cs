using UnityEngine;
using System.Collections;

public class CrushableWall : MonoBehaviour {
    
    public GameObject CrushableHolder;
    public Material breakable1;
    public Material breakable2;

    int breakCount;
    MeshRenderer meshRender;
    AudioSource audioSource;

    void Awake()
    {
        meshRender = GetComponent<MeshRenderer>();
        audioSource = GetComponent<AudioSource>();
    }
    
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            breakCount++;
            audioSource.Play();
        }
    }

    void Update()
    {
        BreakingAfter(3);
    }

    void BreakingAfter(int breakAfterAmount)
    {
        if (breakCount == 1)
        {
            meshRender.material = breakable1;
            
        }
        else if (breakCount == 2)
        {
            meshRender.material = breakable2;
            audioSource.pitch = 0.8f;
            
            
        }
        else if (breakCount == breakAfterAmount)
        {
            CrushableHolder.SetActive(true); //Enable de losse stukjes
            Destroy(this.gameObject); // Destroy dit object.            
        }
    }
}
