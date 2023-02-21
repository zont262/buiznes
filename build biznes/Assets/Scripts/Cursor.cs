using UnityEngine;

public class Cursor : MonoBehaviour
{
    public Transform target; // объект за которым надо следить
    public Transform arrow; // стрелка

    void Update()
    {
        Vector3 targetOnScreen = Camera.main.WorldToViewportPoint(target.position);
        targetOnScreen.x = Mathf.Clamp01(targetOnScreen.x);
        targetOnScreen.y = Mathf.Clamp01(targetOnScreen.y);

        arrow.position = Camera.main.ViewportToWorldPoint(targetOnScreen);
    }
}