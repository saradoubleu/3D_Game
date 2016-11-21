using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Collectables : MonoBehaviour {
    //PUBLIC INSTANCE VARIABLES
    public Text ScoreLabel;
    public Text HealthLabel;

    [Header("Sound Clips")]
    public AudioSource CoinSound;
    public AudioSource BottleSound;

    //PRIVATE INSTANCE VARIABLES
    private int score = 0;


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
            ++score;
            ScoreLabel.text = "Score: " + score.ToString();

            Destroy(other.gameObject);
            this.CoinSound.Play();
        }//bottle pickup
        if (other.gameObject.CompareTag("Bottle"))
        {
            Destroy(other.gameObject);
            this.BottleSound.Play();
        }
    }
}
