using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text.Json;
using Models;

namespace FamilyManagerApp.Data
{
    public class FamilyJSONData : IFamilyData {
        private string FamilyFile = "Data/families.json";
        private IList<Family> _families;
        private IList<Person> _people;
        private IList<Pet> _pets;

        public FamilyJSONData() {
            if (!File.Exists(FamilyFile)) {
                WriteFamiliesToFile();
            }
            else {
                string content = File.ReadAllText(FamilyFile);
                _families = JsonSerializer.Deserialize<List<Family>>(content);
                _people = new List<Person>();
                _pets = new List<Pet>();
                if (_families != null)
                    foreach (Family f in _families)
                    {
                        foreach (Adult adult in f.Adults)
                            _people.Add(adult);
                        foreach (Child child in f.Children)
                            _people.Add(child);
                        foreach (Pet pet in f.Pets)
                            _pets.Add(pet);
                    }
            }
        }

        public IList<Family> GetFamilies() {
            List<Family> fam = new List<Family>(_families);
            return fam;
        }

        public IList<Person> GetPeople() {
            List<Person> people = new List<Person>(_people);
            return people;
        }

        public IList<Adult> GetAdults() {
            List<Adult> adults = new List<Adult>();
            foreach (var fam in _families) {
                adults.AddRange(fam.Adults);
            }
            return adults;
        }

        public IList<Child> GetChildren() {
            List<Child> children = new List<Child>();
            foreach (var fam in _families) {
                children.AddRange(fam.Children);
            }
            return children;
        }

        public IList<Pet> GetPets() {
            List<Pet> pets = new List<Pet>(_pets);
            foreach (var fam in _families) {
                pets.AddRange(fam.Pets);
            }
            return pets;
        }

        public void AddFamily(Family family) {
            Family fam = _families.FirstOrDefault(f => f.HouseNumber == family.HouseNumber
                                                      && f.StreetName.Equals(family.StreetName));
            if (fam == null)
                _families.Add(family);
            else 
                throw new Exception("The family already exists");
            WriteFamiliesToFile();
        }

        public void AddAdult(Adult adult, Family family) {
            int max = _people.Max(p => p.Id);
            adult.Id = (++max);
            _people.Add(adult);
            family.Adults.Add(adult);
            WriteFamiliesToFile();
        }

        public void AddChild(Child child, Family family) {
            int max = _people.Max(p => p.Id);
            child.Id = (++max);
            _people.Add(child);
            family.Children.Add(child);
            WriteFamiliesToFile();
        }
        

        public void AddPet(Pet pet, Family family, Child child)
        {
            int max = _pets.Max(p => p.Id);
            pet.Id = (++max);
            _pets.Add(pet);
            child.Pets.Add(pet);
            family.Pets.Add(pet);
            WriteFamiliesToFile();
        }
        
        public void AddPet(Pet pet, Family family) {
            int max = _pets.Max(p => p.Id);
            pet.Id = (++max);
            _pets.Add(pet);
            family.Pets.Add(pet);
            WriteFamiliesToFile();
        }

        public void RemoveFamily(string streetName, int houseNumber) {
            Family family = _families.First(f => f.StreetName.Equals(streetName)
                                                && f.HouseNumber == houseNumber);
            _families.Remove(family);
            WriteFamiliesToFile();
        }

        public void RemovePerson(int personId) {
            Person person = _people.First(p => p.Id == personId);
            _people.Remove(person);
            WriteFamiliesToFile();
        }

        public void RemovePet(int petId) {
            Pet pet = _pets.First(p => p.Id == petId);
            _pets.Remove(pet);
            WriteFamiliesToFile();
        }

        public Family GetFamily(string streetName, int houseNumber) {
            return _families.FirstOrDefault(f => f.StreetName.Equals(streetName)
                                                && f.HouseNumber == houseNumber);
        }
        

        public Person GetPerson(int id) {
            return _people.FirstOrDefault(p => p.Id == id);
        }

        public Person GetPersonByIdFirstLastName(int id, string firstname, string lastname) {
            return _people.FirstOrDefault(
                p => p.Id == id && p.FirstName.Equals(firstname) && p.LastName.Equals(lastname));
        }

        public Pet GetPet(int petId) {
            return _pets.FirstOrDefault(p => p.Id == petId);
        }

        public void UpdateFamily(Family family) {
            Family fam = _families.First(f => f.HouseNumber == family.HouseNumber
                                             && f.StreetName.Equals(family.StreetName));
            fam.HouseNumber = family.HouseNumber;
            fam.StreetName = family.StreetName;
            WriteFamiliesToFile();
        }

        public void UpdatePerson(Person person) {
            Person per = _people.First(p => p.Id == person.Id);
            per.LastName = person.LastName;
            per.HairColor = person.HairColor;
            per.Age = person.Age;
            per.Height = person.Height;
            per.Weight = person.Weight;
            WriteFamiliesToFile();
        }

        public void UpdatePet(Pet pet) {
            Pet p = _pets.First(p => p.Id == pet.Id);
            p.Age = pet.Age;
            WriteFamiliesToFile();
        }

        public IList<string> GetEyeColors() {
            return _people.Select(p => p.EyeColor).Distinct().ToList();
        }

        public IList<string> GetHairColors() {
            return _people.Select(p => p.HairColor).Distinct().ToList();
        }

        private void WriteFamiliesToFile() {
            string familiesAsJson = JsonSerializer.Serialize(_families, new JsonSerializerOptions() {
                WriteIndented = true
            });
            File.WriteAllText(FamilyFile, familiesAsJson);
        }
    }
}