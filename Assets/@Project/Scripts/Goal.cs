using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
	private bool m_isGoal;
	public AudioClip m_goalClip;
    
	public int nextSceneIndex;
	private void OnTriggerEnter2D( Collider2D other )
	{
		if ( !m_isGoal )
		{
			if ( other.name.Contains( "Player" ) )
			{
				var cameraShake = FindObjectOfType<CameraShaker>();
				var animator = GetComponent<Animator>();
				var audioSource = FindObjectOfType<AudioSource>();
				m_isGoal = true;
				cameraShake.Shake();
				animator.Play( "Pressed" );
				audioSource.PlayOneShot( m_goalClip );
				// serviu para carregar a proxima cena passando um parametro
                SceneManager.LoadScene(nextSceneIndex);
            }
		}
	}
}