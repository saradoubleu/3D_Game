///-----------------------------------------------------------------
///   Namespace:      COMP305-F2016-Assignment3-MagicStrikes
///   Class:          MemuController
///   Description:    This controls the menu behavior 
///   Author:         Sara & Angela                   Date: November 16,2016
///   Notes:          menu controller
///   Revision History: V1.0
///   Name: Sara & Angela          Date: Nov 16,2016        Description:
///-----------------------------------------------------------------
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //PUBLIC METHODS
    public void StartButton_Click() {
        SceneManager.LoadScene("Main");
    }
}
