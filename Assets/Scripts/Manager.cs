﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Manager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void ChangeScene(string name) {
        SceneManager.LoadScene(name);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
