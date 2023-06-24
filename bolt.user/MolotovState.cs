using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000022 RID: 34
[Token(Token = "0x2000022")]
internal class MolotovState : NetworkState, IMolotovState, IRigidbodyState, IState, IDisposable
{
	// Token: 0x060000B3 RID: 179 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x7BBEB0", Offset = "0x7BA4B0", VA = "0x1807BBEB0")]
	public MolotovState()
	{
	}

	// Token: 0x17000048 RID: 72
	// (get) Token: 0x060000B4 RID: 180 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000048")]
	public NetworkTransform Transform
	{
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x7BACE0", Offset = "0x7B92E0", VA = "0x1807BACE0", Slot = "35")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000049 RID: 73
	// (get) Token: 0x060000B5 RID: 181 RVA: 0x000024D8 File Offset: 0x000006D8
	// (set) Token: 0x060000B6 RID: 182 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000049")]
	public bool Broken
	{
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x7BB3B0", Offset = "0x7B99B0", VA = "0x1807BB3B0", Slot = "31")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x7BB410", Offset = "0x7B9A10", VA = "0x1807BB410", Slot = "32")]
		set
		{
		}
	}

	// Token: 0x1700004A RID: 74
	// (get) Token: 0x060000B7 RID: 183 RVA: 0x000024F0 File Offset: 0x000006F0
	// (set) Token: 0x060000B8 RID: 184 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700004A")]
	public bool Wet
	{
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x7BBF10", Offset = "0x7BA510", VA = "0x1807BBF10", Slot = "33")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x7BBF70", Offset = "0x7BA570", VA = "0x1807BBF70", Slot = "34")]
		set
		{
		}
	}
}
