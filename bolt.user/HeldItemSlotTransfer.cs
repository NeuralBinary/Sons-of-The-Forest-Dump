using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000014 RID: 20
[Token(Token = "0x2000014")]
public class HeldItemSlotTransfer : NetworkObj
{
	// Token: 0x0600006B RID: 107 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600006B")]
	[Address(RVA = "0x7B9640", Offset = "0x7B7C40", VA = "0x1807B9640")]
	public HeldItemSlotTransfer()
	{
	}

	// Token: 0x1700002A RID: 42
	// (get) Token: 0x0600006C RID: 108 RVA: 0x00002340 File Offset: 0x00000540
	// (set) Token: 0x0600006D RID: 109 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700002A")]
	public int ItemId
	{
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x7B5360", Offset = "0x7B3960", VA = "0x1807B5360")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x7B8090", Offset = "0x7B6690", VA = "0x1807B8090")]
		set
		{
		}
	}

	// Token: 0x1700002B RID: 43
	// (get) Token: 0x0600006E RID: 110 RVA: 0x00002358 File Offset: 0x00000558
	// (set) Token: 0x0600006F RID: 111 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700002B")]
	public int FromSlot
	{
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x7B96F0", Offset = "0x7B7CF0", VA = "0x1807B96F0")]
		set
		{
		}
	}

	// Token: 0x1700002C RID: 44
	// (get) Token: 0x06000070 RID: 112 RVA: 0x00002370 File Offset: 0x00000570
	// (set) Token: 0x06000071 RID: 113 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700002C")]
	public int ToSlot
	{
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x7B97E0", Offset = "0x7B7DE0", VA = "0x1807B97E0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x7B9840", Offset = "0x7B7E40", VA = "0x1807B9840")]
		set
		{
		}
	}
}
