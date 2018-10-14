using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelMenuManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    public void toLevel1()
    {
        SceneManager.LoadScene("Level1");

    }
    public void toLevel2()
    {
        SceneManager.LoadScene("Level2");

    }
    public void toLevel3()
    {
        SceneManager.LoadScene("Level3");

    }
    // Update is called once per frame
    void Update () {
		
	}
}
