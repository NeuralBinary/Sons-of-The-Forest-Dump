using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Pathfinding
{
	// Token: 0x0200006A RID: 106
	[Token(Token = "0x200006A")]
	internal class PathReturnQueue
	{
		// Token: 0x060003D0 RID: 976 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x66C250", Offset = "0x66A850", VA = "0x18066C250")]
		public PathReturnQueue(object pathsClaimedSilentlyBy)
		{
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x66C370", Offset = "0x66A970", VA = "0x18066C370")]
		public void Enqueue(Path path)
		{
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x66C510", Offset = "0x66AB10", VA = "0x18066C510")]
		public void ReturnPaths(bool timeSlice)
		{
		}

		// Token: 0x040002AE RID: 686
		[Token(Token = "0x40002AE")]
		[FieldOffset(Offset = "0x10")]
		private Queue<Path> pathReturnQueue;

		// Token: 0x040002AF RID: 687
		[Token(Token = "0x40002AF")]
		[FieldOffset(Offset = "0x18")]
		private object pathsClaimedSilentlyBy;
	}
}
