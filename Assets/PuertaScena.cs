using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PuertaScena : MonoBehaviour
{
    // Start is called before the first frame update
    public string handTag;

    public string sceneName;

    public Image panel;

    public float velocidad = 0.1f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter (Collider other){
        if (other.CompareTag(handTag)){
            //SceneManager.LoadScene(sceneName);
            StartCoroutine(Fade());
        }
    }

    IEnumerator Fade()
    {
        float alpha = 0;

        while (alpha < 1){
            alpha += Time.deltaTime * velocidad;
            panel.color = new Color (0,0,0, alpha);
            yield return null;
        }
        SceneManager.LoadScene(sceneName);
    }

}
