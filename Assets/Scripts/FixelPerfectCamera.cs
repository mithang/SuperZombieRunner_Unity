using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixelPerfectCamera : MonoBehaviour {

    public static float pixelsToUnits = 1f;
    public static float scale = 1f;

    //Kéo Script vào màn hình Main Camera và áp đặt camera có kích thước là 240,160
    public Vector2 nativeResolution = new Vector2(240, 160);

    private void Awake()
    {
        var camera = GetComponent<Camera>();
        if (camera.orthographic)
        {
            scale = Screen.height / nativeResolution.y;
            pixelsToUnits *= scale;
            camera.orthographicSize = (Screen.height / 2.0f) / pixelsToUnits;
        }
    }
}
