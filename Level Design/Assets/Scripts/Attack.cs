using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour
{

    public Transform grenadePrefab;
    Transform gren = null;
    float timeThrow = 0;
    private Rigidbody mplayer ;
    public float mforce ;
    float ftime;
    public float cadencetir;
    private AudioSource tlaser;

    // Use this for initialization
    void Start()
    {
        mplayer = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>();
        ftime = 0 ;
        tlaser = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

      /*  if (gren)
            gren.position = transform.position +
                                        transform.forward * 2;*/

        if (Input.GetButton("Fire2"))
        {
            // timeThrow += Time.deltaTime;
            if (ftime > cadencetir)
            {
                ftime = 0;
                if (gren == null)
                {
                    // timeThrow = 0;
                    gren = Instantiate(grenadePrefab,
                                            transform.position +
                                            transform.forward,
                                            transform.rotation) as Transform;
                    tlaser.Play();
                    //// force = Quaternion.AngleAxis(-30, Camera.main.transform.right) * force;

                    Rigidbody rbGren = gren.GetComponent<Rigidbody>();
                    rbGren.velocity = transform.TransformDirection(Vector3.forward * mforce) + mplayer.velocity;
                    gren = null;

                }
            }
            ftime += Time.deltaTime;

        }
       /* else
        {
            if (gren != null)
            {
                Vector3 force = transform.forward;
               //// force = Quaternion.AngleAxis(-30, Camera.main.transform.right) * force;
                force = force.normalized * 30 * timeThrow;
                Rigidbody rbGren = gren.GetComponent<Rigidbody>();
                rbGren.velocity = force;
                gren = null;
            }
        }*/
    }
}