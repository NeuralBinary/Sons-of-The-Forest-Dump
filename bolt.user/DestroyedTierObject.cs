using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000008 RID: 8
[Token(Token = "0x2000008")]
public class DestroyedTierObject : NetworkObj
{
	// Token: 0x06000016 RID: 22 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000016")]
	[Address(RVA = "0x7B52B0", Offset = "0x7B38B0", VA = "0x1807B52B0")]
	public DestroyedTierObject()
	{
	}

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x06000017 RID: 23 RVA: 0x000020D0 File Offset: 0x000002D0
	// (set) Token: 0x06000018 RID: 24 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000007")]
	public int TierIndex
	{
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x7B5360", Offset = "0x7B3960", VA = "0x1807B5360")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x7B53B0", Offset = "0x7B39B0", VA = "0x1807B53B0")]
		set
		{
		}
	}

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x06000019 RID: 25 RVA: 0x000020E8 File Offset: 0x000002E8
	// (set) Token: 0x0600001A RID: 26 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000008")]
	public bool Applied
	{
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x7B5490", Offset = "0x7B3A90", VA = "0x1807B5490")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x7B54F0", Offset = "0x7B3AF0", VA = "0x1807B54F0")]
		set
		{
		}
	}

	// Token: 0x17000009 RID: 9
	// (get) Token: 0x0600001B RID: 27 RVA: 0x00002100 File Offset: 0x00000300
	// (set) Token: 0x0600001C RID: 28 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000009")]
	public Vector3 Position
	{
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x7B55E0", Offset = "0x7B3BE0", VA = "0x1807B55E0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x7B5660", Offset = "0x7B3C60", VA = "0x1807B5660")]
		set
		{
		}
	}
}
