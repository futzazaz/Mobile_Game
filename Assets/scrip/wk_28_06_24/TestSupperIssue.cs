using UnityEngine;

public class TestSupperIssue : MonoBehaviour
{
    void Start()
    {
        
        GameObject foodObject = new GameObject("FoodObject");
        suppry food = foodObject.AddComponent<suppry>();

        GameObject potionObject = new GameObject("PotionObject");
        Potion potion = potionObject.AddComponent<Potion>();
    }
}

