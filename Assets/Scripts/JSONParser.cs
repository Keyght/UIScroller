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

    public static bool IsJSONLoading()
    {
        UnityEngine.Networking.UnityWebRequest www = UnityEngine.Networking.UnityWebRequest.Get(_path);
        www.SendWebRequest();
        string jsonString = www.downloadHandler.text;
        _data = JsonUtility.FromJson<PersonData>(jsonString);
        if (_data is null)
        {
            Debug.Log("Json is not Loaded");
            return false;
        }
        else
        {
            Debug.Log("Json is Loaded");
            return true;
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
