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
        //myNumber = myNumber + 1; // �������� ���� +, _, *, /, =
        //print(myNumber);

        
    }
    private void OnCollisionEnter(Collision collision)
        {
            //�浹�� ����� �̸��� ��� (�κ�)
            //trigger option �� ��� ����
            print(collision.gameObject.name);

        }
}
