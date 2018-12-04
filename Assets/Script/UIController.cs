using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UIController : MonoBehaviour {

    public Role currentRole = Role.KEXUEGUAIREN;

    public UIButton okButton;
    public UIButton cancelButton;

    public UIIntro intro;

    // Use this for initialization
    void Start () {
        print("to init UIController");
    }

    // Update is called once per frame
    void Update () {
		
	}

}
