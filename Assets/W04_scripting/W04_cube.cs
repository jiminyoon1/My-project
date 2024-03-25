using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W04_cube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        //Input 장치중 Key가 Down되었는지. 그렇다면 G Key인지 확인 후 Print
        if (Input.GetKeyDown(KeyCode.G))
        {
            print(gameObject.name);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        //충돌한 대상의 이름이 출력 (로봇)
        //trigger option 시 사용 못함
        print(collision.gameObject.name);

    }

    private void OnTriggerEnter(Collider other)
    {
        print("trigger");
        print(other.gameObject.name);
    }

    private void OnMouseDown()
    {
        print("mousedown");
        print(gameObject.name); //클릭한 게임 오브젝트의 이름을 출력
    }
}
