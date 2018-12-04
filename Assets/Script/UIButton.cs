using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIButton : MonoBehaviour {

    public Image backgroud;
    public Text text;
    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetEnabled(bool enabled) {
        backgroud.enabled = enabled;
        text.enabled = enabled;
    }

}
