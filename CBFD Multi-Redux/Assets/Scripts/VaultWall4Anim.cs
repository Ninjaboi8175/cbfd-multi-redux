using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaultWall4Anim : MonoBehaviour
{
    public Material animatedLightMaterial;
    public Light animatedLightObject1;
    public Light animatedLightObject2;

    Color originalColor;
    Color offColor;

    float originalIntensity;

    // Start is called before the first frame update
    void Start()
    {
        //animatedLightMaterial = gameObject.GetComponent<MeshRenderer>().materials[3];
        Debug.Log("Name: " + animatedLightMaterial);

        originalColor = animatedLightMaterial.GetColor("_EmissionColor");
        offColor = new Color(0.0f,0.0f,0.0f);

        originalIntensity = animatedLightObject1.intensity;
    }

    // Update is called once per frame
    void Update()
    {
        animatedLightMaterial.SetColor("_EmissionColor", Color.Lerp(originalColor, offColor, Mathf.PingPong(Time.time / 2, 1)));
        animatedLightObject1.intensity = Mathf.Lerp(originalIntensity, 0.0f, Mathf.PingPong(Time.time / 2, 1));
        animatedLightObject2.intensity = Mathf.Lerp(originalIntensity, 0.0f, Mathf.PingPong(Time.time / 2, 1));
    }
}
