using UnityEngine;

public class StoneSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] m_stones;
    [SerializeField] private Transform m_spawnPoint;

    public GameObject Spawn()
    {
        var prefab = m_stones[Random.Range(0, m_stones.Length)];

        return Instantiate(prefab, m_spawnPoint.position, m_spawnPoint.rotation);
    }
}
