using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000169 RID: 361
[Token(Token = "0x2000169")]
internal class CutTriggerActivated_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001090 RID: 4240 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001090")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public CutTriggerActivated_Meta()
	{
	}

	// Token: 0x170005D3 RID: 1491
	// (get) Token: 0x06001091 RID: 4241 RVA: 0x000065D0 File Offset: 0x000047D0
	[Token(Token = "0x170005D3")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001091")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170005D4 RID: 1492
	// (get) Token: 0x06001092 RID: 4242 RVA: 0x000065E8 File Offset: 0x000047E8
	[Token(Token = "0x170005D4")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001092")]
		[Address(RVA = "0x87E6D0", Offset = "0x87CCD0", VA = "0x18087E6D0", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170005D5 RID: 1493
	// (get) Token: 0x06001093 RID: 4243 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170005D5")]
	private Type TypeObject
	{
		[Token(Token = "0x6001093")]
		[Address(RVA = "0x87E6F0", Offset = "0x87CCF0", VA = "0x18087E6F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001094 RID: 4244 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001094")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001095 RID: 4245 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001095")]
	[Address(RVA = "0x87E790", Offset = "0x87CD90", VA = "0x18087E790", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001096 RID: 4246 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001096")]
	[Address(RVA = "0x87E980", Offset = "0x87CF80", VA = "0x18087E980", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001097 RID: 4247 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001097")]
	[Address(RVA = "0x87EA10", Offset = "0x87D010", VA = "0x18087EA10", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x0400029B RID: 667
	[Token(Token = "0x400029B")]
	[FieldOffset(Offset = "0x0")]
	internal static CutTriggerActivated_Meta Instance;
}
