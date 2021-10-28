using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHighlight : MonoBehaviour
{

    private MeshRenderer meshRenderer;
    private Material originalMaterial;

    public Material highlightMaterial;
    
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        originalMaterial = meshRenderer.material;
    }

     void OnMouseOver()
    {
        meshRenderer.material = highlightMaterial;
    }

    private void OnMouseExit()
    {
        meshRenderer.material = originalMaterial;
    }


}
