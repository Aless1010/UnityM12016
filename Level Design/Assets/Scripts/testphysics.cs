using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class Dummy : MonoBehaviour
{

    Rigidbody r;
    public float speed = 0.5f;
    public float jumpImpulse = 0.5f;
    public Transform prefabDeathEffect;

    // Use this for initialization
    void Start()
    {
        r = GetComponent<Rigidbody>();
        r.AddForce(new Vector3(0, 3.0f * jumpImpulse, 0), ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        //r.AddForce(Camera.main.transform.right * 2);
        Vector3 rightCam = Camera.main.transform.right * speed * 3.0f;
        r.velocity = new Vector3(rightCam.x, r.velocity.y, rightCam.z);
        if (Input.GetButton("Fire1"))
        {
            r.AddForce(new Vector3(0, 3.0f * jumpImpulse, 0), ForceMode.Impulse);
        }
        Vector3 gaze = r.velocity.normalized;
        gaze.y = Mathf.Max(0, gaze.y);
        transform.LookAt(transform.position + gaze);

    }

    public void OnCollisionEnter(Collision col)
    {
        Destroy(this.gameObject);
        Instantiate(prefabDeathEffect, transform.position, Quaternion.identity);
    }
}