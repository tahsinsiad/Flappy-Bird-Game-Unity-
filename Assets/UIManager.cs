﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public static UIManager instance1;
    public Text scoreText;

    void Awake()
    {
        if(instance1 == null)
        {
            instance1 = this;
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        scoreText.text = ScoreManager.instance.score.ToString();
		
	}
}
