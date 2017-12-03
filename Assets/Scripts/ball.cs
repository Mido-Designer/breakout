using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {

    int blocksDestroyed = 0;

    public Gm gameManager;

    public GameObject destroyedblock;


    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == "block")
        {

            blocksDestroyed += 1;
            Instantiate(destroyedblock, col.gameObject.transform.position, Quaternion.identity);

            destroyedblock.transform.localScale = Vector3.one * 0.3f;

            Destroy(col.gameObject);
            if (blocksDestroyed >= 16)
            {

                gameManager.uWin();

            }
        }
        if (col.gameObject.tag == "Destroyer") {

            gameManager.GameOver();
            Destroy(gameObject);
        
        }

    }

}
