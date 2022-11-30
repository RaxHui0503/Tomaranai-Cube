using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI; // need a reference to the drop-down component because want to add each of the resolutions to drop-down nad because drop-down is a UI element so need to using UnityEngine.UI

using UnityEngine.SceneManagement;

public class SettingMenu2 : MonoBehaviour
{
   public TMPro.TMP_Dropdown qualityDropDown;

   public TMPro.TMP_Dropdown resolutionDropdown; // a variable that reference UI element

    public Toggle fullScreenToggle;

    private int screenInt;

    Resolution[] resolutions; // [] is to mark it as array

    private bool isFullScreen = false;

    const string prefName = "optionvalue";
    const string resName = "resolutionoption";

     void Awake() // save the vaules of quality, sets the toggle bool value to true or false, and resolution when the player clicks on the dropdowns
    {
        screenInt = PlayerPrefs.GetInt("togglestate");
        if(screenInt == 1)
        {
            isFullScreen = true;
            fullScreenToggle.isOn = true;
        }
        else
        {
            fullScreenToggle.isOn =false;   
        }

        resolutionDropdown.onValueChanged.AddListener(new UnityAction<int>(index =>
        {
            PlayerPrefs.SetInt(resName, resolutionDropdown.value);
            PlayerPrefs.Save();
        }));
        qualityDropDown.onValueChanged.AddListener(new UnityAction<int>(index =>
        {
            PlayerPrefs.SetInt(prefName, qualityDropDown.value);
            PlayerPrefs.Save();
        }));
    }

     void Start() // save and get the int value of the quality value, and looks for a list of the resolution dropdown values and sets them based on the player's preference
    {
        qualityDropDown.value = PlayerPrefs.GetInt(prefName, 3);

        resolutions = Screen.resolutions; // to gather some information about what resolutions have at disposal so use a array ( array = a list (of all the resolutions))

        resolutionDropdown.ClearOptions(); // clear out the default options that on resolution drop-dwon

        List<string> options = new List<string>();  // a list of strings which is going to be the options because the add options takes in a list of strings not array so need to turn the array to a strings 
        //array is have a fixed size but the size of a list can be changed 
        int currentResolutionIndex = 0;

        for (int i=0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + "x" + resolutions[i].height + "" + resolutions[i].refreshRate + "Hz"; //"width" + "x" + "height+ refreshrate"

            options.Add(option); 
            // because at first won't select the correct resolution right off the start so need to do this loop through each element in resolutions array
            // and for each of them create a nicely foematted string (string option = resolutions[i].width + "x" + resolutions[i].height+"" + resolutions[i].refreshRate + "Hz";)
            // and add it to options list (options.Add(option);)

            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height && resolutions[i].refreshRate == Screen.currentResolution.refreshRate)
            {// check if resolution to the i th element so the resolution that are currently looking at is = current resolution and it can't compare 2 resolution types
             // so need to use && so now are compare both width and the height and the refreshrate of the resolutions  

                currentResolutionIndex = i;  //and if they both match up then are looking at the correct resolution so store the index of that 
            }
        }
        resolutionDropdown.AddOptions(options);// when down looping through will add the options list to the resolution drop-down
        resolutionDropdown.value = PlayerPrefs.GetInt(resName, currentResolutionIndex);
        resolutionDropdown.RefreshShownValue();// so can actually display its
    }
    public void SetResolution(int resolutionIndex) // set the resolution based on the screen width of the player's monitor
    {
        Resolution resolution = resolutions[resolutionIndex]; // this is for getting the width and height

        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen); // because this takes in a width and height
        // as is a  boolean saying whether or not want the game to be displayed in fullscreen
    }

    public void SetQulity(int qualityIndex) // set the quality of the game based on the int value indicated by the dropdown list
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void SetFullscreen(bool isFullScreen) // look to see if the player is fullscreen or not. if yes then the toggle marker is on. if no then the toggle marker is off
    {
        Screen.fullScreen = isFullScreen;

        if(isFullScreen == false)
        {
            PlayerPrefs.SetInt("togglestate", 0);
        }
        else
        {
            isFullScreen = true;
            PlayerPrefs.SetInt("togglestate", 1);
        }
    }
}
