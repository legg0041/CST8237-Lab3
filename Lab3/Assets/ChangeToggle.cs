using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ChangeToggle : MonoBehaviour {

    //the toggle
    public Toggle toggle;
    //holds string key
    string _toggleKey = "TOGGLE_STATE";

    // Use this for initialization
    void Start()
    {
        //checks the toggle key
        if (PlayerPrefs.HasKey(_toggleKey))
        {
            toggle.isOn = (PlayerPrefs.GetInt(_toggleKey) == 1 ? true : false);
        }
        else
        {
            saveToggle();
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    public void saveToggle()
    {
        //is it on
        if (toggle.isOn)
        {
            //save on
            PlayerPrefs.SetInt(_toggleKey, 1);
        }
        else
        {
            //save off
            PlayerPrefs.SetInt(_toggleKey, 0);
        }
        //save
        PlayerPrefs.Save();
    }
}
