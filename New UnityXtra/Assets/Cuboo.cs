using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cuboo : MonoBehaviour
{
    Rigidbody rbody;
    [SerializeField]
    float speed;
    [SerializeField]
    bool abc;

    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody>();

    }

    void FixedUpdate()
    {
        rbody.AddForce(new Vector3(1, 1, 1));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
