using System;
using Il2CppDummyDll;

namespace Sons.Ai.Vail.StimuliSorting
{
	// Token: 0x0200014E RID: 334
	[Token(Token = "0x200014E")]
	public class Preferred : StimuliSortAction
	{
		// Token: 0x06000B4F RID: 2895 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000B4F")]
		[Address(RVA = "0x2B92EC0", Offset = "0x2B914C0", VA = "0x182B92EC0")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B50")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public Preferred()
		{
		}

		// Token: 0x04000837 RID: 2103
		[Token(Token = "0x4000837")]
		[FieldOffset(Offset = "0x0")]
		public static IStimuliSortAction.SortValueDelegate SortAction;
	}
}
