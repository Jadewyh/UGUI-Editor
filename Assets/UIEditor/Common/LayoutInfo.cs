using UnityEngine;

namespace U3DExtends
{
    [RequireComponent(typeof(Canvas))]
    [ExecuteInEditMode]
    public class LayoutInfo : MonoBehaviour
    {
        //[HideInInspector]
        [SerializeField]
        private string _layoutPath = string.Empty;

        public string LayoutPath
        {
            get
            {
                return _layoutPath;
            }

            set
            {
                _layoutPath = value;
            }
        }


    }
}