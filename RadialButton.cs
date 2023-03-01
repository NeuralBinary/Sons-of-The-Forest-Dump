using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002A9 RID: 681
[Token(Token = "0x20002A9")]
[Serializable]
public class RadialButton
{
	// Token: 0x060011AB RID: 4523 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011AB")]
	[Address(RVA = "0x2B85C60", Offset = "0x2B84C60", VA = "0x182B85C60")]
	public void SetSelected(bool selectedValue, float speedMultiplier, Vector3 extraPosOffset)
	{
	}

	// Token: 0x060011AC RID: 4524 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011AC")]
	[Address(RVA = "0x2B85C20", Offset = "0x2B84C20", VA = "0x182B85C20")]
	public void Awake()
	{
	}

	// Token: 0x060011AD RID: 4525 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011AD")]
	[Address(RVA = "0x2B85F50", Offset = "0x2B84F50", VA = "0x182B85F50")]
	public RadialButton()
	{
	}

	// Token: 0x0400117C RID: 4476
	[Token(Token = "0x400117C")]
	[FieldOffset(Offset = "0x10")]
	public Transform Parent;

	// Token: 0x0400117D RID: 4477
	[Token(Token = "0x400117D")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Icon;

	// Token: 0x0400117E RID: 4478
	[Token(Token = "0x400117E")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Border;

	// Token: 0x0400117F RID: 4479
	[Token(Token = "0x400117F")]
	[FieldOffset(Offset = "0x28")]
	public float SelectedScale;

	// Token: 0x04001180 RID: 4480
	[Token(Token = "0x4001180")]
	[FieldOffset(Offset = "0x2C")]
	public float Offset;

	// Token: 0x04001181 RID: 4481
	[Token(Token = "0x4001181")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 _basePos;
}
