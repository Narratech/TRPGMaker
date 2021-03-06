﻿using UnityEngine;
using UnityEditor;
using System.Collections;
using IsoUnity.Entities;

namespace IsoUnity.Sequences {
	[CustomEditor(typeof(ItemFork))]
	public class ItemForkEditor : Editor {
		
		
		public override void OnInspectorGUI()
	    {
	        var isf = target as ItemFork;
			isf.contains = EditorGUILayout.Toggle("Contains", isf.contains);
			isf.item =  EditorGUILayout.ObjectField("Item", (Object)isf.item, typeof(Item), true) as IsoUnity.Entities.Item;
			isf.inventory = EditorGUILayout.ObjectField("Inventory", (Object)isf.inventory, typeof(IsoUnity.Entities.Inventory), true) as IsoUnity.Entities.Inventory;
		}
	}
}