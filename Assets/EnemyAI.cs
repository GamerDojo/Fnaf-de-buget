using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public NavMeshAgent Enemy;
    public GameObject Player;

    public float stoppingDistance = 1;
    // Start is called before the first frame update
    void Start()
    {
        if(Player)
        {
        Player.GetComponent<FirstPersonMovement>().UpdateEnemyAI += SetDestination; //call delegate from Player
        }
        
        if(Enemy)
        {
            Enemy.stoppingDistance = stoppingDistance;
        }
    }
    public void SetDestination(Vector3 position)
    {
        Enemy.SetDestination(position);
    }
}
