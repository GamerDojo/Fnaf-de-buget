using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    NavMeshAgent enemy;
    Animator animator;
    public GameObject player;

    void Start()
    {
        enemy = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        if (player) 
        {   
            player.GetComponent<FirstPersonMovement>().UpdateEnemyAI += SetDestination; //call delegate from Player
        }
    }

    private void Update()
    {
        animator.SetFloat("Speed", enemy.velocity.magnitude / enemy.speed);
    }

    public void SetDestination(Vector3 position)
    {
        enemy.SetDestination(position);
    }
}
