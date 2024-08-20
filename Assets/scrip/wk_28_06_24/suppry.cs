using UnityEngine;

public class suppry : Supper_issue
{
    public string TakeEXP;
    public int HungryDecrease;

    void Start()
    {
        Supper = "chiken";
        Sum = 300;
        EXP = 0.3f;
        HungryDecrease = 100;
        DecreaseHunger();
        level();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            DecreaseHunger();
            level();
        }
    }
    void DecreaseHunger()
    {
        Debug.Log($"You decrease hunger by {HungryDecrease} level.");
    }
}

