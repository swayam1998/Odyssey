using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeController : MonoBehaviour
{
    public float suckSpeed = 10f;
    //public float fuelAdd;
    public GameObject target;
    //private GameObject fuelBar;

    private int tgr = 0;
    public float thrust = 1.0f;
    public Rigidbody rb;

    public float timer;

    // Start is called before the first frame update
    void Awake()
    {
        //fuelBar = GameObject.FindGameObjectWithTag("Fuel Bar");
        target = GameObject.FindGameObjectWithTag("Player");
        rb = GetComponent<Rigidbody>();
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonUp("Jump"))
        {
            tgr = 2;
            rb.AddForce(transform.forward * thrust);
        }

        if(tgr == 1)
        {
            SetTransformXZ(target.transform.position.x, target.transform.position.z);
            transform.position += new Vector3(0, suckSpeed * Time.deltaTime, 0);

            if(transform.position.y >= target.transform.position.y)
            {
                Destroy(gameObject);
            }
        }

        if(tgr == 2)
        {
            if(timer <= 10)
            {
                rb.AddForce(transform.forward * thrust);
                timer += Time.deltaTime;
            }

            else
            {
                tgr = 0;
                timer = 0;
            }           
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "shipEndCollider")
        {
            Destroy(this.gameObject);
        }

        if (other.name == "tractorBeam")
        {
            //StartCoroutine(beamUp());
            tgr =1;
        }
    }

    // IEnumerator beamUp()
    // {
    //     transform.position = new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z);
    //     tgr = 1;
    //     transform.position = Vector3.MoveTowards(transform.position, transform.position + new Vector3(0, 10, 0), 1);
        
    //     // if(transform.position.y >= target.transform.position.y)
    //     // {
    //     //     //Destroy(gameObject);
    //     //     yield return 0;
    //     // }
    //     yield return 0;
    // }

    void SetTransformXZ(float p, float q)
    {
        transform.position = new Vector3(p, transform.position.y, q);
    }
}
