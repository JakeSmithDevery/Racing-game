using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 400;
    float currentSpeed;

    public float rotationSpeed = 2;
    float h, v;

    Rigidbody2D body;
    
    float modifierLastsFor = 0;
    bool modifierActive = true;
    float elapsed = 0;

    public string HorizontalInputName = "Horizontal";
    public string VerticalInputName = "Vertical";
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        currentSpeed = movementSpeed;
        
    }

    // Update is called once per frame
    void Update()
    {
      if(modifierActive)
      {
            elapsed += Time.deltaTime;

            if(elapsed >= modifierLastsFor)
            {
                modifierActive = false;
                currentSpeed = movementSpeed;
                elapsed = 0;
            }
      }

      h = Input.GetAxisRaw(HorizontalInputName);
      v = Input.GetAxisRaw(VerticalInputName);


        transform.Rotate(0, 0, -h * rotationSpeed);
    }

    private void FixedUpdate()
    {
        body.velocity = transform.up * v * currentSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Modifier"))
        {
            SpeedModifier mod = collision.GetComponent<SpeedModifier>();

            currentSpeed = movementSpeed * mod.Modifier;

            modifierLastsFor = mod.LastFor;
            modifierActive = true;
            elapsed = 0;
        }
    }
}
