using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Anything a child of this gameObject will not be destroyed between levels/ scenes
/// </summary>
public class Toolbox : MonoBehaviour
{
    public static Toolbox Instance { get; private set; }

    public GameObject canvas;

    private SettingsManager settingsManager;

    private DisplayManager displayManager;

    /// <summary>
    /// Singleton things
    /// </summary>
    void Awake()
    {
        //Want this object and it's children to not be destroyed when changing scenes!
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else Destroy(gameObject);

        //We will create a canvas for the UI that we want to be persistant for various levels. (In this example it will be a settings menu)
        if (canvas != null)
        {
            var go = canvas;
            go.transform.parent = this.gameObject.transform;
        }
        else
        {
            canvas = GameObject.FindGameObjectWithTag("Canvas"); //Make sure your new create object has the canvas tag!
        }

        //Spawn a settings manager gameObject with the script SettingsManager.cs attached to it!
        var go1 = new GameObject("SettingsManager");
        go1.transform.parent = this.gameObject.transform;
        this.settingsManager = go1.AddComponent<SettingsManager>();

        var go2 = new GameObject("DisplayManager");
        go2.transform.parent = this.gameObject.transform;
        this.displayManager = go2.AddComponent<DisplayManager>();
    }

    //Easy way to access the SettingsManager.cs in other scripts!
    public SettingsManager GetSettingsManager()
    {
        return this.settingsManager;
    }

    public DisplayManager GetDisplayManager()
    {
        return this.displayManager;
    }
}
