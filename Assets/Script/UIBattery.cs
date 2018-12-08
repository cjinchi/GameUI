using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBattery : MonoBehaviour {
    public UIController ui;

    public Image batteryOneBackgroud;
    public Image batteryTwoBackgroud;

    public Image batteryOne;
    public Image batteryTwo;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ShowBatteryNumber(BatteryNumberType num) {
        batteryOneBackgroud.enabled = true;
        batteryTwoBackgroud.enabled = true;
        switch (num) {
            case BatteryNumberType.Zero:
                batteryOne.enabled = false;
                batteryOne.enabled = false;
                break;
            case BatteryNumberType.One:
                batteryOne.enabled = true;
                batteryTwo.enabled = false;
                break;
            case BatteryNumberType.Two:
                batteryOne.enabled = true;
                batteryTwo.enabled = true;
                break;
        }
    }

    public void Hide() {
        batteryOneBackgroud.enabled = false;
        batteryTwoBackgroud.enabled = false;
        batteryOne.enabled = false;
        batteryTwo.enabled = false;
    }
}
