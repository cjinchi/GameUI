using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UISkill : MonoBehaviour {

    public UIController ui;

    public SkillType type;

    //UI
    public Image outline;
    public Image cd;
    public Image skill;

    //
    public static UISkill currentSelected = null;

    void Start() {
        outline.enabled = false;
        cd.enabled = false;
    }

    // Update is called once per frame
    void Update() {

    }

    void SetCd() {
        outline.enabled = false;
        cd.enabled = true;
    }

    public void Select() {

        if (currentSelected != null) {
            return;
        }

        if(cd.enabled == true) {
            Debug.Assert(false, "select when cd");
        }

        currentSelected = this;

        //Set Skill UI
        outline.enabled = true;

        //Set Global UI
        ui.UpdateUIWhenSkillSelect(currentSelected.type);

    }

    public void SwitchTypeTo(SkillType type) {
        this.type = type;
        skill.sprite = ui.GetSkillSprite(type);
    }

    public void CancelSelect() {
        currentSelected = null;

        outline.enabled = false;
        ui.okButton.SetEnabled(false);
        ui.cancelButton.SetEnabled(false);
        ui.intro.Hide();


        //DEBUG
        ui.circle.enabled = false;
    }

    public static void CancelAnySelect() {
        if (currentSelected != null) {
            currentSelected.CancelSelect();
        }
    }
}
