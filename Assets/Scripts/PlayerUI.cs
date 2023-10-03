using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    public GameObject[] Effect;
    public Image[] Img;

    public float MAX_HP;
    public float MAX_STEMINA;
    public float p_HP;
    public float p_STEMINA;

    public void UIUpdate(string _Type, string _InfoType, float _Value)
    {
        float Type      = 0;    // HP �Ǵ� STEMINA�� ���� ��ġ
        float MAXType   = 0;    // HP �Ǵ� STEMINA�� �ִ�ġ
        int Index       = 0;    // HP �Ǵ� STEMINA�� �̹��� �ε���

        switch (_InfoType)
        {
            case "HP":
                Index = 0;
                Type = p_HP;
                MAXType = MAX_HP;


                break;
            case "STEMINA":
                Index = 1;
                Type = p_STEMINA;
                MAXType = MAX_STEMINA;


                break;
            default:
                break;
        }
    }

}
