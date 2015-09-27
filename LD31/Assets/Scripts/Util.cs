using UnityEngine;
using System.Collections;

public class Util {

    public static int GetLayerMask(string layerName)
    {
        return LayerMask.GetMask(new string[] { layerName });
    }
}
