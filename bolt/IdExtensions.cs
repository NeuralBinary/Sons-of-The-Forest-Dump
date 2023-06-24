using System;
using Bolt;
using Il2CppDummyDll;
using UdpKit;

// Token: 0x02000020 RID: 32
[Token(Token = "0x2000020")]
internal static class IdExtensions
{
	// Token: 0x060000F1 RID: 241 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x784800", Offset = "0x782E00", VA = "0x180784800")]
	public static void WritePrefabId(this UdpPacket stream, PrefabId id)
	{
	}

	// Token: 0x060000F2 RID: 242 RVA: 0x000023A0 File Offset: 0x000005A0
	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x784880", Offset = "0x782E80", VA = "0x180784880")]
	public static PrefabId ReadPrefabId(this UdpPacket stream)
	{
		return default(PrefabId);
	}

	// Token: 0x060000F3 RID: 243 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x784800", Offset = "0x782E00", VA = "0x180784800")]
	public static void WriteTypeId(this UdpPacket stream, TypeId id)
	{
	}

	// Token: 0x060000F4 RID: 244 RVA: 0x000023B8 File Offset: 0x000005B8
	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x784880", Offset = "0x782E80", VA = "0x180784880")]
	public static TypeId ReadTypeId(this UdpPacket stream)
	{
		return default(TypeId);
	}
}
