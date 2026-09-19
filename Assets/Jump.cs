using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class Jump : MonoBehaviour
{
    public UnityEvent jumping;
    public TextMeshProUGUI text;
    public void JumpAction(InputAction.CallbackContext context)
    {
        Debug.Log("jumped");
        text.text = "pretend this jumped so I don't have to program anything else, also you can toggle the other stuff by \"jumping\" again";

        jumping.Invoke();


    }
}
