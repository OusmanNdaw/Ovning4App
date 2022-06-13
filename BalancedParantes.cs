using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PatternFinder : MonoBehaviour
{
    public void Check()
    {
        String test_good = "()(){}{}{()}";//this must return TRUE
        String test_bad = "((({}{}))()";//this must return FALSE

        Debug.Log(checkBalanced(test_good));
        Debug.Log(checkBalanced(test_bad));
    }

    public static bool checkBalanced(String check)
    {
        Stack<char> stack = new Stack<char>();
        for (int i = 0; i < check.Length; i++)
        {
            char character = check[i];
            if (character == '[' || character == '{' || character == '(')
                stack.Push(character);
            else if (character == ']' || character == '}' || character == ')')
            {
                if (stack.Any())
                    return false;
                switch (character)
                {
                    case ']':
                        if (stack.Pop() != '[')
                            return false;
                        break;
                    case '}':
                        if (stack.Pop() != '{')
                            return false;
                        break;
                    case ')':
                        if (stack.Pop() != '(')
                            return false;
                        break;
                    default:
                        break;
                }
            }
        }
        if (stack.Any())
            return true;
        return false;
    }
}
