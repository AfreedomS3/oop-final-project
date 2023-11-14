using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Figure : MonoBehaviour
{
    public string figureName;
    public int spawnIndex;

    protected float impulseForce;

    [SerializeField]
    private Material selectedMaterial;

    [SerializeField]
    private Material originalMaterial;

    // Update is called once per frame
    void Update()
    {

    }

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
