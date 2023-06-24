using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000148 RID: 328
[Token(Token = "0x2000148")]
internal class DestroyWithTag_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06000F1E RID: 3870 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F1E")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public DestroyWithTag_Meta()
	{
	}

	// Token: 0x1700059E RID: 1438
	// (get) Token: 0x06000F1F RID: 3871 RVA: 0x00006300 File Offset: 0x00004500
	[Token(Token = "0x1700059E")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000F1F")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700059F RID: 1439
	// (get) Token: 0x06000F20 RID: 3872 RVA: 0x00006318 File Offset: 0x00004518
	[Token(Token = "0x1700059F")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000F20")]
		[Address(RVA = "0x8729B0", Offset = "0x870FB0", VA = "0x1808729B0", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170005A0 RID: 1440
	// (get) Token: 0x06000F21 RID: 3873 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170005A0")]
	private Type TypeObject
	{
		[Token(Token = "0x6000F21")]
		[Address(RVA = "0x8729D0", Offset = "0x870FD0", VA = "0x1808729D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000F22 RID: 3874 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F22")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000F23 RID: 3875 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F23")]
	[Address(RVA = "0x872A70", Offset = "0x871070", VA = "0x180872A70", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000F24 RID: 3876 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F24")]
	[Address(RVA = "0x872C60", Offset = "0x871260", VA = "0x180872C60", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06000F25 RID: 3877 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F25")]
	[Address(RVA = "0x872CF0", Offset = "0x8712F0", VA = "0x180872CF0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x04000290 RID: 656
	[Token(Token = "0x4000290")]
	[FieldOffset(Offset = "0x0")]
	internal static DestroyWithTag_Meta Instance;
}
