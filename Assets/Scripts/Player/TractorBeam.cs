using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TractorBeam : MonoBehaviour
{
    [SerializeField] GameObject tractorBeam;

    [SerializeField] Vector3 scaleVert = new Vector3(0f, 0.5f, 0f);
    [SerializeField] Vector3 scaleRad = new Vector3(0.06f, 0, 0.06f);
    [SerializeField] float maxH = 10;
    [SerializeField] float maxR = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            tractorBeam.transform.localScale = new Vector3(0.1f,0.1f,0.1f);
        }

        if(Input.GetButton("Jump"))
        {            

            if(tractorBeam.transform.localScale.y <= maxH)
            {
                tractorBeam.transform.localScale += scaleVert;
            }
            else if(tractorBeam.transform.localScale.x <= maxR )
            {
                tractorBeam.transform.localScale += scaleRad;
            }
        }
        
        else
        {
            if (tractorBeam.transform.localScale.y > 0.1f)
            {
                tractorBeam.transform.localScale -= scaleVert;
            }

            if (tractorBeam.transform.localScale.x > 0.1f)
            {
                tractorBeam.transform.localScale -= scaleRad;
            }
        }
    }
}
