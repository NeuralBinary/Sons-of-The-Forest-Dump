using System;
using Il2CppDummyDll;

namespace Pathfinding.Util
{
	// Token: 0x02000133 RID: 307
	[Token(Token = "0x2000133")]
	public static class ObjectPool<T> where T : class, IAstarPooledObject, new()
	{
		// Token: 0x060009B3 RID: 2483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009B3")]
		public static T Claim()
		{
			return null;
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60009B4")]
		public static void Release(ref T obj)
		{
		}
	}
}
