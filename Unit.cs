using UnityEngine;
using System.Collections;

public class Unit : MonoBehaviour
{
	public delegate void OnSelectDelegate();
	public event OnSelectDelegate OnSelect;
	public delegate void OnDeselectDelegate();
	public event OnDeselectDelegate OnDeselect;
	public delegate void OnMoveDelegate();
	public event OnMoveDelegate OnMove;
	public delegate void OnAttackDelegate();
	public event OnAttackDelegate OnAttack;


}

