﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryClient : MonoBehaviour
{
	public NPCSpawner m_SpawnerNPC;

	public void Update()
	{
		if (Input.GetKeyDown(KeyCode.S))
		{
			m_SpawnerNPC.SpawnVillagers();
		}
	}
}
