using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Settings
{
	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	public class MatchmakingSettings : MonoBehaviour
	{
		// Token: 0x060000AB RID: 171 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x3140A50", Offset = "0x313F050", VA = "0x183140A50")]
		public void OnEnable()
		{
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public MatchmakingSettings()
		{
		}

		// Token: 0x040000D2 RID: 210
		[Token(Token = "0x40000D2")]
		public const string DisableVersionFilteringKey = "Matchmaking.DisableVersionFiltering";

		// Token: 0x040000D3 RID: 211
		[Token(Token = "0x40000D3")]
		public const bool DisableVersionFilteringDefault = false;
	}
}
