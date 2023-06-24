using System;
using Il2CppDummyDll;

namespace Sons.Ai.Vail.StimuliSorting
{
	// Token: 0x02000150 RID: 336
	[Token(Token = "0x2000150")]
	public class Random : StimuliSortAction
	{
		// Token: 0x06000B55 RID: 2901 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000B55")]
		[Address(RVA = "0x2B93240", Offset = "0x2B91840", VA = "0x182B93240")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B56")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public Random()
		{
		}

		// Token: 0x04000839 RID: 2105
		[Token(Token = "0x4000839")]
		[FieldOffset(Offset = "0x0")]
		public static readonly IStimuliSortAction.SortValueDelegate SortAction;
	}
}
