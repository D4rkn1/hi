using UnityEngine;
using UnityEditor;

namespace hi
{
    public class Hello
    {
        [MenuItem("Hi/Hello")]
        public static void EchoHI()
        {
            Debug.Log("Hi");
        }
    }
}
