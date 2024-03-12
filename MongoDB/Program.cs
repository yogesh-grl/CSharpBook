using MongoDB;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

string dataBaseName = "AddressBook";
MongoCRUD objDB = new MongoCRUD(dataBaseName);

Person objPerson = new Person
{
    FirstName = "Yogesh",
    LastName = "Venkat"
};

var bsonDoc = new BsonDocument()
{
    {"ID","MD01" },
    {"Name","Yogesh" }
};


objDB.InsertRecord("Users", objPerson);
objDB.LoadRecords<Person>("Users");

objDB.DeleteRecord<Person>("Users", new Guid("df183936-302f-4b50-89b3-782785caf0c1"));
Console.ReadLine();


class Person
{
    [BsonId]
    public Guid Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }
}
