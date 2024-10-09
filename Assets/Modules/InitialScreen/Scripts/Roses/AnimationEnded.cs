using UnityEngine;

class AnimationEnded : MonoBehaviour
{
	public void OnAnimationEnded()
	{
		Destroy(gameObject);
	}
}