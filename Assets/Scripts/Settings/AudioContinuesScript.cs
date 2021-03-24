using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioContinuesScript : MonoBehaviour
{
    private static readonly string BackgroundPref = "backgroundPref";
    private static readonly string SoundsEffectsPref = "soundsEffecsPref";
    private float backgroundFloat, soundEffectsFloat;
    public AudioSource backgroundAudio;
    public AudioSource[] soundEffectsAudio;

    void Start()
    {
        backgroundFloat = PlayerPrefs.GetFloat(BackgroundPref);
        soundEffectsFloat = PlayerPrefs.GetFloat(SoundsEffectsPref);
    }


    private void OnApplicationFocus(bool inFocus)
    {
        if (!inFocus)
        {
            ContinueSettings();
        }
    }

    public void ContinueSettings()
    {
        backgroundAudio.volume = backgroundFloat;

        for (int i = 0; i < soundEffectsAudio.Length; i++)
        {
            soundEffectsAudio[i].volume = soundEffectsFloat;
        }
    }
}
