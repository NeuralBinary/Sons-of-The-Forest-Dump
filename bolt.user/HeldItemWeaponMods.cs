using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000010 RID: 16
[Token(Token = "0x2000010")]
public class HeldItemWeaponMods : NetworkObj
{
	// Token: 0x0600004F RID: 79 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600004F")]
	[Address(RVA = "0x7B7FE0", Offset = "0x7B65E0", VA = "0x1807B7FE0")]
	public HeldItemWeaponMods()
	{
	}

	// Token: 0x1700001E RID: 30
	// (get) Token: 0x06000050 RID: 80 RVA: 0x00002280 File Offset: 0x00000480
	// (set) Token: 0x06000051 RID: 81 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700001E")]
	public int ItemId
	{
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x7B5360", Offset = "0x7B3960", VA = "0x1807B5360")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x7B8090", Offset = "0x7B6690", VA = "0x1807B8090")]
		set
		{
		}
	}

	// Token: 0x1700001F RID: 31
	// (get) Token: 0x06000052 RID: 82 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700001F")]
	public NetworkArray_Integer WeaponModIds
	{
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x7B8180", Offset = "0x7B6780", VA = "0x1807B8180")]
		get
		{
			return null;
		}
	}
}
