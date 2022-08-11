using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    string CurrentScene = "path1lvl1";
    public void CLick00()
    {
        string mess = "level 0";
        SceneManager.LoadScene(CurrentScene);
        //throw new UnityException("clicked 00" + mess);
    }
    public void CLick01()
    {
        string mess = "level 01";
        throw new UnityException("clicked 01" + mess);
    }
}
