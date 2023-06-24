using System;
using Il2CppDummyDll;
using Sirenix.OdinInspector;

namespace Sons.Ai.Vail.StimuliSorting
{
	// Token: 0x02000152 RID: 338
	[Token(Token = "0x2000152")]
	public abstract class StimuliSortAction : IStimuliSortAction
	{
		// Token: 0x06000B5B RID: 2907 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000B5B")]
		[Address(RVA = "0x2B93440", Offset = "0x2B91A40", VA = "0x182B93440")]
		public static IStimuliSortAction.SortValueDelegate GetDelegate(string stimuliSort)
		{
			return null;
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000B5C")]
		[Address(RVA = "0x2B938A0", Offset = "0x2B91EA0", VA = "0x182B938A0")]
		public static ValueDropdownList<string> GetQueryValueDropdownList()
		{
			return null;
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B5D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		protected StimuliSortAction()
		{
		}
	}
}
