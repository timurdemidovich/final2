using UnityEngine;
using UnityEngine.UI;

public class PlayerControler : MonoBehaviour
{
    public float MaxHealth;
    public float MaxMana;
    public float Health;
    public float Mana;
    [SerializeField] private float NormalSpeed;
    [SerializeField] private float RunSpeed;
    float Speed;
    private float x;
    private float y;

    private Rigidbody2D rb;

    [SerializeField] private Image HelthBar;
    [SerializeField] private Image ManaBar;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Speed = RunSpeed;
        }
        else
        {
            Speed = NormalSpeed;
        }

        HelthBar.fillAmount = Health / MaxHealth;
        ManaBar.fillAmount = Mana / MaxMana;
    }

    private void FixedUpdate()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(x * Speed, y*Speed);
    }
}