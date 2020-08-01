using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTornado : MonoBehaviour
{

    public GameObject tornadoPrefab;
    
    public GameObject yasuo;
    private YasuoAnim yasAnim;

    // Start is called before the first frame update
    void Start()
    {
        yasAnim = yasuo.GetComponent<YasuoAnim>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q) && yasAnim.qCounter >= 2) {
            Instantiate(tornadoPrefab);
        }
    }


}
