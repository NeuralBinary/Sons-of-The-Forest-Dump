using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x0200005C RID: 92
	[Token(Token = "0x200005C")]
	[Conditional("UNITY_EDITOR")]
	[DontApplyToListElements]
	public class SearchableAttribute : Attribute
	{
		// Token: 0x060000F7 RID: 247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x2A89BE0", Offset = "0x2A881E0", VA = "0x182A89BE0")]
		public SearchableAttribute()
		{
		}

		// Token: 0x040000CF RID: 207
		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x10")]
		public bool FuzzySearch;

		// Token: 0x040000D0 RID: 208
		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x14")]
		public SearchFilterOptions FilterOptions;

		// Token: 0x040000D1 RID: 209
		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x18")]
		public bool Recursive;
	}
}
