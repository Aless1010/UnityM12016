using UnityEngine;
using System.Collections;

public class JediBehaviour : MonoBehaviour {

    NavMeshAgent na;
    GameObject Player;
    float timerPathPlanning = 0;
    Animator anim;

    // Use this for initialization
    void Start () {
        na = GetComponent<NavMeshAgent>();
        anim = GetComponentInChildren<Animator>();
        if (!anim) Debug.Log("Le robot n'a pas d'animator dans ses fils !!");
        Player = GameObject.Find("Player");

	}
	
	// Update is called once per frame
	void Update () {

        //anim.SetFloat("vitesse", na.desiredVelocity.magnitude);

        timerPathPlanning += Time.deltaTime;

        float distance = (Player.transform.position - transform.position).magnitude;
        bool proche = (distance <4);
        anim.SetBool("ennemi", proche);
        if (proche)
        {
            this.transform.LookAt(Player.transform.position);

            //na.ResetPath();
            na.enabled = false;
        }else
        {
            na.enabled = true;
            if (timerPathPlanning > 0.3f)
            {
                na.SetDestination(Player.transform.position);
                timerPathPlanning = 0.0f;
            }
        }


    }
}
