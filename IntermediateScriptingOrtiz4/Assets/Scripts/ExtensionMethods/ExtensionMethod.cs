using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ExtensionMethod
{
    public static void ResetTransformation(this Transform trans)
    {
        trans.position = Vector3.zero;
        trans.rotation = Quaternion.identity;
        trans.localScale = new Vector3(1f, 1f, 1f);
    }
}
