using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;
using TMPro;

public class TextFileWriter : MonoBehaviour
{
    private int[] scoreArray = new int[10];
    int insertPosition;
    public TextMeshProUGUI scoreText1;
    public TextMeshProUGUI scoreText2;
    public TextMeshProUGUI scoreText3;
    public TextMeshProUGUI scoreText4;
    public TextMeshProUGUI scoreText5;
    public TextMeshProUGUI scoreText6;
    public TextMeshProUGUI scoreText7;
    public TextMeshProUGUI scoreText8;
    public TextMeshProUGUI scoreText9;
    public TextMeshProUGUI scoreText10;

    public TextMeshProUGUI nameText1;
    public TextMeshProUGUI nameText2;
    public TextMeshProUGUI nameText3;
    public TextMeshProUGUI nameText4;
    public TextMeshProUGUI nameText5;
    public TextMeshProUGUI nameText6;
    public TextMeshProUGUI nameText7;
    public TextMeshProUGUI nameText8;
    public TextMeshProUGUI nameText9;
    public TextMeshProUGUI nameText10;
    // Start is called before the first frame update
    void Start()
    {
        int bullets = PlayerController.bulletsFired;
       // bullets = 4;

        string readPath = Application.dataPath + "/score.txt";
        string path = Application.dataPath + "/score.txt";

        if (!File.Exists(path))
        {
            File.WriteAllText(path, "0");
        }

        List<string> fileLines = File.ReadAllLines(readPath).ToList();

        for (int i = 0; i < 10; i++)
        {
            scoreArray[i] = int.Parse(fileLines[i]);
           // Debug.Log(fileLines[i]);
           // Debug.Log(scoreArray[i]);
        }

        for (int i = 9; i > -1; i--)
        {
            if (bullets <= scoreArray[i])
            {
                insertPosition = i;

            }
        }

        Debug.Log("insert" + insertPosition);

        for (int i = 9; i > -1; i--)
        {
            if (i == 9 && insertPosition <= i)
            {
                scoreArray[9] = 0;
            }
            if (insertPosition < scoreArray[i] && i != 9)
            {
                scoreArray[i + 1] = scoreArray[i]; 
            }


            Debug.Log("cringle" + scoreArray[i]);


           
        }

        scoreArray[insertPosition] = bullets;
        scoreText1.text = scoreArray[0].ToString();
        scoreText2.text = scoreArray[1].ToString();
        scoreText3.text = scoreArray[2].ToString();
        scoreText4.text = scoreArray[3].ToString();
        scoreText5.text = scoreArray[4].ToString();
        scoreText6.text = scoreArray[5].ToString();
        scoreText7.text = scoreArray[6].ToString();
        scoreText8.text = scoreArray[7].ToString();
        scoreText9.text = scoreArray[8].ToString();
        scoreText10.text = scoreArray[9].ToString();

        string content = "cringe";

        File.Delete(path);
        for (int i = 0; i < 10; i++)
        {
            content = scoreArray[i] + "\n";
            File.AppendAllText(path, content);
        }
        makeRandomName();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void makeRandomName()
    {
        string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string nameString = "";

        for (int i = 0; i < 3; i++)
        {
            nameString += characters[Random.Range(0, 26)];
        }

        Debug.Log(nameString);

        string path = Application.dataPath + "/names.txt";

        if (!File.Exists(path))
        {
            File.WriteAllText(path, "AAA");
        }
        string readPath = Application.dataPath + "/names.txt";

        List<string> fileLines = File.ReadAllLines(readPath).ToList();

        fileLines[insertPosition] = nameString;

        string content = "cringe";
        File.Delete(path);
        for (int i = 0; i < 10; i++)
        {
            content = fileLines[i] + "\n";
            File.AppendAllText(path, content);
        }

        nameText1.text = fileLines[0];
        nameText2.text = fileLines[1];
        nameText3.text = fileLines[2];
        nameText4.text = fileLines[3];
        nameText5.text = fileLines[4];
        nameText6.text = fileLines[5];
        nameText7.text = fileLines[6];
        nameText8.text = fileLines[7];
        nameText9.text = fileLines[8];
        nameText10.text = fileLines[9];


    }
}
