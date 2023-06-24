using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020000D9 RID: 217
[Token(Token = "0x20000D9")]
internal class PlaneCrashIndex_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06000A20 RID: 2592 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A20")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public PlaneCrashIndex_Meta()
	{
	}

	// Token: 0x170004DB RID: 1243
	// (get) Token: 0x06000A21 RID: 2593 RVA: 0x00005790 File Offset: 0x00003990
	[Token(Token = "0x170004DB")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000A21")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170004DC RID: 1244
	// (get) Token: 0x06000A22 RID: 2594 RVA: 0x000057A8 File Offset: 0x000039A8
	[Token(Token = "0x170004DC")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000A22")]
		[Address(RVA = "0x848BA0", Offset = "0x8471A0", VA = "0x180848BA0", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170004DD RID: 1245
	// (get) Token: 0x06000A23 RID: 2595 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170004DD")]
	private Type TypeObject
	{
		[Token(Token = "0x6000A23")]
		[Address(RVA = "0x848BC0", Offset = "0x8471C0", VA = "0x180848BC0", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000A24 RID: 2596 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A24")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000A25 RID: 2597 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A25")]
	[Address(RVA = "0x848C60", Offset = "0x847260", VA = "0x180848C60", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000A26 RID: 2598 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A26")]
	[Address(RVA = "0x848F90", Offset = "0x847590", VA = "0x180848F90", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06000A27 RID: 2599 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A27")]
	[Address(RVA = "0x849020", Offset = "0x847620", VA = "0x180849020", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x0400026B RID: 619
	[Token(Token = "0x400026B")]
	[FieldOffset(Offset = "0x0")]
	internal static PlaneCrashIndex_Meta Instance;
}
