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
        //Input ��ġ�� Key�� Down�Ǿ�����. �׷��ٸ� G Key���� Ȯ�� �� Print
        if (Input.GetKeyDown(KeyCode.G))
        {
            print(gameObject.name);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        //�浹�� ����� �̸��� ��� (�κ�)
        //trigger option �� ��� ����
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
        print(gameObject.name); //Ŭ���� ���� ������Ʈ�� �̸��� ���
    }
}
