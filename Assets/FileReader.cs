using UnityEngine;
using UnityEditor;
using System.IO;
using System.Collections.Generic;

public class FileReader : MonoBehaviour {

    public TextAsset nameTextFile;

    private List<string> names;

    void Start()
    {
        ReadFromFile();
    }
    
    void WriteToFile()
    {
        File.WriteAllText(Application.dataPath + "/" + nameTextFile.name + ".txt", string.Join("\n", names.ToArray()));
        AssetDatabase.Refresh();        
    }

    void ReadFromFile()
    {
        names = new List<string>(nameTextFile.text.Split(new[] { '\n', '\r' }, System.StringSplitOptions.RemoveEmptyEntries));
    }
    
    public string GetName()
    {
        return names[Random.Range(0, names.Count)];
    }

    public void RemoveName(string name)
    {
        int index = -1;
        for (int i = 0; i < names.Count; i++)
        {
            if (names[i] == name)
            {
                index = i;
            }
        }

        if (index >= 0)
        {
            names.RemoveAt(index);
        }

        WriteToFile();
    }
}
