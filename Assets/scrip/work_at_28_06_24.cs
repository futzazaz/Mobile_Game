using System.Xml.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class work_at_28_06_24 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public class Character : MonoBehaviour
    {
        public string futanari ;
        public int Age ;

        public virtual void Introduce()
        {
            Debug.Log($"My name is {futanari} and I am {10} years old.");
        }
    }

    
    public class Animal : Character
    {
        public override void Introduce()
        {
            Debug.Log($"I am an animal. My name is {futanari} and I am {Age} years old.");
        }
    }

    
    public class Human : Character
    {
        public override void Introduce()
        {
            Debug.Log($"I am a human. My name is {futanari} and I am {Age} years old.");
        }
    }

    
    public class Pet : Animal
    {
        public override void Introduce()
        {
            Debug.Log($"I am a pet. My name is {futanari} and I am {Age} years old.");
        }
    }

   
    public class TestInheritance : MonoBehaviour
    {
        void Start()
        {
            Character character = new Character { futanari = "Charlie", Age = 30 };
            character.Introduce();

            Animal animal = new Animal { futanari = "Max", Age = 5 };
            animal.Introduce();

            Human human = new Human { futanari = "Alice", Age = 28 };
            human.Introduce();

            Pet pet = new Pet { futanari = "Buddy", Age = 3 };
            pet.Introduce();
        }
    }
} 

