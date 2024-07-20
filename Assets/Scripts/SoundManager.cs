using UnityEngine;

public class SoundManager : MonoBehaviour {
	
	public static AudioClip wallSound;
	public static AudioClip paddleSound;
	public static AudioClip pointSound;

	static AudioSource AudioSource;
	// Use this for initialization
	void Start () {
		wallSound = Resources.Load<AudioClip>("wall");
		paddleSound = Resources.Load<AudioClip>("paddle");	
		pointSound = Resources.Load<AudioClip>("point");	
		AudioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}	

	public static void PlaySound (string clip)
	{
		switch (clip)
		{	
			case "wall":
				AudioSource.PlayOneShot(wallSound);
				break;	
			case "paddle":
				AudioSource.PlayOneShot(paddleSound);
				break;
			case "point":
				AudioSource.PlayOneShot(pointSound);
				break;			
		}
	}
	
}
