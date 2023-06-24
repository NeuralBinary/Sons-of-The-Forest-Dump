using System;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000094 RID: 148
	[Token(Token = "0x2000094")]
	[Flags]
	public enum SearchFilterOptions
	{
		// Token: 0x0400077B RID: 1915
		[Token(Token = "0x400077B")]
		PropertyName = 1,
		// Token: 0x0400077C RID: 1916
		[Token(Token = "0x400077C")]
		PropertyNiceName = 2,
		// Token: 0x0400077D RID: 1917
		[Token(Token = "0x400077D")]
		TypeOfValue = 4,
		// Token: 0x0400077E RID: 1918
		[Token(Token = "0x400077E")]
		ValueToString = 8,
		// Token: 0x0400077F RID: 1919
		[Token(Token = "0x400077F")]
		ISearchFilterableInterface = 16,
		// Token: 0x04000780 RID: 1920
		[Token(Token = "0x4000780")]
		All = -1
	}
}
