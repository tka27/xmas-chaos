using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Translator : MonoBehaviour
{
    static int langIndex = -1; // ������ �����: -1-��� �� ���������������, 0-����, 1 - ������� � �.�.

    public static string Translate(string text_)
    {
        if (langIndex == -1) // ��������� ������������� ������� ����� ��� ������ ������
        {
            switch (Application.systemLanguage.ToString())
            {
                case "English": langIndex = 0; break;
                case "Russian": langIndex = 1; break;
                    // ���������� ��� ������ ������ ....
            }
        }

        for (int i = 0; i < labels.GetLength(0); i++)
        {
            if (text_ == labels[i, 0]) return labels[i, langIndex];
        }
        return text_;
    }


    // ����� ����� ��� ���� ������
    static string[,] labels =
    {
    {
      "PLAY", // ����.
      "������"  // ����.
    },
    {
      "SETTINGS",
      "���������"
    },
    {
      "EXIT",
      "�����"
    }   
    // ...... �� � �.�., ���� ������ ������, �� � ������ ����� ����� ������ �������
  };
}
