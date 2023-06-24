using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200019C RID: 412
[Token(Token = "0x200019C")]
internal class CompleteAnimationSequenceStage_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x060012D6 RID: 4822 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012D6")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public CompleteAnimationSequenceStage_Meta()
	{
	}

	// Token: 0x1700062A RID: 1578
	// (get) Token: 0x060012D7 RID: 4823 RVA: 0x00006AF8 File Offset: 0x00004CF8
	[Token(Token = "0x1700062A")]
	private TypeId TypeId
	{
		[Token(Token = "0x60012D7")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700062B RID: 1579
	// (get) Token: 0x060012D8 RID: 4824 RVA: 0x00006B10 File Offset: 0x00004D10
	[Token(Token = "0x1700062B")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x60012D8")]
		[Address(RVA = "0x890930", Offset = "0x88EF30", VA = "0x180890930", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700062C RID: 1580
	// (get) Token: 0x060012D9 RID: 4825 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700062C")]
	private Type TypeObject
	{
		[Token(Token = "0x60012D9")]
		[Address(RVA = "0x890950", Offset = "0x88EF50", VA = "0x180890950", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x060012DA RID: 4826 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012DA")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x060012DB RID: 4827 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012DB")]
	[Address(RVA = "0x8909F0", Offset = "0x88EFF0", VA = "0x1808909F0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x060012DC RID: 4828 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60012DC")]
	[Address(RVA = "0x890CF0", Offset = "0x88F2F0", VA = "0x180890CF0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x060012DD RID: 4829 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012DD")]
	[Address(RVA = "0x890D80", Offset = "0x88F380", VA = "0x180890D80", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002AC RID: 684
	[Token(Token = "0x40002AC")]
	[FieldOffset(Offset = "0x0")]
	internal static CompleteAnimationSequenceStage_Meta Instance;
}
