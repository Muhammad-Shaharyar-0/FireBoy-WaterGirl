using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int gemscollected;
    [SerializeField] int TotaleGems=0;
    // Start is called before the first frame update
    void Start()
    {
        TotaleGems = 5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LeveCompleted()
    {
        if(TotaleGems==gemscollected)
        {
            Debug.Log("AllGemsCollected");
        }
        NextLevel();
        
    }
    public void ReplayLevel()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void NextLevel()
    {
     
        int currentlevel = SceneManager.GetActiveScene().buildIndex;
        currentlevel++;

        if (currentlevel > SceneManager.sceneCountInBuildSettings - 1)
        {
            currentlevel = 0;
        }
        SceneManager.LoadScene(currentlevel);
    }
}
