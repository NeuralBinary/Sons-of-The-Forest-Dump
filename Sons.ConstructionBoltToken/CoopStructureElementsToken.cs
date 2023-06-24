using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Bolt;
using Il2CppDummyDll;
using UdpKit;

namespace Sons.ConstructionBoltToken
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	public class CoopStructureElementsToken : IProtocolToken
	{
		// Token: 0x06000009 RID: 9 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x2DBDBD0", Offset = "0x2DBC1D0", VA = "0x182DBDBD0", Slot = "5")]
		private void Write(UdpPacket packet)
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x2DBDD60", Offset = "0x2DBC360", VA = "0x182DBDD60", Slot = "4")]
		private void Read(UdpPacket packet)
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public CoopStructureElementsToken()
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x2DBE090", Offset = "0x2DBC690", VA = "0x182DBE090")]
		[CompilerGenerated]
		private void <Bolt.IProtocolToken.Write>g__WriteNonPresetElements|6_0(ref CoopStructureElementsToken.<>c__DisplayClass6_0 A_1)
		{
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x2DBE370", Offset = "0x2DBC970", VA = "0x182DBE370")]
		[CompilerGenerated]
		internal static bool <Bolt.IProtocolToken.Write>g__IsNullOrDestroyed|6_1(ISyncableElement element)
		{
			return default(bool);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x2DBE560", Offset = "0x2DBCB60", VA = "0x182DBE560")]
		[CompilerGenerated]
		private void <Bolt.IProtocolToken.Read>g__ReadNonPresetElements|7_0(ref CoopStructureElementsToken.<>c__DisplayClass7_0 A_1)
		{
		}

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x10")]
		public List<ISyncableElement> SourceElements;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x18")]
		public List<ElementID> DestElements;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		private const int _positionBits = 23;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		private const int _anglesbits = 19;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		private const int _scaleBits = 15;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		private const int _floatingDecimals = 3;
	}
}
