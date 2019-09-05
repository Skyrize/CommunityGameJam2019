using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SkinComponent : MonoBehaviour
{
    [Header("Sprite / Path to animation controller")]
    public Sprite[] skins;
    public string[] animators;

    public void Change(int index)
    {
        if (index >= 0 && index < skins.Length) {
            GetComponent<SpriteRenderer>().sprite = skins[index];
        }
        if (index >= 0 && index < animators.Length) {
            GetComponent<Animator>().runtimeAnimatorController = Resources.Load(animators[index]) as RuntimeAnimatorController;
        }
    }
}
