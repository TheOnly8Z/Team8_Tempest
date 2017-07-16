﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// MapLine is used to define a line (between two vertices) in a map.
// It should be generated by MapManager and used by ships to move around.
public class MapLine {

	// The starting vertice (left hand side) of the line
	public Vector3 startPos;
	// The ending vertice (right hand side) of the line
	public Vector3 endPos;

	// Initializaiton code for MapLine
	public MapLine(Vector3 startpos, Vector3 endpos){
		startPos = startpos;
		endPos = endpos;
	}
		
	// Return the length of the ship
	public float GetLength()
	{
		return (endPos - startPos).magnitude;
	}

	// Return the vector of the line
	public Vector3 GetDirectionVector()
	{
		return (endPos - startPos);
	}

	// Return a normalized vector of the line.
	public Vector3 GetNormalizedVector()
	{
		return (endPos - startPos).normalized;
	}

	// Override the MapLine.Equals function
	public override bool Equals(object o)
	{
		if (o is MapLine)
			return Equals((MapLine)o);
		else
			return base.Equals(o);
	}

	// Used to compare another MapLine with this one
	public bool Equals(MapLine otherMapLine){
		if (otherMapLine.startPos == startPos && otherMapLine.endPos == endPos)
			return true;
		else
			return false;
	}


}
