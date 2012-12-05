using UnityEngine;
using System.Collections;

public class SimpleColorPicker : MonoBehaviour
{

    public Texture2D ColorTexture;
    public Material ColorMaterial;
    private Color _colorValue;

    void OnMouseDown()
    {
        Vector3 textureWheelPos = Camera.mainCamera.ViewportToScreenPoint(transform.position);
        Vector3 pos = textureWheelPos - Input.mousePosition;

        _colorValue = ColorTexture.GetPixel(ColorTexture.width / 2 - Mathf.FloorToInt(pos.x), ColorTexture.height / 2 - Mathf.FloorToInt(pos.y));
        ColorMaterial.color = _colorValue;
    }
}
