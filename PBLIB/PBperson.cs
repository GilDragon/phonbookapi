﻿namespace NpgSqlExample.models
{
    public class Person
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person() {}
        
        public Person(string id, string first_name, string last_name)
        {
            Id = id;
            FirstName = first_name;
            LastName = last_name;
        }
    }
}


























































/*namespace PBLIB;

public class Person
{

    public string Name { get; set; }
    public int Phonenumber {get; set;}

    

    public Person(string n, int pn) {
        this.Name = n;
        this.Phonenumber = pn;
    }
}
// in person data type there are string name and phone number int and name = n phonenumber is pn
public class Phonebook
{
    public List<Person> people {get; set;}

    public Phonebook() {
        this.people = new List<Person>();
        this.people.Add(new Person("Bob", 421971531));
        this.people.Add(new Person("Ella", 422533263));
        this.people.Add(new Person("Lua", 421978531));
        this.people.Add(new Person("GD", 421977531));
        this.people.Add(new Person("Yong", 421991531));
    }
    public List<Person> GetAll() {
        return this.people;
    }
    public void AddPerson(string n, int pn) {
        this.people.Add(new Person(n,pn));
    }

    public Person? FindByName(string searchname) {
        foreach (Person currentperson in this.people)
        {
            if(currentperson.Name == searchname) {
                return currentperson;
            }
        }
        return null;
    }
}
*/