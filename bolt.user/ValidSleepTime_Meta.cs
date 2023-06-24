using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020001B7 RID: 439
[Token(Token = "0x20001B7")]
internal class ValidSleepTime_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001412 RID: 5138 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001412")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public ValidSleepTime_Meta()
	{
	}

	// Token: 0x1700065E RID: 1630
	// (get) Token: 0x06001413 RID: 5139 RVA: 0x00006DE0 File Offset: 0x00004FE0
	[Token(Token = "0x1700065E")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001413")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700065F RID: 1631
	// (get) Token: 0x06001414 RID: 5140 RVA: 0x00006DF8 File Offset: 0x00004FF8
	[Token(Token = "0x1700065F")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001414")]
		[Address(RVA = "0x89AE00", Offset = "0x899400", VA = "0x18089AE00", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000660 RID: 1632
	// (get) Token: 0x06001415 RID: 5141 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000660")]
	private Type TypeObject
	{
		[Token(Token = "0x6001415")]
		[Address(RVA = "0x89AE20", Offset = "0x899420", VA = "0x18089AE20", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001416 RID: 5142 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001416")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001417 RID: 5143 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001417")]
	[Address(RVA = "0x89AEC0", Offset = "0x8994C0", VA = "0x18089AEC0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001418 RID: 5144 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001418")]
	[Address(RVA = "0x89B0C0", Offset = "0x8996C0", VA = "0x18089B0C0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001419 RID: 5145 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001419")]
	[Address(RVA = "0x89B150", Offset = "0x899750", VA = "0x18089B150", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002B5 RID: 693
	[Token(Token = "0x40002B5")]
	[FieldOffset(Offset = "0x0")]
	internal static ValidSleepTime_Meta Instance;
}
