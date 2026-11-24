using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public InputAction fireAction;
    public bool canDog = true;
    public float cooldown = 2f;

    // Start is called before the first frame update
    void Start()
    {
        fireAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (fireAction.triggered)
        {
            if (canDog)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                canDog = false;
                Invoke("enableAction", cooldown);
            }
        }
    }

    void enableAction()
    {
        canDog = true;
    }
}
