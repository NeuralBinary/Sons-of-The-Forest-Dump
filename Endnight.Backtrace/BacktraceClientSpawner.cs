using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Backtrace
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	public class BacktraceClientSpawner : MonoBehaviour
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000003")]
		[Address(RVA = "0xA5C840", Offset = "0xA5AE40", VA = "0x180A5C840")]
		private void Awake()
		{
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000004")]
		[Address(RVA = "0xA5CA90", Offset = "0xA5B090", VA = "0x180A5CA90")]
		private bool HasBacktraceCommandArg()
		{
			return default(bool);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002080 File Offset: 0x00000280
		[Token(Token = "0x6000005")]
		[Address(RVA = "0xA5CB10", Offset = "0xA5B110", VA = "0x180A5CB10")]
		private bool MatchesBacktraceCommandArg(string argument)
		{
			return default(bool);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public BacktraceClientSpawner()
		{
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		private const string BackTraceStringArg = "backtrace";

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _backtraceClientPrefab;
	}
}
