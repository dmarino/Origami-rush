using UnityEngine;

public class SphereCommands : MonoBehaviour
{
	int contador;
	Vector3 originalPosition;
	public TextMesh textObject;
	TextMesh textObject2;

    // Use this for initialization
    void Start()
    {
        // Grab the original local position of the sphere when the app starts.
        originalPosition = this.transform.localPosition;
		contador = 0;
		textObject = GameObject.Find("score").GetComponent<TextMesh>();
		textObject2 = GameObject.Find("timer").GetComponent<TextMesh>();
    }

    // Called by GazeGestureManager when the user performs a Select gesture
    void OnSelect()
    {
		if(!textObject2.text.Equals("Game Over")){

		}
		contador++;
		originalPosition.Set (Random.Range(-1f,1f),Random.Range(0,1f),2);
		this.transform.position = originalPosition;
		textObject.text = "Score: " + contador;	
    }
}