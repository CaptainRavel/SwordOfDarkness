using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SettingBarScript : MonoBehaviour
{
    public Toggle fullScreenToggle;

    private int screenInt;

    private int fullscreenInt;

    private bool FullScreen;

    private bool isFullScreen = false;

    public Dropdown qualityDropdown;

    public Dropdown resolutionDropdown;

    const string resName = "resolutionopiton";

    const string prefName = "optionvalue";

    void Awake()
    {
        screenInt = PlayerPrefs.GetInt("togglestate");

        if (screenInt == 1)
        {
            isFullScreen = true;
            fullScreenToggle.isOn = true;
        }
        else
        {
            fullScreenToggle.isOn = false;
        }

        qualityDropdown.onValueChanged.AddListener(new UnityAction<int>(index =>
        {
            PlayerPrefs.SetInt(prefName, qualityDropdown.value);
            PlayerPrefs.Save();
        }));

        resolutionDropdown.onValueChanged.AddListener(new UnityAction<int>(index =>
        {
            PlayerPrefs.SetInt(resName, resolutionDropdown.value);
            PlayerPrefs.Save();
        }));
    }

    void Start()
    {
        qualityDropdown.value = PlayerPrefs.GetInt(prefName, 3);

        resolutionDropdown.value = PlayerPrefs.GetInt(resName, 0);
    }

    public void SetFullcreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
        {
            if (isFullScreen == false)
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

    public void SetResolution(int val)
    {
        if (val == 0)
        {
            Screen.SetResolution(640, 480, fullScreenToggle.isOn);
        }
        if (val == 1)
        {
            Screen.SetResolution(1024, 768, fullScreenToggle.isOn);
        }
        if (val == 2)
        {
            Screen.SetResolution(1280, 960, fullScreenToggle.isOn);
        }
        if (val == 3)
        {
            Screen.SetResolution(1680, 1050, fullScreenToggle.isOn);
        }
        if (val == 4)
        {
            Screen.SetResolution(1280, 720, fullScreenToggle.isOn);
        }
        if (val == 5)
        {
            Screen.SetResolution(1366, 768, fullScreenToggle.isOn);
        }
        if (val == 6)
        {
            Screen.SetResolution(1920, 1080, fullScreenToggle.isOn);
        }
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }
}