﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class AudioButtonClickComponent : MonoBehaviour {

    public string audioName = "";
    public float volume = 1f;
    // Use this for initialization
    void Awake ()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
	}

    private void OnClick()
    {
        AudioPlayManager.PlaySFX2D(audioName, volume);
    }


}