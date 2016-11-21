using UnityEngine;
using System.Collections;

public class PlayerBehaviour : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            //this.HurtSound.Play();
            //this._gameController.LivesValue -= 1;
        }
    }
}