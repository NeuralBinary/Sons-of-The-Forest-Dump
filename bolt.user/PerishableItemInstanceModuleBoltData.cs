using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200000E RID: 14
[Token(Token = "0x200000E")]
public class PerishableItemInstanceModuleBoltData : NetworkObj
{
	// Token: 0x06000042 RID: 66 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000042")]
	[Address(RVA = "0x7B7740", Offset = "0x7B5D40", VA = "0x1807B7740")]
	public PerishableItemInstanceModuleBoltData()
	{
	}

	// Token: 0x17000019 RID: 25
	// (get) Token: 0x06000043 RID: 67 RVA: 0x00002220 File Offset: 0x00000420
	// (set) Token: 0x06000044 RID: 68 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000019")]
	public int CurrentState
	{
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x7B5360", Offset = "0x7B3960", VA = "0x1807B5360")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x7B77F0", Offset = "0x7B5DF0", VA = "0x1807B77F0")]
		set
		{
		}
	}

	// Token: 0x1700001A RID: 26
	// (get) Token: 0x06000045 RID: 69 RVA: 0x00002238 File Offset: 0x00000438
	// (set) Token: 0x06000046 RID: 70 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700001A")]
	public float TimeRemainingInState
	{
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x7B78E0", Offset = "0x7B5EE0", VA = "0x1807B78E0")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x7B7940", Offset = "0x7B5F40", VA = "0x1807B7940")]
		set
		{
		}
	}
}
