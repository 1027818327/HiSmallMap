
/// <summary>
/// Demo.cs
/// </summary>
/// <remarks>
/// #CreateTime#: 创建. 陈伟超 <br/>
/// </remarks>

using UnityEngine;

namespace Test
{
    public class SmallMap : MonoBehaviour
    {
        public Transform player;
        public RectTransform mMapTrans;

        private Vector3 groundSize;


        //小地图的尺寸
        Vector2 mipMapSize;
        //等比例映射后角色在小地图的位置
        Vector2 position;
        //人物相对于地形的坐标
        Vector3 localPos;

        float rateX, rateY;

        void Start() 
        {
            mipMapSize = mMapTrans.sizeDelta;
        }

        void Update()
        {
            if (player == null) 
            {
                return;
            }
            PlayerRate();
            MipMapWave();
        }

        public void SetMapArea(Vector3 area) 
        {
            groundSize = area;
        }

        public void SetMapArea(Transform trans) 
        {
            MeshFilter tempMf = trans.GetComponent<MeshFilter>();
            if (tempMf != null) 
            {
                groundSize = tempMf.mesh.bounds.size;
                groundSize.x *= trans.localScale.x;
                groundSize.y = 0;
                groundSize.z *= trans.localScale.z;
            }
        }

        //角色在地形上的比例
        private void PlayerRate()
        {
            rateX = player.position.x / groundSize.x;
            rateY = player.position.z / groundSize.z;
        }

        private void MipMapWave()
        {
            position.x = mipMapSize.x * rateX;
            position.y = mipMapSize.y * rateY;
            transform.localPosition = position;

            Vector3 tmpAngle = transform.localEulerAngles;
            tmpAngle.z = 90 - player.localEulerAngles.y;
            transform.localEulerAngles = tmpAngle;
        }
    }
}