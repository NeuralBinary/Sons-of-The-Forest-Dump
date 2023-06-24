using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Bolt
{
	// Token: 0x020000EC RID: 236
	[Token(Token = "0x20000EC")]
	public struct CachedObject<T> where T : Component
	{
		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000704 RID: 1796 RVA: 0x00004A88 File Offset: 0x00002C88
		[Token(Token = "0x17000133")]
		public bool Exists
		{
			[Token(Token = "0x6000704")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000705 RID: 1797 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000134")]
		public T Component
		{
			[Token(Token = "0x6000705")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400035E RID: 862
		[Token(Token = "0x400035E")]
		[FieldOffset(Offset = "0x0")]
		private T component;

		// Token: 0x0400035F RID: 863
		[Token(Token = "0x400035F")]
		[FieldOffset(Offset = "0x0")]
		private float lastCheck;
	}
}
