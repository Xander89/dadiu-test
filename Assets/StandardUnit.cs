using UnityEngine;
using System.Collections;

public class StandardUnit : MonoBehaviour {
	
	[SerializeField]
	private MeshRenderer outerGlowMesh;
	
	[SerializeField]	
	private float speed = 1.0f;
	
	private Vector3? targetPosition = null;
	
	public void Initialize() 
	{
		Unit unit = GetComponent<Unit>();
		
		if(unit == null) 
		{
#if DEBUG
			Debug.Log("The StandardUnit type requires a Component of type Unit");
#endif			
		} 
		else 
		{
			outerGlowMesh.enabled = false;
			unit.OnSelect += OnSelect;
			unit.OnDeselect += OnDeselect;
			unit.OnMove += OnMove;
		}
		
	}
	
	
	private void OnSelect() {
		outerGlowMesh.enabled = true;
	}
	
	private void OnDeselect() {
		outerGlowMesh.enabled = false;
	}
	
	private void OnMove(Vector3 ? destination) {
		targetPosition = destination;
	}
	
	
}
