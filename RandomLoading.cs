using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RandomLoading : MonoBehaviour {

	public Image loadingIMG;
	public float load;
	public int timer;

	void Update () {
		load = Random.Range (0f,0.3f);
		timer = Random.Range (0,10);
		Invoke ("Loader",timer);
	}
	void Loader () {
		loading.fillAmount += load * Time.deltaTime;
		if (loadingIMG.fillAmount >= 1){
			SceneManager.LoadScene ("your scene name");
		}
	}
}
