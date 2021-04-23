using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIControl : MonoBehaviour
{
    public NavMeshAgent agent;

    // setagem  do componente navmash dentro da unity 
     void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();
    }

}
