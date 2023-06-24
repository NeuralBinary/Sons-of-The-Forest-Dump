using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000012 RID: 18
[Token(Token = "0x2000012")]
public class StoredItemsData : NetworkObj
{
	// Token: 0x0600005B RID: 91 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600005B")]
	[Address(RVA = "0x7B8950", Offset = "0x7B6F50", VA = "0x1807B8950")]
	public StoredItemsData()
	{
	}

	// Token: 0x17000023 RID: 35
	// (get) Token: 0x0600005C RID: 92 RVA: 0x000022C8 File Offset: 0x000004C8
	// (set) Token: 0x0600005D RID: 93 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000023")]
	public int ItemId
	{
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x7B5360", Offset = "0x7B3960", VA = "0x1807B5360")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x7B8090", Offset = "0x7B6690", VA = "0x1807B8090")]
		set
		{
		}
	}

	// Token: 0x17000024 RID: 36
	// (get) Token: 0x0600005E RID: 94 RVA: 0x000022E0 File Offset: 0x000004E0
	// (set) Token: 0x0600005F RID: 95 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000024")]
	public int Count
	{
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x7B8A00", Offset = "0x7B7000", VA = "0x1807B8A00")]
		set
		{
		}
	}

	// Token: 0x17000025 RID: 37
	// (get) Token: 0x06000060 RID: 96 RVA: 0x000022F8 File Offset: 0x000004F8
	// (set) Token: 0x06000061 RID: 97 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000025")]
	public bool AreUnique
	{
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x7B8B00", Offset = "0x7B7100", VA = "0x1807B8B00")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x7B8B60", Offset = "0x7B7160", VA = "0x1807B8B60")]
		set
		{
		}
	}

	// Token: 0x17000026 RID: 38
	// (get) Token: 0x06000062 RID: 98 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000026")]
	public NetworkArray_ProtocolToken ItemInstances
	{
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x7B8C50", Offset = "0x7B7250", VA = "0x1807B8C50")]
		get
		{
			return null;
		}
	}
}
