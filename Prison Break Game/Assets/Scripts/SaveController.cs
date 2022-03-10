using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveController /*: MonoBehaviour*/
{

    public static void saveData()
    {
        BinaryFormatter formatter = new BinaryFormatter();

        string path = Application.persistentDataPath + "/save.cool";

        FileStream stream = new FileStream(path, FileMode.Create);

        GameManager data = new GameManager();

        formatter.Serialize(stream, data);
        stream.Close();


    }

    public static GameManager returnData()
    {
        string path = Application.persistentDataPath + "/save.cool";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            GameManager data = formatter.Deserialize(stream) as GameManager;
            stream.Close();

            return data;
        }
        else
        {
            Debug.Log("save file broken");
            return null;

        }
    }
    // Start is called before the first frame update
    //void Start()
    //{
        
    //}

    //// Update is called once per frame
    //void Update()
    //{
        
    //}
}
