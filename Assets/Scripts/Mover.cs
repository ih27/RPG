using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{
    private NavMeshAgent agent;

    [SerializeField]
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.destination = target.position;
    }
}
