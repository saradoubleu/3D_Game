using UnityEngine;
using System.Collections;

public class EnemyBehaviour : MonoBehaviour {
    //PRIVATE INSTANCE VARIABLES
    private Transform Target;

    //PUBLIC INSTANCE VARIABLES
    public NavMeshAgent Agent;

        // Use this for initialization
	void Start () {
        this.Target = GameObject.FindWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
        this.Agent.SetDestination(this.Target.position);

	}
}
