using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBuff : MonoBehaviour {

    public Image buffOne;
    public Image buffTwo;
    public Image buffThree;
    public Image buffFour;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void setBuffs(Sprite[] buffs) {
        hideAll();
        if (buffs.Length > 0) {
            buffOne.sprite = buffs[0];
            buffOne.enabled = true;
        }
        if (buffs.Length > 1) {
            buffTwo.sprite = buffs[1];
            buffTwo.enabled = true;
        }
        if (buffs.Length > 2) {
            buffThree.sprite = buffs[2];
            buffThree.enabled = true;
        }
        if(buffs.Length > 3) {
            buffFour.sprite = buffs[3];
            buffFour.enabled = true;

        }
    }

    public void hideAll() {
        buffOne.enabled = false;
        buffTwo.enabled = false;
        buffThree.enabled = false;
        buffFour.enabled = false;

    }
}
