using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private DynamicJoystick joystik;
    [SerializeField] private Animator anim;
    public GameObject cursor;
    
    public int Speed;
    
    public GameObject cel;
    
    public GameObject[] Gumss;
    
    void Start()
    {
        
    }

   

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector3(joystik.Horizontal * Speed, rb.velocity.y, joystik.Vertical * Speed);

        if(joystik.Horizontal != 0 || joystik.Vertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(rb.velocity);
            anim.SetBool("run", true);
        }
        else
        {
            anim.SetBool("run", false);
        }
        
    }

    public void SpeedPlus()
    {
        Speed++;
    }

    public void Update()
    {

        

        
    }

    

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Buy1")

            col.gameObject.GetComponent<Buy>().StartCor();
            cursor.SetActive(false);
    }





}
