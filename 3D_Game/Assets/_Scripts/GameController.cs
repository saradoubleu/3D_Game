using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour {
    //PRIVATE INSTANCE VARIABLES
    private int _score;

    //PUBLIC INSTANCE VARIABLES
    [Header("UI Objects")]
    public Text ScoreLabel;

    // Use this for initialization
    void Start () {
        this.PlayerScore = 0;
    }

    public int PlayerScore
    {
        get
        {
            return this._score;
        }

        set
        {
            this._score = value;
            this.ScoreLabel.text = "Score: " + this._score;
        }
    }

}
