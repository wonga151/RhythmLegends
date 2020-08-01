using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TornadoMove : MonoBehaviour
{

    private ParticleSystem tornadoSystem;

    public bool stopped = true;
    public bool idle = true;
    public Vector3 originalPosition;

    Vector3 tempPosition;


    // Start is called before the first frame update
    void Start()
    {
        originalPosition = transform.position;
        tornadoSystem = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!tornadoSystem.isPlaying) {
            tornadoSystem.Play();
        }

        tempPosition = transform.position;

        tempPosition.x += 0.02f;

        if(tempPosition.x > 15f) {
            stopped = true;
            idle = false;

            Destroy(this.gameObject);

        }
        else {
            transform.position = tempPosition;
        }
    }

    void moveForward() {

    }
}
