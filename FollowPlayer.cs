﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
	
	public Transform player;
	
    void FixedUpdate()
    {
		transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -20f);
    }
}
