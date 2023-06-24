using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000280 RID: 640
[Token(Token = "0x2000280")]
internal class FreeFormSwitchLightState_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001D6C RID: 7532 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D6C")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public FreeFormSwitchLightState_Meta()
	{
	}

	// Token: 0x17000809 RID: 2057
	// (get) Token: 0x06001D6D RID: 7533 RVA: 0x00008A78 File Offset: 0x00006C78
	[Token(Token = "0x17000809")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001D6D")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700080A RID: 2058
	// (get) Token: 0x06001D6E RID: 7534 RVA: 0x00008A90 File Offset: 0x00006C90
	[Token(Token = "0x1700080A")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001D6E")]
		[Address(RVA = "0x7EF7C0", Offset = "0x7EDDC0", VA = "0x1807EF7C0", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700080B RID: 2059
	// (get) Token: 0x06001D6F RID: 7535 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700080B")]
	private Type TypeObject
	{
		[Token(Token = "0x6001D6F")]
		[Address(RVA = "0x7EF7E0", Offset = "0x7EDDE0", VA = "0x1807EF7E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001D70 RID: 7536 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D70")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001D71 RID: 7537 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D71")]
	[Address(RVA = "0x7EF880", Offset = "0x7EDE80", VA = "0x1807EF880", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001D72 RID: 7538 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D72")]
	[Address(RVA = "0x7EFCB0", Offset = "0x7EE2B0", VA = "0x1807EFCB0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001D73 RID: 7539 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D73")]
	[Address(RVA = "0x7EFD40", Offset = "0x7EE340", VA = "0x1807EFD40", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002F8 RID: 760
	[Token(Token = "0x40002F8")]
	[FieldOffset(Offset = "0x0")]
	internal static FreeFormSwitchLightState_Meta Instance;
}
