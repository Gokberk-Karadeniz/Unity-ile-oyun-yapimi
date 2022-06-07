using UnityEngine;

public class KameraTakip : MonoBehaviour
{
    public GameObject targetObject;
    public Vector3 cameraOffset;
    void LateUpdate()
    {     
        Vector3 yeniPozisyon = targetObject.transform.position + cameraOffset;
        if (yeniPozisyon.x < -31)
            yeniPozisyon.x = -31;
        transform.position = yeniPozisyon;
    }
}
