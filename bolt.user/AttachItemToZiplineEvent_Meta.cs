using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000235 RID: 565
[Token(Token = "0x2000235")]
internal class AttachItemToZiplineEvent_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001A0A RID: 6666 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A0A")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public AttachItemToZiplineEvent_Meta()
	{
	}

	// Token: 0x1700077A RID: 1914
	// (get) Token: 0x06001A0B RID: 6667 RVA: 0x00008148 File Offset: 0x00006348
	[Token(Token = "0x1700077A")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001A0B")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700077B RID: 1915
	// (get) Token: 0x06001A0C RID: 6668 RVA: 0x00008160 File Offset: 0x00006360
	[Token(Token = "0x1700077B")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001A0C")]
		[Address(RVA = "0x8CE520", Offset = "0x8CCB20", VA = "0x1808CE520", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700077C RID: 1916
	// (get) Token: 0x06001A0D RID: 6669 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700077C")]
	private Type TypeObject
	{
		[Token(Token = "0x6001A0D")]
		[Address(RVA = "0x8CE540", Offset = "0x8CCB40", VA = "0x1808CE540", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001A0E RID: 6670 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A0E")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001A0F RID: 6671 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A0F")]
	[Address(RVA = "0x8CE5E0", Offset = "0x8CCBE0", VA = "0x1808CE5E0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001A10 RID: 6672 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A10")]
	[Address(RVA = "0x8CEC30", Offset = "0x8CD230", VA = "0x1808CEC30", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001A11 RID: 6673 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A11")]
	[Address(RVA = "0x8CECC0", Offset = "0x8CD2C0", VA = "0x1808CECC0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002DF RID: 735
	[Token(Token = "0x40002DF")]
	[FieldOffset(Offset = "0x0")]
	internal static AttachItemToZiplineEvent_Meta Instance;
}
