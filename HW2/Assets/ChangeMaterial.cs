using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeMaterial : MonoBehaviour
{
  public GameObject sphere;

  public Material[] textures;

  private int randomTextureIndex;
    // Start is called before the first frame update
    void Start()
    {
      gameObject.GetComponent<Button>().onClick.AddListener(ChangeSphereTexture);

    }

    // Update is called once per frame
    void ChangeSphereTexture()
    {
      Renderer sphereRenderer = sphere.GetComponent<Renderer>();
      randomTextureIndex = Random.Range(0, textures.Length);
      sphereRenderer.material = textures[randomTextureIndex];

    }
}
