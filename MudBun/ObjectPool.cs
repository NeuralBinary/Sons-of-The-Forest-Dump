using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace MudBun
{
	// Token: 0x0200013B RID: 315
	[Token(Token = "0x200013B")]
	public static class ObjectPool<T> where T : new()
	{
		// Token: 0x060007BD RID: 1981 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60007BD")]
		public static T Get()
		{
			return null;
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007BE")]
		public static void Put(T obj)
		{
		}

		// Token: 0x040004B4 RID: 1204
		[Token(Token = "0x40004B4")]
		[FieldOffset(Offset = "0x0")]
		private static List<T> s_pool;

		// Token: 0x040004B5 RID: 1205
		[Token(Token = "0x40004B5")]
		[FieldOffset(Offset = "0x0")]
		private static int s_iLast;
	}
}
