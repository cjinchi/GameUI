﻿using System.Collections;
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

    private int hpMaxValue;
    private int hpValue;
    private int sanMaxValue;
    private int sanValue;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        HP.maxValue = hpMaxValue;
        HP.value = hpValue;
        SAN.maxValue = sanMaxValue;
        SAN.value = sanValue;
    }

    public void SetHP(int maxValue,int value) {
        hpMaxValue = maxValue;
        hpValue = value;
        //Update();
        //HP.maxValue = maxValue;
        //HP.value = value;
    }

    public void SetSAN(int maxValue, int value) {
        //SAN.maxValue = maxValue;
        //SAN.value = value;
        sanMaxValue = maxValue;
        sanValue = value;
        Update();
    }
}
