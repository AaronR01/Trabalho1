using System.Collections;
using UnityEngine;

public class CameraShaker : MonoBehaviour
{
	//variaveis pra definir a duração e a intensidade do tremor
	public float m_duration = 0.3f;
	public float m_magnitude = 0.25f;

	// criação função Shake para fazer a câmera tremer
	public void Shake()
	{
		StartCoroutine( DoShake() );
	}

	private IEnumerator DoShake()
	{
		var pos = transform.localPosition;
		float elapsed = 0f;

		while ( elapsed < m_duration )
		{
			elapsed += Time.deltaTime;
			var x = pos.x + Random.Range( -1f, 1f ) * m_magnitude;
			var y = pos.y + Random.Range( -1f, 1f ) * m_magnitude;
			transform.localPosition = new Vector3( x, y, pos.z );
			yield return null;
		}

		transform.localPosition = pos;
	}
}