using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TekiScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    // Update is called once per frame
    void Update () {
        transform.position += new Vector3(-0.03f, 0.0f, 0.0f);
    }
    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Butterfly")
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
