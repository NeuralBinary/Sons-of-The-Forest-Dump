using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000027 RID: 39
[Token(Token = "0x2000027")]
public class RockDestruction : MonoBehaviour
{
	// Token: 0x060000EF RID: 239 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x2F732C0", Offset = "0x2F718C0", VA = "0x182F732C0")]
	private void Awake()
	{
	}

	// Token: 0x060000F0 RID: 240 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x2F73740", Offset = "0x2F71D40", VA = "0x182F73740")]
	public void Fragment()
	{
	}

	// Token: 0x060000F1 RID: 241 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x2F73840", Offset = "0x2F71E40", VA = "0x182F73840")]
	public void Hit(float amount)
	{
	}

	// Token: 0x060000F2 RID: 242 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x2F739A0", Offset = "0x2F71FA0", VA = "0x182F739A0")]
	public void ApplyDamage(float damage)
	{
	}

	// Token: 0x060000F3 RID: 243 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000F3")]
	[Address(RVA = "0xB07D60", Offset = "0xB06360", VA = "0x180B07D60")]
	public RockDestruction()
	{
	}

	// Token: 0x040000FB RID: 251
	[Token(Token = "0x40000FB")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float _totalDurability;

	// Token: 0x040000FC RID: 252
	[Token(Token = "0x40000FC")]
	[FieldOffset(Offset = "0x28")]
	private RockFragment[] _fragments;

	// Token: 0x040000FD RID: 253
	[Token(Token = "0x40000FD")]
	[FieldOffset(Offset = "0x30")]
	private int _fragmentIndex;

	// Token: 0x040000FE RID: 254
	[Token(Token = "0x40000FE")]
	[FieldOffset(Offset = "0x34")]
	private float _remainingDurability;

	// Token: 0x040000FF RID: 255
	[Token(Token = "0x40000FF")]
	[FieldOffset(Offset = "0x38")]
	private float _durabilityPerFragment;
}
