using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200021A RID: 538
[Token(Token = "0x200021A")]
internal class VailZoneStateEvent_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x060018CC RID: 6348 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018CC")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public VailZoneStateEvent_Meta()
	{
	}

	// Token: 0x17000747 RID: 1863
	// (get) Token: 0x060018CD RID: 6349 RVA: 0x00007E18 File Offset: 0x00006018
	[Token(Token = "0x17000747")]
	private TypeId TypeId
	{
		[Token(Token = "0x60018CD")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000748 RID: 1864
	// (get) Token: 0x060018CE RID: 6350 RVA: 0x00007E30 File Offset: 0x00006030
	[Token(Token = "0x17000748")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x60018CE")]
		[Address(RVA = "0x8C3D90", Offset = "0x8C2390", VA = "0x1808C3D90", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000749 RID: 1865
	// (get) Token: 0x060018CF RID: 6351 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000749")]
	private Type TypeObject
	{
		[Token(Token = "0x60018CF")]
		[Address(RVA = "0x8C3DB0", Offset = "0x8C23B0", VA = "0x1808C3DB0", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x060018D0 RID: 6352 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018D0")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x060018D1 RID: 6353 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018D1")]
	[Address(RVA = "0x8C3E50", Offset = "0x8C2450", VA = "0x1808C3E50", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x060018D2 RID: 6354 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018D2")]
	[Address(RVA = "0x8C43B0", Offset = "0x8C29B0", VA = "0x1808C43B0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x060018D3 RID: 6355 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018D3")]
	[Address(RVA = "0x8C4440", Offset = "0x8C2A40", VA = "0x1808C4440", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002D6 RID: 726
	[Token(Token = "0x40002D6")]
	[FieldOffset(Offset = "0x0")]
	internal static VailZoneStateEvent_Meta Instance;
}
