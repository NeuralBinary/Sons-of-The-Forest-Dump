using System;
using System.Collections.Generic;
using Bolt;
using Il2CppDummyDll;
using UdpKit;

namespace Sons.ConstructionBoltToken
{
	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000009")]
	public class CoopStructureListToken : IProtocolToken
	{
		// Token: 0x0600000F RID: 15 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x2DBE750", Offset = "0x2DBCD50", VA = "0x182DBE750", Slot = "5")]
		private void Write(UdpPacket packet)
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x2DBE8B0", Offset = "0x2DBCEB0", VA = "0x182DBE8B0", Slot = "4")]
		private void Read(UdpPacket packet)
		{
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public CoopStructureListToken()
		{
		}

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x10")]
		public List<StructureID> Structures;
	}
}
