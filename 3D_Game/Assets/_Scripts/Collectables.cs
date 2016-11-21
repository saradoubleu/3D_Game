using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Collectables : MonoBehaviour {
    [Header("Sound Clips")]
    public AudioSource CoinSound;
    public AudioSource BottleSound;

    public Text ScoreLabel;

    int score = 0;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    // coin pickup
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Coin"))
        {
            ++score;
            ScoreLabel.text = "Score: " + score.ToString();

            Destroy(other.gameObject);
            this.CoinSound.Play();
        }
        if (other.gameObject.CompareTag("Bottle"))
        {
            Destroy(other.gameObject);
            //play sound
        }
    }
}
