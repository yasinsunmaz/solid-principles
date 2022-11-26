﻿using SRP.SingleResponsibilityPrinciple.DTO;

namespace SRP.SingleResponsibilityPrinciple.InappropriateSRP
{
  //TODO: Inappropriate SRP - Uygunsuz SRP
  public class Database
  {
    public void Connect()
    {
      Console.WriteLine("Veritabanı bağlantısı yapıldı");
    }

    public void Disconnect()
    {
      Console.WriteLine("Veritabanı bağlantısı kapatıldı");
    }

    public List<PersonDTO> GetPersons()
    {
      List<PersonDTO> persons = new List<PersonDTO>();
      persons.Add(
        new PersonDTO() { Id = 1, FirstName = "Yasin", LastName = "SUNMAZ", Country = "Türkiye" }
      );

      persons.Add(
        new PersonDTO() { Id = 2, FirstName = "Tayfun", LastName = "DUMAN", Country = "Türkiye" }
      );

      persons.Add(
        new PersonDTO() { Id = 3, FirstName = "Melih", LastName = "KABAKÇI", Country = "Türkiye" }
      );

      return persons;
    }

    public PersonDTO GetPersonInfo(int personId)
    {
      PersonDTO person = new PersonDTO();

      var persons = GetPersons();

      var personInfo = persons.Where(x => x.Id == personId).FirstOrDefault();

      if (personInfo != null)
        person = personInfo;

      return person;
    }
  }
}