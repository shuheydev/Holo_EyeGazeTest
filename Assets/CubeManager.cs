using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour
{
    private bool _isVisible;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleVisibility()
    {
        _isVisible = !_isVisible;
        gameObject.SetActive(_isVisible);
    }
}
