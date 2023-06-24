using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sons.Ai.Vail.StimuliQueries
{
	// Token: 0x0200012A RID: 298
	[Token(Token = "0x200012A")]
	public static class StimuliQueryUtils
	{
		// Token: 0x06000AD5 RID: 2773 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000AD5")]
		public static Type FindType<T>(string stimuliQueryType)
		{
			return null;
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000AD6")]
		private static IEnumerable<Type> FindTypesCached<T>()
		{
			return null;
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000AD7")]
		[Address(RVA = "0x2B90810", Offset = "0x2B8EE10", VA = "0x182B90810")]
		public static string GetMenuId(Type queryType)
		{
			return null;
		}

		// Token: 0x04000822 RID: 2082
		[Token(Token = "0x4000822")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<Type, Type[]> _cachedTypes;

		// Token: 0x04000823 RID: 2083
		[Token(Token = "0x4000823")]
		[FieldOffset(Offset = "0x8")]
		private static Dictionary<string, Type> _cachedTypeNames;
	}
}
