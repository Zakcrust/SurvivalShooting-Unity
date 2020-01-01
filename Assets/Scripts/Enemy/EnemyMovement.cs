using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
	private Transform player;
    PlayerHealth playerHealth;
    public EnemyHealth enemyHealth;
    UnityEngine.AI.NavMeshAgent nav;


    void Awake ()
    {
		GameObject ply = GameObject.FindWithTag("Player");
		player = ply.transform;
        playerHealth = ply.GetComponent <PlayerHealth> ();
        nav = GetComponent <UnityEngine.AI.NavMeshAgent> ();
    }


    void Update ()
    {
        if(nav.enabled)
		    nav.SetDestination (player.position);
        if(enemyHealth.CurrentHealth > 0  && playerHealth.CurrentHealth > 0)
        {
            nav.SetDestination (player.position);
        }
        else
        {
            nav.enabled = false;
        }
        
    }
}
