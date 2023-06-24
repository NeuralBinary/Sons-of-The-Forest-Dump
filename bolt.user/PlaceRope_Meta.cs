using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000133 RID: 307
[Token(Token = "0x2000133")]
internal class PlaceRope_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06000E34 RID: 3636 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E34")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public PlaceRope_Meta()
	{
	}

	// Token: 0x1700057D RID: 1405
	// (get) Token: 0x06000E35 RID: 3637 RVA: 0x00006120 File Offset: 0x00004320
	[Token(Token = "0x1700057D")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000E35")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700057E RID: 1406
	// (get) Token: 0x06000E36 RID: 3638 RVA: 0x00006138 File Offset: 0x00004338
	[Token(Token = "0x1700057E")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000E36")]
		[Address(RVA = "0x86B210", Offset = "0x869810", VA = "0x18086B210", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700057F RID: 1407
	// (get) Token: 0x06000E37 RID: 3639 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700057F")]
	private Type TypeObject
	{
		[Token(Token = "0x6000E37")]
		[Address(RVA = "0x86B230", Offset = "0x869830", VA = "0x18086B230", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000E38 RID: 3640 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E38")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000E39 RID: 3641 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E39")]
	[Address(RVA = "0x86B2D0", Offset = "0x8698D0", VA = "0x18086B2D0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000E3A RID: 3642 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000E3A")]
	[Address(RVA = "0x86B8F0", Offset = "0x869EF0", VA = "0x18086B8F0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06000E3B RID: 3643 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E3B")]
	[Address(RVA = "0x86B980", Offset = "0x869F80", VA = "0x18086B980", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x04000289 RID: 649
	[Token(Token = "0x4000289")]
	[FieldOffset(Offset = "0x0")]
	internal static PlaceRope_Meta Instance;
}
