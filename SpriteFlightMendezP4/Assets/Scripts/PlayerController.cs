using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((Mouse.current.leftButton.isPressed)
        {
            Debug.log("Left mouse button was pressed");
        }
        }
    }
}
