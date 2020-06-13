using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeShaders : MonoBehaviour
{
    public Shader _shader;

    // Start is called before the first frame update
    void Start()
    {
        ChangeShader();
    }

    private void ChangeShader()
    {     
        gameObject.GetComponent<Renderer>().material.shader = _shader;
    }
}
