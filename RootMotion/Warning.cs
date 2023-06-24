using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02000027 RID: 39
	[Token(Token = "0x2000027")]
	public static class Warning
	{
		// Token: 0x06000109 RID: 265 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x28F6480", Offset = "0x28F4A80", VA = "0x1828F6480")]
		public static void Log(string message, Warning.Logger logger, bool logInEditMode = false)
		{
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x28F6570", Offset = "0x28F4B70", VA = "0x1828F6570")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}

		// Token: 0x040000EB RID: 235
		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x0")]
		public static bool logged;

		// Token: 0x02000028 RID: 40
		// (Invoke) Token: 0x0600010C RID: 268
		[Token(Token = "0x2000028")]
		public delegate void Logger(string message);
	}
}
