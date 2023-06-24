using System;
using Il2CppDummyDll;
using UnityEngine;

namespace MudBun
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	[ExecuteInEditMode]
	public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000001")]
		public static T Instance
		{
			[Token(Token = "0x600000D")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600000E")]
		public static T Init()
		{
			return null;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000F")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000010")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000011")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000012")]
		protected virtual void OnApplicationQuit()
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000013")]
		public Singleton()
		{
		}

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x0")]
		private static bool s_init;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x0")]
		private static bool s_shuttingDown;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x0")]
		private static object s_lock;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x0")]
		private static T s_instance;
	}
}
