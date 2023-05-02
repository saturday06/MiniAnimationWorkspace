using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MiniAnimationWorkspace.UniGltfMaterialRecorder
{
    public record DailyTemperature(double HighTemp, double LowTemp);

    public class UniGltfMaterialRecorder : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            // DailyTemperature? x = null;
            // UnityEngine.Debug.LogFormat("ht={0}", x.HighTemp);
        }

        // Update is called once per frame
        void Update()
        {
            
        }
    }
}
