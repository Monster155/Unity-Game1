using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 20;
    public float turnRate = 10;
    private float inputVer = 0;
    private float inputHor = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        inputVer = Input.GetAxis("Vertical");
        inputHor = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * inputVer);
        transform.Rotate(Vector3.up, Time.deltaTime * turnRate * inputHor);
    }
}
