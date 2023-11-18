using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public NavMeshAgent Enemy;
    public GameObject Player;
    
    // Start is called before the first frame update
    void Start()
    {
        Player.GetComponent<FirstPersonMovement>().UpdateEnemyAI += SetDestination; //call delegate from Player
    }
    public void SetDestination(Vector3 position)
    {
        Enemy.SetDestination(position);
    }
}
