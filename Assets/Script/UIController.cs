using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

public class UIController : MonoBehaviour {

    //!!! Begin: Instance of ui element
    public RoleType currentRole;

    public UIButton okButton;
    public UIButton cancelButton;
    public UIButton finishButton;

    public UIIntro intro;

    public UIAP ap;

    public UIBattery battery;

    public UIRole roleOne;
    public UIRole roleTwo;
    public UIRole roleThree;
    public UIRole roleFour;

    public Image leftPicutre;   //角色立绘
    public Image rightPicture;  //敌方立绘

    public UISkill skillOne;
    public UISkill skillTwo;
    public UISkill skillThree;

    //!!! End: Instance of ui element


    //!!! Begin: Sprite Resource
    public Sprite spritePicutreYiSheng;
    public Sprite spriteYiShengAttack;
    public Sprite spritePoisonCloud;
    public Sprite spriteHeal;

    public Sprite spritePicutreXiXueGui;
    public Sprite spriteXiXueGuiAttack;
    public Sprite spriteWingShield;
    public Sprite spriteEvolve;

    public Sprite spritePicutreLieRen;
    public Sprite spriteLieRenAttack;
    public Sprite spriteMagenticArrow;
    public Sprite spriteChainArrow;

    public Sprite spritePicutreKeXueGuaiRen;
    public Sprite spriteKeXueGuaiRenAttack;
    public Sprite spriteCharge;
    public Sprite spriteTeleport;

    //!!! End: Sprite Resource

    //!!!End: DEBUG
    //TODO:REMOVE
    public Image me;
    public Image you;
    public Image circle;

    //!!!End: DEBUG



    // Use this for initialization
    void Start () {

        //DEBUG
        print("to init UIController");
        roleOne.SetHP(150, 50);
        circle.enabled = false;



        okButton.SetEnabled(false);
        cancelButton.SetEnabled(false);
        intro.Hide();

    }

    // Update is called once per frame
    void Update () {
		
	}

    public static string GetSkillIntro(SkillType skill) {
        switch (skill) {
            default:
                return "skill intro";
        }

    }

    public void SwitchToNextRole() {
        RoleType nextRole = (RoleType)(((int)currentRole + 1) % 4);
        SwitchCurrentRoleTo(nextRole);
    }

    public void SwitchCurrentRoleTo(RoleType role) {
        if(currentRole == role) {
            return;
        }


        //Switch From here
        UISkill.CancelAnySelect();
        if (role != RoleType.KeXueGuaiRen) {
            battery.Hide();
        } else {
            //DEBUG
            battery.ShowBatteryNumber(BatteryNumberType.Two);
        }


        //TODO:REMOVE
        //DEBUG
        System.Random rnd = new System.Random();
        int maxVaule = rnd.Next(100, 200);
        int vaule = rnd.Next(0, maxVaule);
        int maxVaule2 = rnd.Next(100, 200);
        int vaule2 = rnd.Next(0, maxVaule);
        int maxVaule3 = rnd.Next(1, 9);
        int vaule3 = rnd.Next(0, maxVaule3);


        switch (role) {
            case RoleType.KeXueGuaiRen:
                leftPicutre.sprite = spritePicutreKeXueGuaiRen;
                skillOne.SwitchTypeTo(SkillType.KeXueGuaiRenAttack);
                skillTwo.SwitchTypeTo(SkillType.Charge);
                skillThree.SwitchTypeTo(SkillType.Teleport);

                //TODO:REMOVE
                //DEBUG
                roleFour.SetHP(maxVaule,vaule);
                roleFour.SetSAN(maxVaule2, vaule2);
                break;
            case RoleType.LieRen:
                leftPicutre.sprite = spritePicutreLieRen;
                skillOne.SwitchTypeTo(SkillType.LieRenAttack);
                skillTwo.SwitchTypeTo(SkillType.MagenticArrow);
                skillThree.SwitchTypeTo(SkillType.ChainArrow);

                //TODO:REMOVE
                //DEBUG
                roleThree.SetHP(maxVaule, vaule);
                roleThree.SetSAN(maxVaule2, vaule2);
                ap.SetAP(vaule3.ToString(), maxVaule3.ToString());
                break;
            case RoleType.XiXueGui:
                leftPicutre.sprite = spritePicutreXiXueGui;
                skillOne.SwitchTypeTo(SkillType.XiXueGuiAttack);
                skillTwo.SwitchTypeTo(SkillType.WingShield);
                skillThree.SwitchTypeTo(SkillType.Evolve);

                //TODO:REMOVE
                //DEBUG
                roleTwo.SetHP(maxVaule, vaule);
                roleTwo.SetSAN(maxVaule2, vaule2);
                ap.SetAP(vaule3.ToString(), maxVaule3.ToString());
                break;
            case RoleType.YiSheng:
                leftPicutre.sprite = spritePicutreYiSheng;
                skillOne.SwitchTypeTo(SkillType.YiShengAttack);
                skillTwo.SwitchTypeTo(SkillType.PoisonCloud);
                skillThree.SwitchTypeTo(SkillType.Heal);

                //TODO:REMOVE
                //DEBUG
                roleOne.SetHP(maxVaule, vaule);
                roleOne.SetSAN(maxVaule2, vaule2);
                ap.SetAP(vaule3.ToString(), maxVaule3.ToString());
                break;
        }

        currentRole = role;
    }

