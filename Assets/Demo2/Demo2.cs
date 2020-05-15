
/// <summary>
/// Demo2.cs
/// </summary>
/// <remarks>
/// #CreateTime#: 创建. 陈伟超 <br/>
/// </remarks>

using UnityEngine;

namespace Test
{
    public class Demo2 : MonoBehaviour
    {
        #region Fields
        public Transform ground;
        public Transform player;
        public SmallMap smallMap;

        #endregion

        #region Properties

        #endregion

        #region Unity Messages
        //    void Awake()
        //    {
        //
        //    }
        //    void OnEnable()
        //    {
        //
        //    }
        //
        void Start()
        {
            smallMap.SetMapArea(ground);
            smallMap.player = player;
        }
        //    
        //    void Update() 
        //    {
        //    
        //    }
        //
        //    void OnDisable()
        //    {
        //
        //    }
        //
        //    void OnDestroy()
        //    {
        //
        //    }

        #endregion

        #region Private Methods

        #endregion

        #region Protected & Public Methods

        #endregion
    }
}