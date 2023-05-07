using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayManager : MonoBehaviour
{
    private int displayResolution;

    void Start()
    {
        //Load display resolution using playerprefs
        displayResolution = PlayerPrefs.GetInt("DisplayResolution");

        //set the display resolution to what was saved above
        Toolbox.Instance.canvas.GetComponent<SettingsMenu>().displayMenuOBJ.GetComponent<DisplayMenu>().DisplayResolutionChosen(displayResolution);
    }
}
