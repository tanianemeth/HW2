using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class color_change : MonoBehaviour
{
  public List<GameObject> GameObjects;
//  public Color newObjectColor;
    // Start is called before the first frame update
    void Start()
    {
      gameObject.GetComponent<Button>().onClick.AddListener(change_colors);


    }

    // Update is called once per frame
    void change_colors()
    {
        foreach (GameObject target in GameObjects) {
          Renderer renderer = target.GetComponent<Renderer>();
          float color_one = Random.Range(0f, 1f);
          float color_two = Random.Range(0f, 1f);
          float color_three = Random.Range(0f, 1f);

          Color new_color = new Color(color_one, color_two, color_three, 1f);
          renderer.material.SetColor("_Color", new_color);

        }
    }
}
