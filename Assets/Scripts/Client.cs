using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    public Drone m_Drone;
    public Sniper m_Sniper;
    public Attacker m_Attacker;
    public EnemySpawner m_Spawner;

    private Enemy m_Spawn;
    private int m_IncrementorDrone = 0;
    private int m_IncrementorSniper = 0;
    private int m_IncrementorAttacker = 0;

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            m_Spawn = m_Spawner.SpawnEnemy(m_Drone);

            m_Spawn.name = "Drone_Clone" + ++m_IncrementorDrone;
            m_Spawn.transform.Translate(Vector3.forward * m_IncrementorDrone * 1.5f);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            m_Spawn = m_Spawner.SpawnEnemy(m_Sniper);

            m_Spawn.name = "Sniper_Clone" + ++m_IncrementorSniper;
            m_Spawn.transform.Translate(Vector3.forward * m_IncrementorSniper* 1.5f);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            m_Spawn = m_Spawner.SpawnEnemy(m_Attacker);

            m_Spawn.name = "Attacker_Clone" + ++m_IncrementorAttacker;
            m_Spawn.transform.Translate(Vector3.forward * m_IncrementorAttacker * 1.5f);
        }
    }
}
