using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeController : MonoBehaviour
{
    public float suckSpeed = 10f;
    //public float fuelAdd;
    public GameObject target;
    //private GameObject fuelBar;
    public float thrust = 1.0f;
    public Rigidbody rb;
    public float timer;

    // Start is called before the first frame update
    void Awake()
    {
        //fuelBar = GameObject.FindGameObjectWithTag("Fuel Bar");
        target = GameObject.FindGameObjectWithTag("Player");
        rb = GetComponent<Rigidbody>();
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
            StartCoroutine(beamUp());
            // tgr = 1;
        }
    }

    private int a=0;
    IEnumerator beamUp()
    {
        while(transform.position.y < target.transform.position.y)
        {
            transform.position = new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z);
            transform.position += new Vector3(0, suckSpeed * Time.deltaTime, 0);

            if (Input.GetButtonUp("Jump"))
            {
                rb.velocity = transform.forward * thrust;
                break;
            }                

            yield return null;
        }

        if (transform.position.y >= target.transform.position.y)
        {
            Destroy(gameObject);
            yield return null;
        }
    }

}
