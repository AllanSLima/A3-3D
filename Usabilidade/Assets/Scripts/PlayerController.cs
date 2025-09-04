//Biblioteca usadas
using UnityEngine;

//: MonoBehaviour est� herdando fun��es de PlayerController
public class PlayerController : MonoBehaviour
{
    //A e D controla o eixo X
    //W e S controla o eixo Z

    //Acessando o componente de gravidade via c�digo
    public Rigidbody rig;
    public float speed = 40;
    public float rotSpeedX = 3;   
    public float rotSpeedY = 3;       
    public float jumpForce = 10;
    public LayerMask floorLayers;

    public Transform aim;

    //void � uma fun��o que que n�o retorna um valor
    void Start()
    {
        
    }

    // Update vai ser executado a cada frame
    void Update()
    {
        aim.localEulerAngles = new Vector3(
            aim.localEulerAngles.x - Input.GetAxis("Mouse Y") * rotSpeedY,
            0,
            0);

        transform.eulerAngles = new Vector3(
            0,
            transform.eulerAngles.y + Input.GetAxis("Mouse X") * rotSpeedX,
            0);


        if(Physics.Raycast(transform.position, Vector3.down, 1.1f, floorLayers))  
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                 rig.linearVelocity = new Vector3(
                        rig.linearVelocity.x,
                        jumpForce,
                        rig.linearVelocity.z);
            }
        }
    }

    //
    void FixedUpdate()
    {
        Vector3 vX = Input.GetAxis("Horizontal") * speed * transform.right;
        Vector3 vY = rig.linearVelocity.y * transform.up;
        Vector3 vZ = Input.GetAxis("Vertical") * speed * transform.forward;

        rig.linearVelocity = vX + vY + vZ;
    }
}