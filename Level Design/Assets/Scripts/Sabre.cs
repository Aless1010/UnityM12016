using UnityEngine;
using System.Collections;

public class Sabre : MonoBehaviour
{
    private AudioSource slaser;

    //public GameObject sabre;

    // Use this for initialization
    void Start()
    {
        slaser = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponentInChildren<Animator>().SetBool("bill", false);
        if (Input.GetButton("Fire1"))
        {
            GetComponentInChildren<Animator>().SetBool("bill",true);
            slaser.Play();

        }
    }
}