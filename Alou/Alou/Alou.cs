using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using MSCLoader;

namespace Alou
{
    public class Alou : Mod
    {
        public override string ID => "Alou";
        public override string Name => "Alou";
        public override string Author => "Henrique";
        public override string Version => "1.0";
        public override bool UseAssetsFolder => true;

        GameObject ALOOOOOU;
        AssetBundle assets;

        public override void OnLoad()
        {
            assets = LoadAssets.LoadBundle(this, "alou.unity3d");
            ALOOOOOU = assets.LoadAsset("Alou.prefab") as GameObject;
            assets.Unload(false);
            ALOOOOOU = GameObject.Instantiate(ALOOOOOU);

            ALOOOOOU.transform.localPosition = new Vector3(0f, 0f, 0f);
            ALOOOOOU.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
            ALOOOOOU.transform.localScale = new Vector3(1f, 1f, 1f);

            ALOOOOOU.transform.SetParent(GameObject.Find("PLAYER").transform, false);
            ALOOOOOU.GetComponent<AudioSource>().playOnAwake = true;
        }
        public override void Update()
        {
            if(Application.loadedLevelName == "GAME")
            {
                if(GameObject.Find("PLAYER/Pivot/AnimPivot/Camera/FPSCamera/FPSCamera/Hello").activeInHierarchy == true) 
                {
                    ALOOOOOU.GetComponent<AudioSource>().enabled = true;
                }
                if (GameObject.Find("PLAYER/Pivot/AnimPivot/Camera/FPSCamera/FPSCamera/Hello").activeInHierarchy == false)
                {
                    ALOOOOOU.GetComponent<AudioSource>().enabled = false;
                }
            }
        }
    }
}