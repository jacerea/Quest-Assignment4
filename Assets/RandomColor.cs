using UnityEngine;

public class RandomColor : MonoBehaviour
{
    void Start()
    {
        var rend = GetComponentInChildren<Renderer>();
        if (rend != null)
            rend.material.color = Random.ColorHSV(0f, 1f, 0.6f, 1f, 0.7f, 1f);
    }
}