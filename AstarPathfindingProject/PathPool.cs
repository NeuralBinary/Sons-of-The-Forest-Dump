using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Pathfinding
{
	// Token: 0x02000065 RID: 101
	[Token(Token = "0x2000065")]
	public static class PathPool
	{
		// Token: 0x060003AC RID: 940 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x6685B0", Offset = "0x666BB0", VA = "0x1806685B0")]
		public static void Pool(Path path)
		{
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00003EFC File Offset: 0x000020FC
		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x668970", Offset = "0x666F70", VA = "0x180668970")]
		public static int GetTotalCreated(Type type)
		{
			return 0;
		}

		// Token: 0x060003AE RID: 942 RVA: 0x00003F14 File Offset: 0x00002114
		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x668A40", Offset = "0x667040", VA = "0x180668A40")]
		public static int GetSize(Type type)
		{
			return 0;
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AF")]
		public static T GetPath<T>() where T : Path, new()
		{
			return null;
		}

		// Token: 0x04000290 RID: 656
		[Token(Token = "0x4000290")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<Type, Stack<Path>> pool;

		// Token: 0x04000291 RID: 657
		[Token(Token = "0x4000291")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<Type, int> totalCreated;
	}
}
