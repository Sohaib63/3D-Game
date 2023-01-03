using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerspeed = 5000f;
    public float directionalspeed = 20f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float movehorizontal = Input.GetAxis("Horizontal");
        transform.position = Vector3.Lerp(gameObject.transform.position, new Vector3(Mathf.Clamp(gameObject.transform.position.x+movehorizontal, -2.5f, 2.5f), gameObject.transform.position.y, gameObject.transform.position.z), Time.deltaTime * directionalspeed);
        GetComponent<Rigidbody>().velocity = Vector3.forward * Time.deltaTime * 10;

    }
}
