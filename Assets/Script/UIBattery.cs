using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBattery : MonoBehaviour {
    public UIController ui;

    public Image batteryOne;
    public Image batteryTwo;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ShowBatteryNumber(BatteryNumberType num) {
        switch (num) {
            case BatteryNumberType.Zero:
                batteryOne.enabled = false;
                batteryTwo.enabled = false;
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
        batteryOne.enabled = false;
        batteryTwo.enabled = false;
    }
}
