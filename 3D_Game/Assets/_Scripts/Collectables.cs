using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Collectables : MonoBehaviour {
    //PUBLIC INSTANCE VARIABLES
    public GameController gamecontroller;

    [Header("Sound Clips")]
    public AudioSource CoinSound;
    public AudioSource BottleSound;

    //PRIVATE INSTANCE VARIABLES
    private int score = 0;
    private int treasure = 3;

    private int scorevalue;
    private int treasurevalue;


    // Use this for initialization


    // Update is called once per frame
    void Update () {
	
	}

    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {//coin trigger increments score
        if(other.gameObject.CompareTag("Coin"))
        {
            this.gamecontroller.ScoreValue += 1;
            Destroy(other.gameObject);
            this.CoinSound.Play();
        }//bottle pickup
        if (other.gameObject.CompareTag("Bottle"))
        {
            this.gamecontroller.TreasureValue -= 1;
            Destroy(other.gameObject);
            this.BottleSound.Play();
        }
    }
}
