using UnityEngine;

public class Death : MonoBehaviour
{
    [SerializeField] private Animator _animation;
    [SerializeField] private AudioSource _deathSong;
    [SerializeField] private GameObject _particle;

    public void Die(GameObject player, GameObject armor, Collision collision)
    {
        _deathSong.Play();
        _particle.SetActive(true);

        if (armor.activeSelf == true)
        {
            Destroy(collision.gameObject);
            armor.SetActive(false);
        }
        else
        {
            _animation.Play("Death");
			Destroy(player);
        }
    }
}
