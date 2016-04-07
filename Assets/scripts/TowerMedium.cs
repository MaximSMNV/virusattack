using UnityEngine;
using System.Collections;

public class TowerMedium : Tower {

	public static float towerPrice = 150;

	override public void Awake(){
		maxHP = 50;
		curHP = maxHP;
		MinDamageColor = Color.gray;
		MaxDamageColor = Color.red;
		defender = true;
		GlobalVars.TowerList.Add(gameObject);
		++GlobalVars.TurretCount;
		GlobalVars.AddTower = true;
	}
}
