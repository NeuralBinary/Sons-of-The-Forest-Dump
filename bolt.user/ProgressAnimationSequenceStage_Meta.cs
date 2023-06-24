using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000199 RID: 409
[Token(Token = "0x2000199")]
internal class ProgressAnimationSequenceStage_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x060012B4 RID: 4788 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012B4")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public ProgressAnimationSequenceStage_Meta()
	{
	}

	// Token: 0x17000625 RID: 1573
	// (get) Token: 0x060012B5 RID: 4789 RVA: 0x00006AB0 File Offset: 0x00004CB0
	[Token(Token = "0x17000625")]
	private TypeId TypeId
	{
		[Token(Token = "0x60012B5")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000626 RID: 1574
	// (get) Token: 0x060012B6 RID: 4790 RVA: 0x00006AC8 File Offset: 0x00004CC8
	[Token(Token = "0x17000626")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x60012B6")]
		[Address(RVA = "0x88F940", Offset = "0x88DF40", VA = "0x18088F940", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000627 RID: 1575
	// (get) Token: 0x060012B7 RID: 4791 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000627")]
	private Type TypeObject
	{
		[Token(Token = "0x60012B7")]
		[Address(RVA = "0x88F960", Offset = "0x88DF60", VA = "0x18088F960", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x060012B8 RID: 4792 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012B8")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x060012B9 RID: 4793 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012B9")]
	[Address(RVA = "0x88FA00", Offset = "0x88E000", VA = "0x18088FA00", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x060012BA RID: 4794 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60012BA")]
	[Address(RVA = "0x88FBF0", Offset = "0x88E1F0", VA = "0x18088FBF0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x060012BB RID: 4795 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012BB")]
	[Address(RVA = "0x88FC80", Offset = "0x88E280", VA = "0x18088FC80", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002AB RID: 683
	[Token(Token = "0x40002AB")]
	[FieldOffset(Offset = "0x0")]
	internal static ProgressAnimationSequenceStage_Meta Instance;
}
