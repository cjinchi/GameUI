using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

enum State { WATING,SKILL_SELECTED, }


public class UISkill : MonoBehaviour {

    public UIController ui;

    public SkillType skillNum;    //第几技能

    //UI
    public Image outline;
    public Image cd;

    //
    public static UISkill currentSelected = null;

	void Start () {
        outline.enabled = false;
        cd.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void SetCd(){
        outline.enabled = false;
        cd.enabled = true;
    }

    public void Selecte(){
        if (currentSelected != null) {
            return;
        }

        currentSelected = this;
        //Set UI
        outline.enabled = true;
        cd.enabled = false;

        //Show buttons according to role and skill
        //...

        //Show intro
        string introText;
        switch (ui.currentRole) {
            default:
                introText = "HelloWorld";
                break;
        }
        ui.intro.Show(introText);


    }
}
