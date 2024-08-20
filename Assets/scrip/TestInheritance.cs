using UnityEngine;

public class TestInheritance : MonoBehaviour
 {
    void Start()
        {
            Character character = new Character { Name = "Charlie", Age = 30 };
            character.Introduce();

            Animal animal = new Animal { Name = "Max", Age = 5 };
            animal.Introduce();

            Human human = new Human { Name = "Alice", Age = 28 };
            human.Introduce();

            Pet pet = new Pet { Name = "Buddy", Age = 3 };
            pet.Introduce();
        }
    }
public class Character : MonoBehaviour
{
    public string Name ;
    public int Age;

    public virtual void Introduce()
    {
        Debug.Log($"My name is {Name} and I am {Age} years old.");
    }
}


public class Animal : Character
{
    public override void Introduce()
    {
        Debug.Log($"I am an animal. My name is {Name} and I am {Age} years old.");
    }
}


public class Human : Character
{
    public override void Introduce()
    {
        Debug.Log($"I am a human. My name is {Name} and I am {Age} years old.");
    }
}


public class Pet : Animal
{
    public override void Introduce()
    {
        Debug.Log($"I am a pet. My name is {Name} and I am {Age} years old.");
    }
}