    public Sprite GetSkillSprite(SkillType type) {
        switch (type) {
            //YiSheng
            case SkillType.YiShengAttack:
                return spriteYiShengAttack;
            case SkillType.PoisonCloud:
                return spritePoisonCloud;
            case SkillType.Heal:
                return spriteHeal;
            //XiXueGui
            case SkillType.XiXueGuiAttack:
                return spriteXiXueGuiAttack;
            case SkillType.WingShield:
                return spriteWingShield;
            case SkillType.Evolve:
                return spriteEvolve;
            //LieRen
            case SkillType.LieRenAttack:
                return spriteLieRenAttack;
            case SkillType.MagenticArrow:
                return spriteMagenticArrow;
            case SkillType.ChainArrow:
                return spriteChainArrow;
            //KeXueGuaiRen
            case SkillType.KeXueGuaiRenAttack:
                return spriteKeXueGuaiRenAttack;
            case SkillType.Charge:
                return spriteCharge;
            case SkillType.Teleport:
                return spriteTeleport;
            default:
                Debug.Assert(false, "In UIController.GetSkillSprite");
                return null;
        }
        
    }

    public void UpdateUIWhenSkillSelect(SkillType type) {
        //Show intro
        intro.Show(GetSkillIntro(type));

        if(type==SkillType.YiShengAttack
            ||type==SkillType.XiXueGuiAttack
            || type == SkillType.KeXueGuaiRenAttack) {
            okButton.SetEnabled(false);
            cancelButton.SetEnabled(true);

            //DEBUG
            //TODO；REMOVE
            //circle.transform.position += (me.transform.position - circle.transform.position);
            //circle.enabled = true;
            circle.rectTransform.position = me.rectTransform.position;
            circle.enabled = true; 

        } else if(type==SkillType.LieRenAttack
            ||type==SkillType.ChainArrow
            || type == SkillType.PoisonCloud) {
            okButton.SetEnabled(false);
            cancelButton.SetEnabled(true);
        }else if(type==SkillType.Heal
            ||type==SkillType.WingShield
            ||type == SkillType.Evolve) {
            okButton.SetEnabled(true);
            cancelButton.SetEnabled(true);
        }else if (type == SkillType.MagenticArrow) {
            okButton.SetEnabled(false);
            cancelButton.SetEnabled(true);
        }else if (type == SkillType.Teleport) {
            okButton.SetEnabled(false);
            cancelButton.SetEnabled(true);
        } else {
            Debug.Assert(false, "in ui.UpdateUIWhenSkillSelect");
        }
    }

    public void UpdateUIWhenCancelPress() {

        //DEBUG
        circle.enabled = false;

        UISkill.CancelAnySelect();
    }

    public void UpdateUIWhenOKPress() {
        UISkill.CancelAnySelect();
    }

    //DEBUG
    public void UpdateWhenTargetSelect() {
        if(circle.enabled == true) {
            circle.enabled = false;
            UISkill.CancelAnySelect();
        }

    }

}
