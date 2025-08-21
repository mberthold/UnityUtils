using UnityEngine;
using Vector3 = UnityEngine.Vector3;

namespace BertisUtils
{
    public static class VectorUtils
    {
        public static int GimmeFive()
        {
            return 5;
        }

        public static Vector3 GetVectorFromAngle(float angle)
        {
            // Returns a vector of length 1!
            // 0 <= angle <= 360
            float angleRad = angle * (Mathf.PI / 180f);
            return new Vector3(Mathf.Cos(angleRad), Mathf.Sin(angleRad));
        }

        public static Vector3 TransformSetZ(GameObject obj, float z)
        {
            float currentX = obj.transform.position.x;
            float currentY = obj.transform.position.y;
   

            Vector3 newPosition = new Vector3(currentX, currentY, z);

            return newPosition;
        }

    }
}