using Unity.VisualScripting;
using UnityEngine;

public class Supper_issue : MonoBehaviour
{
    public string Supper ;
    public int Sum ;
    public float EXP;
    public int Exp;

    public void level ()
    {
        if (EXP >= 0)
        {
            Debug.Log($"You Have {Supper} for getting {EXP} ");
            Sum--;
        }
        else
        {
            Debug.Log($"Go die F youself");
        }
    }

}
