using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class GameController : MonoBehaviour
{

    //PRIVATE INSTANCE VARIABLES
    private float _timer;

    //PUBLIC INSTANCE VARIABLES
    [Header("UI Objects")]
    public Text TimerLabel;  // text UI element for displaying timer
                             // PUBLIC INSTANCE VARIABLES
    public Text HealthLabel;
    public Text ScoreLabel;
    public Text MissingLabel;
    public Text GameOverLabel;
    public Text PointScoreLabel;
    public Button RestartButton;
    public GameObject player;

    // PRIVATE INSTANCE VARIABLES
    private int _scoreValue;
    private int _healthValue;
    private int _treasureValue;
    private AudioSource[] _audioSources;
    private AudioSource _gameSound;
    //private AudioSource _gameOverSound;
    private AudioListener _gameOverListener;
    private int minutes;
    private int seconds;
    public AudioSource _gameOverSound;




    // PUBLIC ACCESS METHODS
    public int ScoreValue
    {
        get
        {
            return this._scoreValue;
        }

        set
        {
            this._scoreValue = value;
            this.ScoreLabel.text = "Score: " + this._scoreValue;
        }
    }

    public int TreasureValue
    {
        get
        {
            return this._treasureValue;
        }

        set
        {
            this._treasureValue = value;
            if (this._treasureValue <= 0)
            {
                this._endGame();
            }
            else
            {
                this.MissingLabel.text = "Missing Treasures:  " + this._treasureValue;
            }
        }
    }

    public int HealthValue
    {
        get
        {
            return this._healthValue;
        }

        set
        {
            this._healthValue = value;
            if (this._healthValue <= 0)
            {
                this._endGame();
            }
            else
            {
                this.HealthLabel.text = "Health: " + this._healthValue;
            }
        }
    }



    void Start()
    {
        this._initialize();

    }

    // Update is called once per frame
    void Update()
    {
        if (_timer > 1)
        {
            onTime();
        }
        else
        {
            this._endGame();
        }
    }
       
     	//PRIVATE METHODS ++++++++++++++++++

	//Initial Method
	private void _initialize() {
        this._timer = 480.00f;
        this.ScoreValue = 0;
		this.HealthValue = 5;
        this.TreasureValue = 3;
		this.GameOverLabel.gameObject.SetActive (false);
		this.PointScoreLabel.gameObject.SetActive (false);
		this.RestartButton.gameObject.SetActive(false);

		this._gameOverListener = gameObject.GetComponent<AudioListener> ();
		this._audioSources = gameObject.GetComponents<AudioSource> ();
		this._gameSound = this._audioSources [0];
		this._gameOverSound = this._audioSources [1];

		this._gameSound.Play ();

	}

	private void _endGame() {
		//this.PointScoreLabel.text = "Final Score: " + (this._scoreValue * 10);
		this.GameOverLabel.gameObject.SetActive (true);
		//this.PointScoreLabel.gameObject.SetActive (true);
		this.RestartButton.gameObject.SetActive (true);
		//this.HealthLabel.gameObject.SetActive (false);
        //this.MissingLabel.gameObject.SetActive(false);
		//this.ScoreLabel.gameObject.SetActive (false);
		this.player.gameObject.SetActive (false);
		this._gameOverListener.enabled = true;
		//this._gameSound.Stop ();
		//this._gameOverSound.Play ();
	}

    // PUBLIC METHODS

    public void onTime()
    {
        _timer -= Time.deltaTime;
        minutes = Mathf.FloorToInt(_timer / 60F);
        seconds = Mathf.FloorToInt(_timer - minutes * 60);
        string niceTime = string.Format("{0:0}:{1:00}", minutes, seconds);

        TimerLabel.text = "Remaining Time: " + niceTime;
    }
    public void ResetButtonClick() {
        //SceneManager.LoadScene (SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("Main");
    }
}