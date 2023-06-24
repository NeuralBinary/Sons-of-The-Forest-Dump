using System;
using Il2CppDummyDll;
using TriangleNet.Geometry;
using TriangleNet.Topology;

namespace TriangleNet.Meshing.Data
{
	// Token: 0x02000058 RID: 88
	[Token(Token = "0x2000058")]
	internal class BadSubseg
	{
		// Token: 0x060002B9 RID: 697 RVA: 0x00002EC8 File Offset: 0x000010C8
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x210F730", Offset = "0x210DD30", VA = "0x18210F730", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x24D2790", Offset = "0x24D0D90", VA = "0x1824D2790", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public BadSubseg()
		{
		}

		// Token: 0x040002C9 RID: 713
		[Token(Token = "0x40002C9")]
		[FieldOffset(Offset = "0x10")]
		public Osub subseg;

		// Token: 0x040002CA RID: 714
		[Token(Token = "0x40002CA")]
		[FieldOffset(Offset = "0x20")]
		public Vertex org;

		// Token: 0x040002CB RID: 715
		[Token(Token = "0x40002CB")]
		[FieldOffset(Offset = "0x28")]
		public Vertex dest;
	}
}
