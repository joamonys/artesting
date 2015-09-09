using UnityEngine;
using System.Collections;

public class select : MonoBehaviour {
	public Transform Posearth;
	public Transform Menu;
	public GameObject enableCredit;
	public GameObject parti;
	// Use this for initialization
	void Start () {


	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public void earthgo()
	{
		StartCoroutine (Gotor1());


	}

	IEnumerator Gotor1(){


		yield return new WaitForSeconds (4);
		bool loop1 = true;
		bool loop2 = true;
		while (loop1) {
			transform.localPosition = Vector3.Lerp (transform.localPosition,new Vector3(transform.localPosition.x, Posearth.localPosition.y,transform.localPosition.z),3f*Time.deltaTime);
			
			if (Vector3.Distance (transform.localPosition, new Vector3(transform.localPosition.x, Posearth.localPosition.y,transform.localPosition.z)) < 0.1f){
				
				loop1 = false;
				
			}
			yield return null;
		}
		
		
		while (loop2) {
			transform.localPosition = Vector3.Lerp (transform.localPosition,Posearth.localPosition,3f*Time.deltaTime);
			transform.localRotation = Quaternion.Lerp (transform.localRotation, Posearth.localRotation, 3f * Time.deltaTime);
			if (Vector3.Distance (transform.localPosition, Posearth.localPosition) < 0.1f){
				loop2 = false;
			}
			yield return null;
		}


		StartCoroutine (ena_credit ());
		
	}

	IEnumerator ena_credit()
	{
		yield return new WaitForSeconds (4);
		enableCredit.SetActive (true);
		StartCoroutine (waitforparticle ());

	}

	IEnumerator waitforparticle()
	{
		yield return new WaitForSeconds (2);
	
		parti.SetActive (true);
	}

}

	




