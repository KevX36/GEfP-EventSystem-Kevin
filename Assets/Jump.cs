using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class Jump : MonoBehaviour
{
    
    public TextMeshProUGUI text;
    public void Jumping(InputAction.CallbackContext context)
    {
        Debug.Log("jumped");
        text.text = "pretend this jumped so I don't have to program anything else, regardless you can toggle the other stuff by \"jumping\" again";

    }
}
