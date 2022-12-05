using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ImageUP : MonoBehaviour
{
    private static Texture2D LoadPNG(string filePath)
    {
            Texture2D tex = null;
            byte[] fileData;

            if (System.IO.File.Exists(filePath))
            {
                fileData = System.IO.File.ReadAllBytes(filePath);
                tex = new Texture2D(2, 2);
                tex.LoadImage(fileData); //..this will auto-resize the texture dimensions.
            }
            return tex;
    }
}
