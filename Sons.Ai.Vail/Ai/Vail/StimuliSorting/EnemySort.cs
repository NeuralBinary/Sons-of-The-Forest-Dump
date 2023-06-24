using System;
using Il2CppDummyDll;

namespace Sons.Ai.Vail.StimuliSorting
{
	// Token: 0x02000147 RID: 327
	[Token(Token = "0x2000147")]
	public class EnemySort : StimuliSortAction
	{
		// Token: 0x06000B3A RID: 2874 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000B3A")]
		[Address(RVA = "0x2B921E0", Offset = "0x2B907E0", VA = "0x182B921E0")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B3B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public EnemySort()
		{
		}

		// Token: 0x04000831 RID: 2097
		[Token(Token = "0x4000831")]
		[FieldOffset(Offset = "0x0")]
		public static IStimuliSortAction.SortValueDelegate SortAction;
	}
}
