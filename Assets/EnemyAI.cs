using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public NavMeshAgent BigVegas;

    public GameObject Player;

    private float updateTime = 1; // desired update interval
    private float currentTime = 0; // point in waiting time
    
    // Start is called before the first frame update
    void Start()
    {
        BigVegas.SetDestination(Player.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if(currentTime >= updateTime)
        {
            BigVegas.SetDestination(Player.transform.position);
            currentTime = 0;
        }
    }
}
