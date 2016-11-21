using UnityEngine;
using System.Collections;

public class Collectables : MonoBehaviour {
    [Header("Sound Clips")]
    public AudioSource CoinSound;

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
        Destroy(other.gameObject);
            this.CoinSound.Play();
        }
        if (other.gameObject.CompareTag("Bottle"))
        {
            Destroy(other.gameObject);
            //bottle pickup
        }
    }
}
