using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum RoleType { KeXueGuaiRen,LieRen,XiXueGui,YiSheng};

public enum ButtonType { OK,Cancel,Finish};

public enum BatteryNumberType { Zero,One,Two};

public enum SkillType {
    //YiSheng
    YiShengAttack, PoisonCloud, Heal,
    //XiXueGui
    XiXueGuiAttack, WingShield, Evolve,
    //LieRen
    LieRenAttack, MagenticArrow, ChainArrow,
    //KeXueGuaiRen
    KeXueGuaiRenAttack, Charge, Teleport
}


public enum BuffType {

}