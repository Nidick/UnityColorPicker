using UnityEngine;
using System.Collections;

public class NGUIColorPicker : MonoBehaviour
{

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public Texture2D ColorTexture;
    public Material ColorMaterial;
    private Color _colorValue;

    void OnPress(bool isPress)
    {
        UpdateColor();
    }

    void OnDrag(Vector2 delta)
    {
        UpdateColor();
    }

    private void UpdateColor()
    {
        Vector3 textureWheelPos = UICamera.currentCamera.WorldToScreenPoint(transform.position);
        Vector2 pos = UICamera.lastTouchPosition - new Vector2(textureWheelPos.x, textureWheelPos.y);
        //Debug.Log(pos);
        _colorValue = ColorTexture.GetPixel(Mathf.FloorToInt(pos.x) + ColorTexture.width / 2, Mathf.FloorToInt(pos.y) + ColorTexture.height / 2);
        ColorMaterial.color = _colorValue;

        //GameObject.Find("Controller").SendMessage("SetColor", ColorValue);
    }
}
