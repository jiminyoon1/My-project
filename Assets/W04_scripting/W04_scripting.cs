using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W04_scripting : MonoBehaviour
{
    int myNumber;
    // Start is called before the first frame update
    void Start()
    {
        print(myNumber);
        Debug.Log(gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        //myNumber = myNumber + 1; // 연산자의 종류 +, _, *, /, =
        //print(myNumber);

        
    }
    private void OnCollisionEnter(Collision collision)
        {
            //충돌한 대상의 이름이 출력 (로봇)
            //trigger option 시 사용 못함
            print(collision.gameObject.name);

        }
}
