using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarScript : MonoBehaviour {

    [SerializeField]
    private float lerpSpeed;
    
    private float fillAmount;
    [SerializeField]
    private Image content;

    [SerializeField]
    private Text valueText;

    public float MaxValue { get; set; }

    public float Value {
        set {
            string[] tmp = valueText.text.Split(':');
            valueText.text = tmp[0] + ": " + value;
            fillAmount = map(value, 0, MaxValue, 0, 1);
        }
    }
	
	// Update is called once per frame
	void Update () {
        handleBar();
	}

    private void handleBar() {
        if(fillAmount != content.fillAmount) {
            content.fillAmount = Mathf.Lerp(content.fillAmount, fillAmount, Time.deltaTime * lerpSpeed);
        }
    }
    
    private float map(float value, float inMin, float inMax, float outMin, float outMax) {
        return (value - inMin) * (outMax - outMin) / (inMax - inMin) + outMin;
    }
}
