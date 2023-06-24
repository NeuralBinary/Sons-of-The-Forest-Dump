using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200029D RID: 669
[Token(Token = "0x200029D")]
[Serializable]
public class RadialButton
{
	// Token: 0x060011E0 RID: 4576 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011E0")]
	[Address(RVA = "0x31CFCD0", Offset = "0x31CE2D0", VA = "0x1831CFCD0")]
	public void SetSelected(bool selectedValue, float speedMultiplier, Vector3 extraPosOffset)
	{
	}

	// Token: 0x060011E1 RID: 4577 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011E1")]
	[Address(RVA = "0x31D0330", Offset = "0x31CE930", VA = "0x1831D0330")]
	public void Awake()
	{
	}

	// Token: 0x060011E2 RID: 4578 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011E2")]
	[Address(RVA = "0x31D03C0", Offset = "0x31CE9C0", VA = "0x1831D03C0")]
	public RadialButton()
	{
	}

	// Token: 0x040011A3 RID: 4515
	[Token(Token = "0x40011A3")]
	[FieldOffset(Offset = "0x10")]
	public Transform Parent;

	// Token: 0x040011A4 RID: 4516
	[Token(Token = "0x40011A4")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Icon;

	// Token: 0x040011A5 RID: 4517
	[Token(Token = "0x40011A5")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Border;

	// Token: 0x040011A6 RID: 4518
	[Token(Token = "0x40011A6")]
	[FieldOffset(Offset = "0x28")]
	public float SelectedScale;

	// Token: 0x040011A7 RID: 4519
	[Token(Token = "0x40011A7")]
	[FieldOffset(Offset = "0x2C")]
	public float Offset;

	// Token: 0x040011A8 RID: 4520
	[Token(Token = "0x40011A8")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 _basePos;
}
