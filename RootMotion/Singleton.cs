using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02000023 RID: 35
	[Token(Token = "0x2000023")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x1700000D")]
		public static T instance
		{
			[Token(Token = "0x60000E8")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000E9")]
		protected virtual void Awake()
		{
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000EA")]
		protected Singleton()
		{
		}

		// Token: 0x040000E3 RID: 227
		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x0")]
		private static T sInstance;
	}
}
