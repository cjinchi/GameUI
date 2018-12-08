using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBuff : MonoBehaviour {

    //public Image buffOne;
    //public Image buffTwo;
    //public Image buffThree;
    //public Image buffFour;

    public Image[] buffs = new Image[4];

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void setBuffs(Sprite[] buffSprite) {

        for(int i = 0; i < buffs.Length; i++) {
            if (i >= buffSprite.Length) {
                buffs[i].enabled = false;
            } else {
                buffs[i].sprite = buffSprite[i];
                buffs[i].enabled = true;
            }
        }
    }

}
