﻿using UnityEngine;
using System.Collections;

public enum eJPSState
{
	ST_OBSTACLE_BUILDING      = 0,
	ST_PRIMARY_JPS_BUILDING   = 1,
}

public static class JPSState
{
	public static eJPSState state = eJPSState.ST_OBSTACLE_BUILDING;
}