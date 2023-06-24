using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Bolt
{
	// Token: 0x020000ED RID: 237
	[Token(Token = "0x20000ED")]
	public struct CachedComponent<T> where T : Component
	{
		// Token: 0x06000706 RID: 1798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000706")]
		public CachedComponent(GameObject gameObject, bool scanChildren)
		{
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000707 RID: 1799 RVA: 0x00004AA0 File Offset: 0x00002CA0
		[Token(Token = "0x17000135")]
		public bool Exists
		{
			[Token(Token = "0x6000707")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000708 RID: 1800 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000136")]
		public T Component
		{
			[Token(Token = "0x6000708")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000360 RID: 864
		[Token(Token = "0x4000360")]
		[FieldOffset(Offset = "0x0")]
		private T component;

		// Token: 0x04000361 RID: 865
		[Token(Token = "0x4000361")]
		[FieldOffset(Offset = "0x0")]
		private readonly GameObject go;

		// Token: 0x04000362 RID: 866
		[Token(Token = "0x4000362")]
		[FieldOffset(Offset = "0x0")]
		private readonly bool children;
	}
}
