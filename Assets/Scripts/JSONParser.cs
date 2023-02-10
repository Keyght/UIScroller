using UnityEngine;
using System.IO;

public class JSONParser : MonoBehaviour
{
    [SerializeField]
    private string _fileName = "test_task_mock_data.json";

    private PersonData _data;
    private string _jsonPathTo = "Assets/JSON/";

    private void Awake()
    {
        _data = new PersonData();
    }

    private void Start()
    {
        string jsonString = File.ReadAllText(_jsonPathTo + _fileName);
        _data = JsonUtility.FromJson<PersonData>(jsonString);

        File.WriteAllText(_fileName, JsonUtility.ToJson(_data));
    }
}
