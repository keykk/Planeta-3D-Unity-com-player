using UnityEngine;

public class PlanetGravity : MonoBehaviour
{
    public float gravityStrength = 9.81f; // Força da gravidade

    private void OnTriggerStay(Collider other)
    {
        if (other.attachedRigidbody != null)
        {
            // Calcula a direção da força (do objeto para o centro do planeta)
            Vector3 direction = (transform.position - other.transform.position).normalized;

            // Aplica a força gravitacional
            other.attachedRigidbody.AddForce(direction * gravityStrength, ForceMode.Acceleration);
        }
    }
}