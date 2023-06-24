using System;
using Il2CppDummyDll;

namespace Sons.Ai.Vail.StimuliSorting
{
	// Token: 0x0200014B RID: 331
	[Token(Token = "0x200014B")]
	public class LookAtSort : StimuliSortAction
	{
		// Token: 0x06000B46 RID: 2886 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000B46")]
		[Address(RVA = "0x2B929E0", Offset = "0x2B90FE0", VA = "0x182B929E0")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B47")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public LookAtSort()
		{
		}

		// Token: 0x04000835 RID: 2101
		[Token(Token = "0x4000835")]
		[FieldOffset(Offset = "0x0")]
		public static IStimuliSortAction.SortValueDelegate SortAction;
	}
}
