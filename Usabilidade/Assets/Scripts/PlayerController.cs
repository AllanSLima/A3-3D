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
    public float rotSpeed = 3;

    //void � uma fun��o que que n�o retorna um valor
    void Start()
    {
        
    }

    // Update vai ser executado a cada frame
    void Update()
    {
        transform.eulerAngles = new Vector3(
        0,
        transform.eulerAngles.y + Input.GetAxis("Mouse X") * rotSpeed,
        0);
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
