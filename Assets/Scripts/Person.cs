[System.Serializable]
public class Person
{
    public int id;
    public string first_name;
    public string last_name;
    public string email;
    public bool gender;
    public string ip_address;

    public Person(int id, string first_name, string last_name, string email, bool gender, string ip_address)
    {
        this.id = id;
        this.first_name = first_name;
        this.last_name = last_name;
        this.email = email;
        this.gender = gender;
        this.ip_address = ip_address;
    }
}