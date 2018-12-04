using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIAP : MonoBehaviour {
    public UIController ui;

    public Text currentAP;
    public Text totalAP;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetAP(string currentAP,string totalAP) {
        this.currentAP.text = currentAP;
        this.totalAP.text = totalAP; 
    }
}
