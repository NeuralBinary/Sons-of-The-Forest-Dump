using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000196 RID: 406
[Token(Token = "0x2000196")]
internal class BeginAnimationSequenceStage_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001294 RID: 4756 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001294")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public BeginAnimationSequenceStage_Meta()
	{
	}

	// Token: 0x17000621 RID: 1569
	// (get) Token: 0x06001295 RID: 4757 RVA: 0x00006A80 File Offset: 0x00004C80
	[Token(Token = "0x17000621")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001295")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000622 RID: 1570
	// (get) Token: 0x06001296 RID: 4758 RVA: 0x00006A98 File Offset: 0x00004C98
	[Token(Token = "0x17000622")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001296")]
		[Address(RVA = "0x88E7B0", Offset = "0x88CDB0", VA = "0x18088E7B0", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000623 RID: 1571
	// (get) Token: 0x06001297 RID: 4759 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000623")]
	private Type TypeObject
	{
		[Token(Token = "0x6001297")]
		[Address(RVA = "0x88E7D0", Offset = "0x88CDD0", VA = "0x18088E7D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001298 RID: 4760 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001298")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001299 RID: 4761 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001299")]
	[Address(RVA = "0x88E870", Offset = "0x88CE70", VA = "0x18088E870", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x0600129A RID: 4762 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600129A")]
	[Address(RVA = "0x88EC80", Offset = "0x88D280", VA = "0x18088EC80", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x0600129B RID: 4763 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600129B")]
	[Address(RVA = "0x88ED10", Offset = "0x88D310", VA = "0x18088ED10", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002AA RID: 682
	[Token(Token = "0x40002AA")]
	[FieldOffset(Offset = "0x0")]
	internal static BeginAnimationSequenceStage_Meta Instance;
}
