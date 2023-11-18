using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public NavMeshAgent BigVegas;

    private float updateTime = 1; // desired update interval
    private float currentTime = 0; // point in waiting time
    
    // Start is called before the first frame update
    void Start()
    {

    }
    public void SetDestination(Vector3 position)
    {
            BigVegas.SetDestination(position);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
