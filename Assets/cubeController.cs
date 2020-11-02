using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeController : MonoBehaviour
{
    public float speed = 10f;

    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {

        if(other.name == "shipEndCollider")
        {
            Destroy(this.gameObject);
        }

        if (other.name == "tractorBeam")
        {
            StartCoroutine("beamUp");
        }
    }

    IEnumerator beamUp()
    {
        float step = speed * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, step);

        // Check if the position of the cube and sphere are approximately equal.
        if (Vector3.Distance(transform.position, target.transform.position) < 0.001f)
        {
            Destroy(this.gameObject);

            
        }
        yield return null;
        
    }
}
