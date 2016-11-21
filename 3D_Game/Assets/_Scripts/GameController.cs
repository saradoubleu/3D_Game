using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour
{



    //PRIVATE INSTANCE VARIABLES
    private int _health;

    //PUBLIC INSTANCE VARIABLES
    [Header("UI Objects")]
    public Text ScoreLabel;
    public Text HealthLabel;
    public Text TimerLabel;  // text UI element for displaying timer

    private float timer;  // variable to keep track of time

    void Start()
    {
        this.timer = 60.0f;


        if (this.TimerLabel != null)
            this.TimerLabel.text = string.Format("{0:F2}", this.timer - Time.time);
        //if time reaches 0  display game over text
        //else if time reaces >0 && collected potions display "you win"

    }

    // Update is called once per frame
    void Update()
    {

        if (this.TimerLabel != null)
            this.TimerLabel.text = string.Format("{0:F2}", this.timer - Time.time);
    }
}