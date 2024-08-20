using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Potion : Supper_issue
{
    public float duration = 2f;
    public string Ability;

    void Start()
    {
        Supper = "ManaPotion";
        Sum = 1;
        EXP = 1;
        Ability = "ManaUP";
        StartCoroutine(StatusUp());
        level();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            StartCoroutine(StatusUp());
            level();
        }
    }
    IEnumerator StatusUp()
    {
        Debug.Log($"{Ability}");
        yield return new WaitForSeconds(duration);
        Debug.Log("End of buff");
    }
}
