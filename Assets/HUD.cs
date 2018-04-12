using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour {

    public Sprite[] heartSprites;

    public Image heartUI;

    public int health;
	
	// Update is called once per frame
	void Update () {
        heartUI.sprite = heartSprites[health];
	}

    public void heal()
    {
        if(health < 5)
            health++;
    }

    public void damage()
    {
        if(health > 0)
            health--;
    }
}
