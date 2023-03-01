using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000027 RID: 39
[Token(Token = "0x2000027")]
public class RockDestruction : MonoBehaviour
{
	// Token: 0x060000E6 RID: 230 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x29B1240", Offset = "0x29B0240", VA = "0x1829B1240")]
	private void Awake()
	{
	}

	// Token: 0x060000E7 RID: 231 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x29B1410", Offset = "0x29B0410", VA = "0x1829B1410")]
	public void Fragment()
	{
	}

	// Token: 0x060000E8 RID: 232 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x29B14A0", Offset = "0x29B04A0", VA = "0x1829B14A0")]
	public void Hit(float amount)
	{
	}

	// Token: 0x060000E9 RID: 233 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x29B1160", Offset = "0x29B0160", VA = "0x1829B1160")]
	public void ApplyDamage(float damage)
	{
	}

	// Token: 0x060000EA RID: 234 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x98B820", Offset = "0x98A820", VA = "0x18098B820")]
	public RockDestruction()
	{
	}

	// Token: 0x040000F9 RID: 249
	[Token(Token = "0x40000F9")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float _totalDurability;

	// Token: 0x040000FA RID: 250
	[Token(Token = "0x40000FA")]
	[FieldOffset(Offset = "0x28")]
	private RockFragment[] _fragments;

	// Token: 0x040000FB RID: 251
	[Token(Token = "0x40000FB")]
	[FieldOffset(Offset = "0x30")]
	private int _fragmentIndex;

	// Token: 0x040000FC RID: 252
	[Token(Token = "0x40000FC")]
	[FieldOffset(Offset = "0x34")]
	private float _remainingDurability;

	// Token: 0x040000FD RID: 253
	[Token(Token = "0x40000FD")]
	[FieldOffset(Offset = "0x38")]
	private float _durabilityPerFragment;
}
