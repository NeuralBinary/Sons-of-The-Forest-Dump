using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Crafting
{
	// Token: 0x020007B7 RID: 1975
	[Token(Token = "0x20007B7")]
	[CreateAssetMenu(fileName = "BlueprintBookPages", menuName = "Sons/Data/BlueprintBookPages", order = 0)]
	public class BlueprintBookPages : ScriptableObject
	{
		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x0600343A RID: 13370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006A8")]
		public List<BlueprintBookPageData> Pages
		{
			[Token(Token = "0x600343A")]
			[Address(RVA = "0x57B1D0", Offset = "0x57A1D0", VA = "0x18057B1D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x0600343B RID: 13371 RVA: 0x0000EF58 File Offset: 0x0000D158
		[Token(Token = "0x170006A9")]
		public int Count
		{
			[Token(Token = "0x600343B")]
			[Address(RVA = "0x2E577D0", Offset = "0x2E567D0", VA = "0x182E577D0")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x0600343C RID: 13372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600343C")]
		[Address(RVA = "0x2E57750", Offset = "0x2E56750", VA = "0x182E57750")]
		public BlueprintBookPages()
		{
		}

		// Token: 0x04002D33 RID: 11571
		[Token(Token = "0x4002D33")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<BlueprintBookPageData> _pages;
	}
}
