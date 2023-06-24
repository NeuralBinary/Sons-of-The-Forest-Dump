using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200018D RID: 397
[Token(Token = "0x200018D")]
internal class updateMecanimRemoteState_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001230 RID: 4656 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001230")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public updateMecanimRemoteState_Meta()
	{
	}

	// Token: 0x17000613 RID: 1555
	// (get) Token: 0x06001231 RID: 4657 RVA: 0x000069A8 File Offset: 0x00004BA8
	[Token(Token = "0x17000613")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001231")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000614 RID: 1556
	// (get) Token: 0x06001232 RID: 4658 RVA: 0x000069C0 File Offset: 0x00004BC0
	[Token(Token = "0x17000614")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001232")]
		[Address(RVA = "0x88B550", Offset = "0x889B50", VA = "0x18088B550", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000615 RID: 1557
	// (get) Token: 0x06001233 RID: 4659 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000615")]
	private Type TypeObject
	{
		[Token(Token = "0x6001233")]
		[Address(RVA = "0x88B570", Offset = "0x889B70", VA = "0x18088B570", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001234 RID: 4660 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001234")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001235 RID: 4661 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001235")]
	[Address(RVA = "0x88B610", Offset = "0x889C10", VA = "0x18088B610", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001236 RID: 4662 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001236")]
	[Address(RVA = "0x88BC80", Offset = "0x88A280", VA = "0x18088BC80", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001237 RID: 4663 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001237")]
	[Address(RVA = "0x88BD10", Offset = "0x88A310", VA = "0x18088BD10", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002A7 RID: 679
	[Token(Token = "0x40002A7")]
	[FieldOffset(Offset = "0x0")]
	internal static updateMecanimRemoteState_Meta Instance;
}
