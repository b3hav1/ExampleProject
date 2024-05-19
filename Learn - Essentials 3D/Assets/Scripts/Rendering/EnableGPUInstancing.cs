using UnityEngine;

namespace Game.Rendering
{
    public class EnableGPUInstancing : MonoBehaviour
    {
        private void Awake()
        {
            MeshRenderer[] meshes = FindObjectsByType<MeshRenderer>(FindObjectsSortMode.None);
            MaterialPropertyBlock block = new MaterialPropertyBlock();

            foreach (MeshRenderer mesh in meshes)
            {
                mesh.SetPropertyBlock(block);
            }
        }
    }
}
