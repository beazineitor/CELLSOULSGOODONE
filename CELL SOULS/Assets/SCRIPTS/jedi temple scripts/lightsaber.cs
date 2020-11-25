using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightsaber : MonoBehaviour
{
    LineRenderer lineRend;
    public Transform startPos;
    public Transform endPos;
    private float textureOffset = 0f;
    private bool on = true;
    private Vector3 endPositionExtendedPosition;
    // Start is called before the first frame update
    void Start()
    {
        lineRend = GetComponent<LineRenderer>();
        endPositionExtendedPosition = endPos.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (on)
            {
                on = false;
            }
            else
            {
                on = true;
            }

        }
        if (on)
        {
            endPos.localPosition = Vector3.Lerp(endPos.localPosition, endPositionExtendedPosition, Time.deltaTime * 5f);
        }
        else
        {
            endPos.localPosition = Vector3.Lerp(endPos.localPosition, startPos.localPosition, Time.deltaTime * 5f);
        }
        lineRend.SetPosition(0, startPos.position);
        lineRend.SetPosition(1, endPos.position);
        textureOffset -= Time.deltaTime * 2f;
        if (textureOffset <= 10f)
        {
            textureOffset += 10f;
        }
        lineRend.sharedMaterials[1].SetTextureOffset("_MainText", new Vector2(textureOffset,0f));
    }
}
