using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour {

    
    //the button
    public Button button;

    //holds string key
    string _buttonKey = "BUTTON_STATE";

    //holds strings to set button to
    string _offState = "This is fine.";
    string _onState = "Is this hell?";

    //holds states of button
    bool _buttonClicked = false;

	// Use this for initialization
	void Start () {
        //checks the button key
        if (PlayerPrefs.HasKey(_buttonKey))
        {
            Text buttonText = button.GetComponentInChildren<Text>();
            buttonText.text = PlayerPrefs.GetString(_buttonKey);
            if (buttonText.text.Equals(_offState))
            {
                _buttonClicked = false;
            }
            else
            {
                _buttonClicked = true;
            }
        }
        else
        {
            saveButton();
        }
    }
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void saveButton()
    {
        //flip state on click
        _buttonClicked = !_buttonClicked;

        //holds the button's text
        Text buttonText;

        //check if it was turned on
        if (_buttonClicked)
        {
            buttonText = button.GetComponentInChildren<Text>();
            buttonText.text = _onState;
        }
        else
        {
            buttonText = button.GetComponentInChildren<Text>();
            buttonText.text = _offState;
            
        }
        //set and save
        PlayerPrefs.SetString(_buttonKey, buttonText.text);
        PlayerPrefs.Save();
    }

    

    
}
