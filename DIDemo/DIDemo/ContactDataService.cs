namespace DIDemo
{
    public class ContactDataService
    {
        List<Person> _contacts;

        public ContactDataService()
        {
            _contacts = new List<Person>();
            _contacts.Add(new Person("John","Doe"));
            _contacts.Add(new Person("Jane", "Doe"));
            _contacts.Add(new Person("John", "Smith"));
            _contacts.Add(new Person("John", "Smith"));
        }
        public List<Person> GetContacts()
        {
            return _contacts;
        }
    }
}