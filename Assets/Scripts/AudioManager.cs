using System;
using FMODUnity;
using UnityEngine;

public class AudioManager
{
    private static AudioManager instance;

    public static AudioManager GetInstance()
    {
        if (instance == null)
        {
            instance = new AudioManager();
        }
        return instance;
    }
    
    public void LoadBanks(Action callback)
    {
        string audioPath = "Audio/FMODBanks/Master.bytes";
        TextAsset asset = ResourceLoader.Load<TextAsset>(audioPath);
        if (asset)
        {
            RuntimeManager.LoadBank(asset);
        }
        Debug.LogError("LoadBank Finish");
        callback?.Invoke();
    }
}