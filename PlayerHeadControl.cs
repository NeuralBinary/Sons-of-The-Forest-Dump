using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200023A RID: 570
[Token(Token = "0x200023A")]
[Serializable]
public class PlayerHeadControl : MonoBehaviour
{
	// Token: 0x06000FA3 RID: 4003 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FA3")]
	[Address(RVA = "0x2F9E310", Offset = "0x2F9D310", VA = "0x182F9E310", Slot = "4")]
	public virtual void Awake()
	{
	}

	// Token: 0x06000FA4 RID: 4004 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FA4")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "5")]
	public virtual void Start()
	{
	}

	// Token: 0x06000FA5 RID: 4005 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FA5")]
	[Address(RVA = "0x2F9E390", Offset = "0x2F9D390", VA = "0x182F9E390", Slot = "6")]
	public virtual void LateUpdate()
	{
	}

	// Token: 0x06000FA6 RID: 4006 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FA6")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public PlayerHeadControl()
	{
	}

	// Token: 0x04000E92 RID: 3730
	[Token(Token = "0x4000E92")]
	[FieldOffset(Offset = "0x20")]
	private Transform MyTransform;

	// Token: 0x04000E93 RID: 3731
	[Token(Token = "0x4000E93")]
	[FieldOffset(Offset = "0x28")]
	private Transform Head;
}
