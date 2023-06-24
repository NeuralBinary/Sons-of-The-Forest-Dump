using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Crafting
{
	// Token: 0x020006C2 RID: 1730
	[Token(Token = "0x20006C2")]
	[CreateAssetMenu(fileName = "BlueprintBookPages", menuName = "Sons/Data/BlueprintBookPages", order = 0)]
	public class BlueprintBookPages : ScriptableObject
	{
		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06002DB3 RID: 11699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000615")]
		public List<BlueprintBookPageData> Pages
		{
			[Token(Token = "0x6002DB3")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06002DB4 RID: 11700 RVA: 0x0000D830 File Offset: 0x0000BA30
		[Token(Token = "0x17000616")]
		public int Count
		{
			[Token(Token = "0x6002DB4")]
			[Address(RVA = "0x343C270", Offset = "0x343A870", VA = "0x18343C270")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06002DB5 RID: 11701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DB5")]
		[Address(RVA = "0x343C2B0", Offset = "0x343A8B0", VA = "0x18343C2B0")]
		public BlueprintBookPages()
		{
		}

		// Token: 0x04002807 RID: 10247
		[Token(Token = "0x4002807")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<BlueprintBookPageData> _pages;
	}
}
