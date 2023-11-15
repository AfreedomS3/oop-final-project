using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class Figure : MonoBehaviour
{
    public string figureName;
    public int spawnIndex;

    [SerializeField]
    protected float impulseForce;

    [SerializeField]
    private Material selectedMaterial;

    [SerializeField]
    private Material originalMaterial;

    protected Rigidbody rb;

    [SerializeField]
    protected bool isGrounded = true;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            // ABSTRACTION
            Move();
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }

    // POLYMORPHISM -- ABSTRACTION
    protected abstract void Move();

    private void OnMouseEnter()
    {
        if (GameManager.Instance.isGameOver)
        {
            List<Material> materials = new List<Material>
            {
                originalMaterial,
                selectedMaterial
            };

            gameObject.GetComponent<Renderer>().SetMaterials(materials);
        }
    }

    private void OnMouseExit()
    {
        if (GameManager.Instance.isGameOver)
        {
            List<Material> materials = new List<Material> { originalMaterial };

            gameObject.GetComponent<Renderer>().SetMaterials(materials);
        }
    }

    private void OnMouseDown()
    {
        if (GameManager.Instance.isGameOver)
        {
            GameManager.Instance.sessionData.figureName = figureName;
            GameManager.Instance.sessionData.figureIndex = spawnIndex;

            GameManager.Instance.StartGame();
        }
    }
}
