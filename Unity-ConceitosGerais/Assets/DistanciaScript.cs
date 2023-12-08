using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanciaScript : MonoBehaviour
{
    public Transform sprite_a;
    public Transform sprite_b;

    void Update()
    {
        Vector2 direction = sprite_b.position - sprite_a.position;
        float distance = direction.magnitude;   


        Debug.DrawLine(sprite_b.position, direction, Color.red);
        sprite_a.transform.Translate(direction * 2.0f * Time.deltaTime);
    }
}
