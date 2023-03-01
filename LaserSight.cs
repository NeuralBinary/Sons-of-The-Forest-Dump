using System;
using Il2CppDummyDll;
using Sons.Gameplay;
using Sons.Weapon;
using UnityEngine;

// Token: 0x02000059 RID: 89
[Token(Token = "0x2000059")]
[AddComponentMenu("Sons/WeaponMods/Laser Sight Mod")]
public class LaserSight : MonoBehaviour, IWeaponModLogic
{
	// Token: 0x0600027C RID: 636 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600027C")]
	[Address(RVA = "0x2B6E0C0", Offset = "0x2B6D0C0", VA = "0x182B6E0C0")]
	private void Update()
	{
	}

	// Token: 0x0600027D RID: 637 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600027D")]
	[Address(RVA = "0x541270", Offset = "0x540270", VA = "0x180541270", Slot = "4")]
	public void SetRangedWeapon(RangedWeapon rangedWeapon)
	{
	}

	// Token: 0x0600027E RID: 638 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600027E")]
	[Address(RVA = "0x2B6E720", Offset = "0x2B6D720", VA = "0x182B6E720")]
	public LaserSight()
	{
	}

	// Token: 0x04000257 RID: 599
	[Token(Token = "0x4000257")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float MaxCastDistance;

	// Token: 0x04000258 RID: 600
	[Token(Token = "0x4000258")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private RangedWeapon _rangedWeapon;

	// Token: 0x04000259 RID: 601
	[Token(Token = "0x4000259")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Transform Reference;

	// Token: 0x0400025A RID: 602
	[Token(Token = "0x400025A")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Transform Laser;

	// Token: 0x0400025B RID: 603
	[Token(Token = "0x400025B")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Transform End;

	// Token: 0x0400025C RID: 604
	[Token(Token = "0x400025C")]
	[FieldOffset(Offset = "0x48")]
	private float _currentLength;

	// Token: 0x0400025D RID: 605
	[Token(Token = "0x400025D")]
	[FieldOffset(Offset = "0x4C")]
	private bool _hasWeapon;

	// Token: 0x0400025E RID: 606
	[Token(Token = "0x400025E")]
	[FieldOffset(Offset = "0x50")]
	private readonly RaycastHit[] _hitTriggerInfo;
}
