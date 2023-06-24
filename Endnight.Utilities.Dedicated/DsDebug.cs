using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Utilities.Dedicated
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	public static class DsDebug
	{
		// Token: 0x06000007 RID: 7 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000007")]
		[Address(RVA = "0xA827F0", Offset = "0xA80DF0", VA = "0x180A827F0")]
		public static void Log(object message)
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000008")]
		[Address(RVA = "0xA828B0", Offset = "0xA80EB0", VA = "0x180A828B0")]
		public static void Log(object message, UnityEngine.Object context)
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000009")]
		[Address(RVA = "0xA82970", Offset = "0xA80F70", VA = "0x180A82970")]
		public static void LogError(object message)
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000A")]
		[Address(RVA = "0xA82A30", Offset = "0xA81030", VA = "0x180A82A30")]
		public static void LogError(object message, UnityEngine.Object context)
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000B")]
		[Address(RVA = "0xA82AF0", Offset = "0xA810F0", VA = "0x180A82AF0")]
		public static void LogWarning(object message)
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000C")]
		[Address(RVA = "0xA82BB0", Offset = "0xA811B0", VA = "0x180A82BB0")]
		public static void LogWarning(object message, UnityEngine.Object context)
		{
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000D")]
		[Address(RVA = "0xA82C70", Offset = "0xA81270", VA = "0x180A82C70")]
		public static void LogException(Exception exception)
		{
		}

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		public const int DsLogFlag = 0;
	}
}
