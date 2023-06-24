using System;
using Il2CppDummyDll;

namespace Pathfinding.ClipperLib
{
	// Token: 0x02000012 RID: 18
	[Token(Token = "0x2000012")]
	internal class Scanbeam
	{
		// Token: 0x06000031 RID: 49 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public Scanbeam()
		{
		}

		// Token: 0x04000047 RID: 71
		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x10")]
		public long Y;

		// Token: 0x04000048 RID: 72
		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x18")]
		public Scanbeam Next;
	}
}
