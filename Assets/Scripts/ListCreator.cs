using UnityEngine;
using TMPro;

public class ListCreator : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _fileName;
    [SerializeField]
    private GameObject _infoPrefab;

    public void OnButtonClick()
    {
        JSONParser.SetFileName(JSONParser.EncodeNonAsciiCharacters(_fileName.text));
        JSONParser.JSONLoad();
        GenerateList();
    }

    private void GenerateList()
    {
        foreach (var person in JSONParser.Data.data)
        {
            var currentPrefab = Instantiate(_infoPrefab);
            currentPrefab.GetComponent<PersonObject>().SetPerson(person);
            currentPrefab.transform.SetParent(this.transform);
            currentPrefab.transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
