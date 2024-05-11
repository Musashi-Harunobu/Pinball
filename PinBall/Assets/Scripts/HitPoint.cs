using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPoint : MonoBehaviour
{
    [SerializeField] private int pointsPerHit = 100;
    private void OnCollisionEnter(Collision collision)
    {
        Global.GameScore += pointsPerHit;
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Шар перестал соприкасаться с " + this.name);
    }
}
