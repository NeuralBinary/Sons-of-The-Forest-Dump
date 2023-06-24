using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000298 RID: 664
[Token(Token = "0x2000298")]
internal class VailAttachItemEvent_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001E70 RID: 7792 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E70")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public VailAttachItemEvent_Meta()
	{
	}

	// Token: 0x17000833 RID: 2099
	// (get) Token: 0x06001E71 RID: 7793 RVA: 0x00008D18 File Offset: 0x00006F18
	[Token(Token = "0x17000833")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001E71")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000834 RID: 2100
	// (get) Token: 0x06001E72 RID: 7794 RVA: 0x00008D30 File Offset: 0x00006F30
	[Token(Token = "0x17000834")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001E72")]
		[Address(RVA = "0x7F7510", Offset = "0x7F5B10", VA = "0x1807F7510", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000835 RID: 2101
	// (get) Token: 0x06001E73 RID: 7795 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000835")]
	private Type TypeObject
	{
		[Token(Token = "0x6001E73")]
		[Address(RVA = "0x7F7530", Offset = "0x7F5B30", VA = "0x1807F7530", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001E74 RID: 7796 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E74")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001E75 RID: 7797 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E75")]
	[Address(RVA = "0x7F75D0", Offset = "0x7F5BD0", VA = "0x1807F75D0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001E76 RID: 7798 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E76")]
	[Address(RVA = "0x7F79D0", Offset = "0x7F5FD0", VA = "0x1807F79D0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001E77 RID: 7799 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E77")]
	[Address(RVA = "0x7F7A60", Offset = "0x7F6060", VA = "0x1807F7A60", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x04000300 RID: 768
	[Token(Token = "0x4000300")]
	[FieldOffset(Offset = "0x0")]
	internal static VailAttachItemEvent_Meta Instance;
}
