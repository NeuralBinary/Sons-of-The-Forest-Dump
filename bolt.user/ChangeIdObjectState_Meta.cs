using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200024A RID: 586
[Token(Token = "0x200024A")]
internal class ChangeIdObjectState_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001B12 RID: 6930 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B12")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public ChangeIdObjectState_Meta()
	{
	}

	// Token: 0x170007AA RID: 1962
	// (get) Token: 0x06001B13 RID: 6931 RVA: 0x00008478 File Offset: 0x00006678
	[Token(Token = "0x170007AA")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001B13")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170007AB RID: 1963
	// (get) Token: 0x06001B14 RID: 6932 RVA: 0x00008490 File Offset: 0x00006690
	[Token(Token = "0x170007AB")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001B14")]
		[Address(RVA = "0x7DCF00", Offset = "0x7DB500", VA = "0x1807DCF00", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170007AC RID: 1964
	// (get) Token: 0x06001B15 RID: 6933 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170007AC")]
	private Type TypeObject
	{
		[Token(Token = "0x6001B15")]
		[Address(RVA = "0x7DCF20", Offset = "0x7DB520", VA = "0x1807DCF20", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001B16 RID: 6934 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B16")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001B17 RID: 6935 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B17")]
	[Address(RVA = "0x7DCFC0", Offset = "0x7DB5C0", VA = "0x1807DCFC0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001B18 RID: 6936 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B18")]
	[Address(RVA = "0x7DD2D0", Offset = "0x7DB8D0", VA = "0x1807DD2D0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001B19 RID: 6937 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B19")]
	[Address(RVA = "0x7DD360", Offset = "0x7DB960", VA = "0x1807DD360", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002E6 RID: 742
	[Token(Token = "0x40002E6")]
	[FieldOffset(Offset = "0x0")]
	internal static ChangeIdObjectState_Meta Instance;
}
