using UnityEngine;
using System.Collections;

public class PlayerBehaviour : MonoBehaviour {
    //PUBLIC INSTANCE VARIABLES
    [Header("Sound Clips")]
    public AudioSource CoinSound;
    public AudioSource HurtSound;

    //PRIVATE INSTANCE VARIABLES
    private GameObject _gameControllerObject;
    private GameController _gameController;


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    private void _initialize()
    {
        this._gameControllerObject = GameObject.Find("Game Controller");
        this._gameController = this._gameControllerObject.GetComponent<GameController>() as GameController;
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
       if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            this.CoinSound.Play();
            this._gameController.PlayerScore += 100;
        }

      //  if (other.gameObject.CompareTag("Enemy"))
       // {
        //    // move the player's position to the spawn point's position
         //   this.HurtSound.Play();
          //  this._gameController.LivesValue -= 1;
        //}
    }


}
