using System;
using System.Collections;
using System.Collections.Generic;
using PersonRepository;
using PersonRepository.Interfaces;
using PersonRepository.Entities;

class MetodoPersonValidator : IPersonRepositoryBasic
{
    public List<Person> People { get; set; }

    public bool ExistPerson(int id){
        for(int i = 0; i < People.Count; i++){
            if(id == People[i].Id){
                return true;
            }   
        }
        return false;
    }

    public int FindIdPerson(int id){        
            for(int i = 0; i < People.Count; i++){
                if(ExistPerson(id)){
                    return i;
                }
            }
        return -1;
    }        


    public void Add(Person person)
    {
        if(ExistPerson(person.Id)){
            Console.WriteLine("La persona con ese ID ya existe");
        }
        else{
            People.Add(person);
        }
    }

    public void Delete(int id)
    {
        int posicion = FindIdPerson(id);
        People.RemoveAt(posicion);
    }

    public int GetCountRangeAges(int min, int max)
    {
        int contadorPersonaRango = 0;
        for(int i = 0; i < People.Count; i++){
            if(People[i].Age >= min && People[i].Age <= max){
                contadorPersonaRango++;
            }
        }
        return contadorPersonaRango;
    }

    public List<Person> GetFiltered(string name, int age, string email)
    {
        throw new NotImplementedException();
    }

    public Person GetPerson(int id)
    {
        for(int i = 0; i < People.Count; i++){
            if(ExistPerson(id) == true){
                return 
            }
        }
    }

    public void Update(Person person)
    {
        throw new NotImplementedException();
    }
}