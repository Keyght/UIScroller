using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class PersonObject : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _id;
    [SerializeField]
    private TextMeshProUGUI _firstName;
    [SerializeField]
    private TextMeshProUGUI _lastName;
    [SerializeField]
    private Image _gender;
    [SerializeField]
    private Sprite _man;
    [SerializeField]
    private Sprite _woman;
    [SerializeField]
    private TextMeshProUGUI _email;
    [SerializeField]
    private TextMeshProUGUI _iP;


    private Person _person;

    private void Start()
    {
        _id.text = _person.id.ToString();
        _firstName.text = _person.first_name.ToString();
        _lastName.text = _person.last_name.ToString();
        if (_person.gender == "Male")
        {
            _gender.sprite = _man;
        }
        else
        {
            _gender.sprite = _woman;
        }
        _email.text = _person.email.ToString();
        _iP.text = _person.ip_address.ToString();
    }

    public void SetPerson(Person person)
    {
        _person = person;
    }
}