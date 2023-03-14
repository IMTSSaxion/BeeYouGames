using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class NPCSpriteData : MonoBehaviour, IDataManager
{
    [SerializeField]
    private TextAsset textFile;

    private const string fileName = "npcSprites.txt";
    private string streamingAssetPath = Application.streamingAssetsPath;

    public string GetFilePath() => Application.persistentDataPath + "/" + fileName;

    public static NPCSpriteData Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Debug.LogError("Multiple Instances found", this);
    }

    private void Start()
    {
        
    }

    public Sprite GetNPCImage(string pNPCName)
    {
        string[] lines = textFile.text.Split(';');

        for (int i = 0; i < lines.Length; i++)
        {
            if (!lines[i].Contains(pNPCName)) continue;

            

            //string line = lines[i];
            ////string tagText = choiceText.Substring(stringIndex).Replace("$", "");
            //int stringIndex = line.IndexOf("= ", 0);
            //line = line.Substring(stringIndex).Replace("= ", "");
            //Debug.Log("returning sprite: " + line);


            //Sprite sprite = Resources.Load<Sprite>("Sprites/Art2.png");
            //return sprite;
        }

        Debug.LogError("Couldn't find NPC Image", this);
        return null;
    }

    public void Load()
    {
        throw new System.NotImplementedException();
    }

    public string ReadFromFile()
    {
        

        return textFile.text;

        //string path = GetFilePath();
        //if (File.Exists(path))
        //{
        //    using (StreamReader reader = new StreamReader(path))
        //    {
        //        string fileContent = reader.ReadToEnd();
        //        return fileContent;
        //    }
        //}
        //else
        //{
        //    Debug.LogWarning("File not found");
        //    return "ERROR FILE NOT FOUND";
        //}
    }

    public void Save()
    {
        throw new System.NotImplementedException();
    }

    public void WriteToFile(string pFileName)
    {
        throw new System.NotImplementedException();
    }
}
