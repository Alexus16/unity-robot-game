using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NewBehaviourScript1 : MonoBehaviour {
    
    [SerializeField]
    NavMeshAgent agent;
    [SerializeField]
    // Use this for initialization
    public Transform target;
	void Start () {
        agent.SetDestination(target.position);
	}
	
	
}
