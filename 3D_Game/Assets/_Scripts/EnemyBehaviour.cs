using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EnemyBehaviour : MonoBehaviour {
    //PRIVATE INSTANCE VARIABLES
    private Transform Target;
    private int healthvalue;

    //PUBLIC INSTANCE VARIABLES
    public NavMeshAgent Agent;
    public GameController gamecontroller;


    //PRIVATE VARIABLES
    private AudioSource _enemySound;


    // Use this for initialization
    void Start () {
        //find the player
        this.Target = GameObject.FindWithTag("Player").transform;
        this._enemySound = gameObject.GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        //follow the player(target)
        this.Agent.SetDestination(this.Target.position);
	}

    //Check for collision
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            this.gamecontroller.HealthValue -= 1;
            this._enemySound.Play();
        }
    }
}
