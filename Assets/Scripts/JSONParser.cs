using UnityEngine;
using System.IO;
using System.Text;

public static class JSONParser
{
    public static PersonData Data 
    {
        get
        {
            return _data;
        }
    }

    private static string _fileName;
    private static PersonData _data = new PersonData();
    private static string _jsonPathTo = Application.streamingAssetsPath;
    private static string _path 
    { 
        get 
        { 
            return (_jsonPathTo + _fileName); 
        } 
    }

    public static void JSONLoad()
    {
        if (File.Exists(_path))
        {
            string jsonString = File.ReadAllText(_path);
            _data = JsonUtility.FromJson<PersonData>(jsonString);
        }
        else
        {
            Debug.Log("File does not exist");
        }
    }

    public static void SetFileName(string fileName)
    {
        _fileName = "/" + fileName + ".json";
    }

    public static string EncodeNonAsciiCharacters(string value)
    {
        StringBuilder sb = new StringBuilder();
        foreach (char c in value)
        {
            if (c < 128)
            {
                sb.Append(c);
            }
        }
        return sb.ToString();
    }
}
