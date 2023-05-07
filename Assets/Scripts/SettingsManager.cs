using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsManager : MonoBehaviour
{
    public void OpenOrCloseSettingsMenu(bool opening)
    {
        Toolbox.Instance.canvas.GetComponent<SettingsMenu>().OpenCloseSettingsMenu(opening);
    }
}
