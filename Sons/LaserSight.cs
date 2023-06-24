using System;
using Il2CppDummyDll;
using Sons.Gameplay;
using Sons.Weapon;
using UnityEngine;

// Token: 0x0200005A RID: 90
[Token(Token = "0x200005A")]
[AddComponentMenu("Sons/WeaponMods/Laser Sight Mod")]
public class LaserSight : MonoBehaviour, IWeaponModLogic
{
	// Token: 0x06000299 RID: 665 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000299")]
	[Address(RVA = "0x31B39C0", Offset = "0x31B1FC0", VA = "0x1831B39C0")]
	private void Update()
	{
	}

	// Token: 0x0600029A RID: 666 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600029A")]
	[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0", Slot = "4")]
	public void SetRangedWeapon(RangedWeapon rangedWeapon)
	{
	}

	// Token: 0x0600029B RID: 667 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600029B")]
	[Address(RVA = "0x31B4410", Offset = "0x31B2A10", VA = "0x1831B4410")]
	public LaserSight()
	{
	}

	// Token: 0x04000283 RID: 643
	[Token(Token = "0x4000283")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float MaxCastDistance;

	// Token: 0x04000284 RID: 644
	[Token(Token = "0x4000284")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private RangedWeapon _rangedWeapon;

	// Token: 0x04000285 RID: 645
	[Token(Token = "0x4000285")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Transform Reference;

	// Token: 0x04000286 RID: 646
	[Token(Token = "0x4000286")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Transform Laser;

	// Token: 0x04000287 RID: 647
	[Token(Token = "0x4000287")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Transform End;

	// Token: 0x04000288 RID: 648
	[Token(Token = "0x4000288")]
	[FieldOffset(Offset = "0x48")]
	private float _currentLength;

	// Token: 0x04000289 RID: 649
	[Token(Token = "0x4000289")]
	[FieldOffset(Offset = "0x4C")]
	private bool _hasWeapon;

	// Token: 0x0400028A RID: 650
	[Token(Token = "0x400028A")]
	[FieldOffset(Offset = "0x50")]
	private readonly RaycastHit[] _hitTriggerInfo;
}
