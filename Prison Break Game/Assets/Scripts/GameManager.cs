using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

[System.Serializable]
public class GameManager : MonoBehaviour
{
    bool isLevel1BeingPlayed = false;
    bool isLevel2BeingPlayed = false;
    bool isTitleBeingPlayed = false;
    bool isHighscoreBeingPlayed = false;
    // Start is called before the first frame update
    void Start()
    {
        isLevel1BeingPlayed = false;
        isLevel2BeingPlayed = false;
        isTitleBeingPlayed = true;
        isHighscoreBeingPlayed = false;

        Scene currentScene = SceneManager.GetActiveScene();

        string SceneName = currentScene.name;

        if (SceneName == "Level1")
        {
            isLevel1BeingPlayed = true;
            isLevel2BeingPlayed = false;
            isTitleBeingPlayed = false;
            isHighscoreBeingPlayed = false;
        }
        else if (SceneName == "Level2")
        {
            isLevel1BeingPlayed = false;
            isLevel2BeingPlayed = true;
            isTitleBeingPlayed = false;
            isHighscoreBeingPlayed = false;
        }
        else if (SceneName == "Title")
        {
            isLevel1BeingPlayed = false;
            isLevel2BeingPlayed = false;
            isTitleBeingPlayed = true;
            isHighscoreBeingPlayed = false;
        }
        else if (SceneName == "HighScore")
        {
            isLevel1BeingPlayed = false;
            isLevel2BeingPlayed = false;
            isTitleBeingPlayed = false;
            isHighscoreBeingPlayed = true;
        }
    }

    public void Update()
    {
        if (Input.GetKey(KeyCode.L))
        {
            loadData();
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            saveData();
        }
    }

    public void saveData()
    {
        SaveController.saveData();
    }

    public void loadData()
    {
        GameManager data = SaveController.returnData();

        isLevel1BeingPlayed = data.isLevel1BeingPlayed;
        isLevel2BeingPlayed = data.isLevel2BeingPlayed;
        isTitleBeingPlayed = data.isTitleBeingPlayed;
        isHighscoreBeingPlayed = data.isHighscoreBeingPlayed;

        Debug.Log(isLevel1BeingPlayed);
        Debug.Log(isLevel2BeingPlayed);
        Debug.Log(isTitleBeingPlayed);
        Debug.Log(isHighscoreBeingPlayed);
    }

    public void OnApplicationQuit()
    {
        saveData();
    }

    // Update is called once per frame
}
