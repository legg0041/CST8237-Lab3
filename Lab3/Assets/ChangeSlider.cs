using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeSlider : MonoBehaviour {

    //the slider
    public Slider valueSlider;

    //holds keys
    string _sliderKey = "SLIDER_VALUE";

    // Use this for initialization
    void Start () {
        //checks the slider key
        if (PlayerPrefs.HasKey(_sliderKey))
        {
            valueSlider.value = PlayerPrefs.GetFloat(_sliderKey);
        }
        else
        {
            saveSlider();
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void saveSlider()
    {
        //set and save
        PlayerPrefs.SetFloat(_sliderKey, valueSlider.value);
        PlayerPrefs.Save();
    }
}
