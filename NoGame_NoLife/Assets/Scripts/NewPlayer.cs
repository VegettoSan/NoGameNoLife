using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlayer : MonoBehaviour
{
    public CharacterController controller;
    public Transform cam;

    public float speed = 6f, Gravity = 6f, JumpSpeed;

    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity, horizontal, vertical;

    Vector3 _gravity = Vector3.zero, moveDir;

    Animator Anim;

    Vector3 direction;
    private void Awake()
    {
        Anim = GetComponentInChildren<Animator>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerControl();

        if (controller.isGrounded)
        {
            AnimMovement(horizontal, vertical);
            Anim.SetBool("Salto", false);
            Anim.SetBool("SaltoRun", false);
            Anim.SetBool("Andar", true);

            if (Input.GetButtonDown(PlayerPrefs.GetString("A")))
            {
                _gravity.y = JumpSpeed;

                Debug.Log("Salto");
            }
        }
        else
        {
            float Movement = horizontal + vertical;

            if(Movement != 0f)
            {
                Anim.SetBool("SaltoRun", true);
                Anim.SetBool("Andar", false);
            }
            else
            {
                Anim.SetBool("Salto", true);
                Anim.SetBool("Andar", false);
            }
        }
        _gravity.y -= Gravity * Time.deltaTime;
    }

    void PlayerControl()
    {
        horizontal = Input.GetAxis(PlayerPrefs.GetString("MovimientoX"));
        vertical = Input.GetAxis(PlayerPrefs.GetString("MovimientoY"));
        direction = new Vector3(horizontal, 0f, vertical)/*.normalized*/;

        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDir.normalized * speed * Time.deltaTime + _gravity);
        }
        else
        {

            controller.Move(_gravity);
        }
    }
    void AnimMovement(float H, float V)
    {
        Anim.SetFloat("Horizontal", H);
        Anim.SetFloat("Vertical", V);
    }

    public void Apuntar()
    {
        float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
        float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, 0f);
        transform.rotation = Quaternion.Euler(0f, angle, 0f);
    }
}
