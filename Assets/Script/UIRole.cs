using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIRole : MonoBehaviour {
    public UIController ui;

    public RoleType role;

    public Image profilePictureBackgroud;
    public Image profilePicture;
    public Slider HP;
    public Slider SAN;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetHP(int maxValue,int value) {
        HP.maxValue = maxValue;
        HP.value = value;
    }

    public void SetSAN(int maxValue, int value) {
        SAN.maxValue = maxValue;
        SAN.value = value;
    }
}
