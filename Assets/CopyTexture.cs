using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class CopyTexture : MonoBehaviour
{

	public GameObject Plane1;
	public GameObject Plane2;
	public GameObject Plane3;

	private Material Material1;
	private Material Material2;
	private Material Material3;

	private VideoPlayer Video;
	private Texture2D VideoFrame;


    // Start is called before the first frame update
    void Start()
    {
        Material1 = Plane1.GetComponent<Renderer>().material;
		Material2 = Plane2.GetComponent<Renderer>().material;
		Material3 = Plane3.GetComponent<Renderer>().material;

		VideoFrame = new Texture2D(2, 2);

		Video = Plane3.GetComponent<VideoPlayer>();

    }


 	void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 100, 50), "Copy Texture"))
        {
            //print("You clicked the button!");
			CopyTextureAndSet();
        }
    }

	private void CopyTextureAndSet() {

		RenderTexture renderTexture = Video.texture as RenderTexture;
		Texture2D texture = new Texture2D(renderTexture.width, renderTexture.height);

		Debug.Log(renderTexture.width);
		Debug.Log(renderTexture.height);

		RenderTexture.active = renderTexture;
		texture.ReadPixels(new Rect(0, 0, renderTexture.width, renderTexture.height), 0, 0);
		texture.Apply();

		Material2.mainTexture = texture;

	}
}
