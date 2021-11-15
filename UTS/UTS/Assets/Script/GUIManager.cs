using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GUIManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPlay()
    {
        SceneManager.LoadScene("Main");
    }

    public void OnCredits()
    {
        SceneManager.LoadScene("Credits");
    }
    public void OnHelp()
    {
        SceneManager.LoadScene("Help");
    }
    public void OnBack()
    {
        SceneManager.LoadScene("Menu");
    }
}
