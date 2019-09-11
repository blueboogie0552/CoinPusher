using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PusherController : MonoBehaviour
{
    public Rigidbody rb;
    private Vector3 origin;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Awake()
    {
        origin = rb.position;
    }

    // Update is called once per frame
    void Update()
    {
        var offset = new Vector3(0, 0, Mathf.Sin(Time.time));
        rb.MovePosition(origin + offset);
    }
}
