using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000112 RID: 274
[Token(Token = "0x2000112")]
internal class PlayerAddItem_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06000CA8 RID: 3240 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CA8")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public PlayerAddItem_Meta()
	{
	}

	// Token: 0x1700053B RID: 1339
	// (get) Token: 0x06000CA9 RID: 3241 RVA: 0x00005D78 File Offset: 0x00003F78
	[Token(Token = "0x1700053B")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000CA9")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700053C RID: 1340
	// (get) Token: 0x06000CAA RID: 3242 RVA: 0x00005D90 File Offset: 0x00003F90
	[Token(Token = "0x1700053C")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000CAA")]
		[Address(RVA = "0x85D230", Offset = "0x85B830", VA = "0x18085D230", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700053D RID: 1341
	// (get) Token: 0x06000CAB RID: 3243 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700053D")]
	private Type TypeObject
	{
		[Token(Token = "0x6000CAB")]
		[Address(RVA = "0x85D250", Offset = "0x85B850", VA = "0x18085D250", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000CAC RID: 3244 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CAC")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000CAD RID: 3245 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CAD")]
	[Address(RVA = "0x85D2F0", Offset = "0x85B8F0", VA = "0x18085D2F0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000CAE RID: 3246 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000CAE")]
	[Address(RVA = "0x85D830", Offset = "0x85BE30", VA = "0x18085D830", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06000CAF RID: 3247 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CAF")]
	[Address(RVA = "0x85D8C0", Offset = "0x85BEC0", VA = "0x18085D8C0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x0400027E RID: 638
	[Token(Token = "0x400027E")]
	[FieldOffset(Offset = "0x0")]
	internal static PlayerAddItem_Meta Instance;
}
