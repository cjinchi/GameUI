using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIEnemy : MonoBehaviour {
    public UIController ui;

    public Image profilePictureBackgroud;
    public Image profilePicture;
    public Slider HP;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetHP(int maxValue, int value) {
        HP.maxValue = maxValue;
        HP.value = value;
    }
}
