using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class battlescript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        rnd = new System.Random();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDtSet)
        {
            if ((DateTime.Now - dtPlayerClik).TotalSeconds > 2)
            {
                var go = GameObject.Find("TextZombie");
                go.active = false;
                isDtSet = false;
            }
        }
    }
    System.Random rnd = new System.Random();
    DateTime dtPlayerClik;
    bool isDtSet = false;
    public void PlayerClick()
    {
        int dmg = rnd.Next(1, 100);
        //get text object
        var go = GameObject.Find("TextZombie");
        go.active = true;
        var classtext = GameObject.Find("TextZombie").GetComponent<Text>();
        classtext.text = "damage done "+dmg.ToString();
        classtext.color = Color.red;
        dtPlayerClik = DateTime.Now;
        isDtSet = true;
    }
}
