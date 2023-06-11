using MongoDB;
using MongoDB.Bson.Serialization.Attributes;

string dataBaseName = "AddressBook";
MongoCRUD objDB = new MongoCRUD(dataBaseName);

Person objPerson = new Person
{
    FirstName = "Yogesh",
    LastName = "Venkat"
};

objDB.InsertRecord("Users", objPerson);
objDB.LoadRecords<Person>("Users");
Console.ReadLine();


class Person
{
    [BsonId]
    public Guid Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }
}
