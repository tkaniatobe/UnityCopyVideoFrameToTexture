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

		//Debug.Log(Material1.mainTexture);
		//Debug.Log(Material2);
    }

//Initialize in the Start function
//Texture2D videoFrame;

/*void Start()
{
    videoFrame = new Texture2D(2, 2);]
    ...
}

//Initialize in the Start function
Texture2D videoFrame;

void OnNewFrame(VideoPlayer source, long frameIdx)
{
    RenderTexture renderTexture = source.texture as RenderTexture;

    if (videoFrame.width != renderTexture.width || videoFrame.height != renderTexture.height)
    {
        videoFrame.Resize(renderTexture.width, renderTexture.height);
    }
    RenderTexture.active = renderTexture;
    videoFrame.ReadPixels(new Rect(0, 0, renderTexture.width, renderTexture.height), 0, 0);
    videoFrame.Apply();
    RenderTexture.active = null;

    targetColor = CalculateAverageColorFromTexture(videoFrame);
    lSource.color = targetColor;
}*/


 	void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 100, 50), "Copy Texture"))
        {
            //print("You clicked the button!");
			CopyTextureAndSet();
        }
    }

	private void CopyTextureAndSet() { 
		//Texture2D texture = new Texture2D(128, 128);
		//Debug.Log(texture);
		
		//Debug.Log(Material1.mainTexture);

		//Texture2D texture1 = Instantiate(Material1.mainTexture) as Texture2D;
		//Texture2D texture3 = Instantiate(Material3.mainTexture) as Texture2D;

		//Material2.mainTexture = texture3;

		RenderTexture renderTexture = Video.texture as RenderTexture;
		Material2.mainTexture = renderTexture;	

	    /*if (videoFrame.width != renderTexture.width || videoFrame.height != renderTexture.height)
	    {
	        videoFrame.Resize(renderTexture.width, renderTexture.height);
	    }*/
	    //RenderTexture.active = renderTexture;
	    //VideoFrame.ReadPixels(new Rect(0, 0, renderTexture.width, renderTexture.height), 0, 0);
	    //VideoFrame.Apply();
	    //RenderTexture.active = null;
	
		//renderTexture.
		

	    //targetColor = CalculateAverageColorFromTexture(VideoFrame);
	    ///lSource.color = targetColor;


	}

}
