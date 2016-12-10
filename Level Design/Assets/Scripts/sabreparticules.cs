using UnityEngine;
using System.Collections;

public class sabreparticules : MonoBehaviour {

    public Transform Prefabeffect;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ennemi")
        {
            Instantiate(Prefabeffect);
        }
    }
}
