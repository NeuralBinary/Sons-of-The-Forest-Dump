using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020001AE RID: 430
[Token(Token = "0x20001AE")]
internal class loadEndGamePrefabs_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x060013AA RID: 5034 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013AA")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public loadEndGamePrefabs_Meta()
	{
	}

	// Token: 0x1700064E RID: 1614
	// (get) Token: 0x060013AB RID: 5035 RVA: 0x00006D20 File Offset: 0x00004F20
	[Token(Token = "0x1700064E")]
	private TypeId TypeId
	{
		[Token(Token = "0x60013AB")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700064F RID: 1615
	// (get) Token: 0x060013AC RID: 5036 RVA: 0x00006D38 File Offset: 0x00004F38
	[Token(Token = "0x1700064F")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x60013AC")]
		[Address(RVA = "0x8976F0", Offset = "0x895CF0", VA = "0x1808976F0", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000650 RID: 1616
	// (get) Token: 0x060013AD RID: 5037 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000650")]
	private Type TypeObject
	{
		[Token(Token = "0x60013AD")]
		[Address(RVA = "0x897710", Offset = "0x895D10", VA = "0x180897710", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x060013AE RID: 5038 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013AE")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x060013AF RID: 5039 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013AF")]
	[Address(RVA = "0x8977B0", Offset = "0x895DB0", VA = "0x1808977B0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x060013B0 RID: 5040 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60013B0")]
	[Address(RVA = "0x8979A0", Offset = "0x895FA0", VA = "0x1808979A0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x060013B1 RID: 5041 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013B1")]
	[Address(RVA = "0x897A30", Offset = "0x896030", VA = "0x180897A30", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002B2 RID: 690
	[Token(Token = "0x40002B2")]
	[FieldOffset(Offset = "0x0")]
	internal static loadEndGamePrefabs_Meta Instance;
}
