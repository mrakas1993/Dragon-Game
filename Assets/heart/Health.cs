using UnityEngine;

public class Health : MonoBehaviour
{
    public float startingHealth;
    public float currentHealth;
    private Animator anim;
    private bool dead = false;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = startingHealth;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage,0, startingHealth);

        if(currentHealth > 0)
        {
            //�������� �� ��������� �����
        }
        if(currentHealth <= 0)
        {
            //�������� ������
            dead = true;
            GetComponent<PlayerController>().enabled = false;
        }


    }

    public void AddHealth(float _value)
    {
        currentHealth = Mathf.Clamp(currentHealth + _value, 0, startingHealth);
    }
}
