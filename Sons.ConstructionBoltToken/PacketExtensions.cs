using System;
using Il2CppDummyDll;
using UdpKit;
using UnityEngine;

namespace Sons.ConstructionBoltToken
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	public static class PacketExtensions
	{
		// Token: 0x06000016 RID: 22 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x2DBEB00", Offset = "0x2DBD100", VA = "0x182DBEB00")]
		public static void WriteVector3(this UdpPacket stream, Vector3 value, int bits, int rightDecimals)
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x2DBEC60", Offset = "0x2DBD260", VA = "0x182DBEC60")]
		public static void WriteFloat(this UdpPacket stream, float value, int bits, int rightDecimals)
		{
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002080 File Offset: 0x00000280
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x2DBED00", Offset = "0x2DBD300", VA = "0x182DBED00")]
		public static float ReadFloat(this UdpPacket stream, int bits, int rightDecimals)
		{
			return 0f;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x2DBEDA0", Offset = "0x2DBD3A0", VA = "0x182DBEDA0")]
		public static Vector3 ReadVector3(this UdpPacket stream, int bits, int rightDecimals)
		{
			return default(Vector3);
		}
	}
}
