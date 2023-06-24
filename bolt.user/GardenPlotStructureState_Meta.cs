using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000035 RID: 53
[Token(Token = "0x2000035")]
internal class GardenPlotStructureState_Meta : NetworkState_Meta, ISerializerFactory, IFactory
{
	// Token: 0x0600012F RID: 303 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600012F")]
	[Address(RVA = "0x7BA8C0", Offset = "0x7B8EC0", VA = "0x1807BA8C0")]
	public GardenPlotStructureState_Meta()
	{
	}

	// Token: 0x17000082 RID: 130
	// (get) Token: 0x06000130 RID: 304 RVA: 0x00002718 File Offset: 0x00000918
	[Token(Token = "0x17000082")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000130")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000083 RID: 131
	// (get) Token: 0x06000131 RID: 305 RVA: 0x00002730 File Offset: 0x00000930
	[Token(Token = "0x17000083")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000131")]
		[Address(RVA = "0x7C0A40", Offset = "0x7BF040", VA = "0x1807C0A40", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000084 RID: 132
	// (get) Token: 0x06000132 RID: 306 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000084")]
	private Type TypeObject
	{
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x7C0A60", Offset = "0x7BF060", VA = "0x1807C0A60", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000133 RID: 307 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000133")]
	[Address(RVA = "0x7C0B00", Offset = "0x7BF100", VA = "0x1807C0B00", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000134 RID: 308 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000134")]
	[Address(RVA = "0x7C0F80", Offset = "0x7BF580", VA = "0x1807C0F80", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000135 RID: 309 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000135")]
	[Address(RVA = "0x7C1E70", Offset = "0x7C0470", VA = "0x1807C1E70", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x04000234 RID: 564
	[Token(Token = "0x4000234")]
	[FieldOffset(Offset = "0x0")]
	internal static GardenPlotStructureState_Meta Instance;
}
