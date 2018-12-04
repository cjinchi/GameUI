using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIIntro : MonoBehaviour {
    public UIController ui;

    public Image backgroud;
    public Text intro;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Hide() {
        backgroud.enabled = false;
        intro.enabled = false;
    }

    public void Show(string introText) {
        intro.text = introText;
        backgroud.enabled = true;
        intro.enabled = true;
    }

}
