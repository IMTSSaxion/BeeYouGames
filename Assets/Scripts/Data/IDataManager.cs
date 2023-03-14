using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IDataManager
{
    void Save();
    void Load();
    void WriteToFile(string pFileName);
    string ReadFromFile();
    string GetFilePath();
}
