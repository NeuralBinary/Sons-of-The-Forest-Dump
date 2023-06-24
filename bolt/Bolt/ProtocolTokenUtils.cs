using System;
using Il2CppDummyDll;
using UdpKit;

namespace Bolt
{
	// Token: 0x0200005F RID: 95
	[Token(Token = "0x200005F")]
	public static class ProtocolTokenUtils
	{
		// Token: 0x060003D4 RID: 980 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x8DB5B0", Offset = "0x8D9BB0", VA = "0x1808DB5B0")]
		public static byte[] ToByteArray(this IProtocolToken token)
		{
			return null;
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x8DB9F0", Offset = "0x8D9FF0", VA = "0x1808DB9F0")]
		public static IProtocolToken ToToken(this byte[] bytes)
		{
			return null;
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x8DBBD0", Offset = "0x8DA1D0", VA = "0x1808DBBD0")]
		public static void WriteToken(this UdpPacket packet, IProtocolToken token)
		{
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x8DBCA0", Offset = "0x8DA2A0", VA = "0x1808DBCA0")]
		public static IProtocolToken ReadToken(this UdpPacket packet)
		{
			return null;
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x8DBD50", Offset = "0x8DA350", VA = "0x1808DBD50")]
		public static void SerializeToken(this UdpPacket packet, ref IProtocolToken token)
		{
		}

		// Token: 0x04000190 RID: 400
		[Token(Token = "0x4000190")]
		[FieldOffset(Offset = "0x0")]
		private static byte[] tempBytes;

		// Token: 0x04000191 RID: 401
		[Token(Token = "0x4000191")]
		[FieldOffset(Offset = "0x8")]
		private static UdpPacket tempPacket;
	}
}
