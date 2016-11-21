using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour
{

    //PRIVATE INSTANCE VARIABLES
    private float _timer;

    //PUBLIC INSTANCE VARIABLES
    [Header("UI Objects")]
    public Text TimerLabel;  // text UI element for displaying timer


    void Start()
    {
        this._timer = 60.00f;

    }

    // Update is called once per frame
    void Update()
    { string time = string.Format("{0:F2}", this._timer - Time.time);

        if (this.TimerLabel != null)
            TimerLabel.text = "Remaining Time: " + time;
        }
}