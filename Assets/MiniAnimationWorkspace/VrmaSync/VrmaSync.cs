using System.IO;
using System.Threading.Tasks;
using UnityEngine;
using UniVRM10;
using VRMShaders;
using UniGLTF;

namespace MiniAnimationWorkspace.VrmaSync
{
    public class VrmaSync : MonoBehaviour
    {
        private async Task Start()
        {
            var path = Path.Combine(Application.streamingAssetsPath, "MiniAnimationWorkspace", "VrmaSync", "idle_loop.vrma");
            File.ReadAllBytes(path);

            using GltfData data = new AutoGltfFileParser(path).Parse();
            using var loader = new VrmAnimationImporter(data);
            var instance = await loader.LoadAsync(new ImmediateCaller());
            var anim = instance.GetComponent<VrmAnimationInstance>();
            // var vrmAnimation = new VrmAnimation(instance.GetComponent<VrmAnimationInstance>());
        }

        void Update()
        {
        }
    }
}
