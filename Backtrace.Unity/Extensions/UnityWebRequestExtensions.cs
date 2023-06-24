using System;
using Il2CppDummyDll;
using UnityEngine.Networking;

namespace Backtrace.Unity.Extensions
{
	// Token: 0x02000078 RID: 120
	[Token(Token = "0x2000078")]
	public static class UnityWebRequestExtensions
	{
		// Token: 0x0600037B RID: 891 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600037B")]
		[Address(RVA = "0x768F60", Offset = "0x767560", VA = "0x180768F60")]
		internal static UnityWebRequest SetMultipartFormData(this UnityWebRequest source, byte[] boundaryId)
		{
			return null;
		}

		// Token: 0x0600037C RID: 892 RVA: 0x0000308C File Offset: 0x0000128C
		[Token(Token = "0x600037C")]
		[Address(RVA = "0x769020", Offset = "0x767620", VA = "0x180769020")]
		public static bool ReceivedNetworkError(this UnityWebRequest request)
		{
			return default(bool);
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600037D")]
		[Address(RVA = "0x7690D0", Offset = "0x7676D0", VA = "0x1807690D0")]
		internal static UnityWebRequest SetJsonContentType(this UnityWebRequest source)
		{
			return null;
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600037E")]
		[Address(RVA = "0x769130", Offset = "0x767730", VA = "0x180769130")]
		internal static UnityWebRequest IgnoreSsl(this UnityWebRequest source, bool shouldIgnore)
		{
			return null;
		}

		// Token: 0x0400021F RID: 543
		[Token(Token = "0x400021F")]
		internal const string ContentTypeHeader = "Content-Type";
	}
}
