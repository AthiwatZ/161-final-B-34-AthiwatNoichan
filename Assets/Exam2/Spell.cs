using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
    public virtual void Cast()
    {
        Debug.Log("Cast Basic Spell");
    }

    public void Cast(string target)
    {

    }

    public void Cast(string spell, int power)
    {

    }
}
