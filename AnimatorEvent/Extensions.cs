using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;

namespace Ashkatchap.AnimatorEvents
{
	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	public static class Extensions
	{
		// Token: 0x0600002E RID: 46 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x5C4050", Offset = "0x5C2650", VA = "0x1805C4050")]
		public static string ToStringFull(this IList<EventSMB.Condition> conditions, AnimatorControllerParameter[] parameters, bool isDark = false)
		{
			return null;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x5C4260", Offset = "0x5C2860", VA = "0x1805C4260")]
		private static void Recursive(StringBuilder str, AnimatorControllerParameter[] parameters, IList<EventSMB.Condition> conditions, ref int index, bool isDark, bool groupOr = false, int rLevel = 0)
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x5C5810", Offset = "0x5C3E10", VA = "0x1805C5810")]
		private static AnimatorControllerParameter FindParam(AnimatorControllerParameter[] parameters, int hash)
		{
			return null;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x5C58D0", Offset = "0x5C3ED0", VA = "0x1805C58D0")]
		private static void Operand(StringBuilder str, int id, bool isDark)
		{
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x5C5A70", Offset = "0x5C4070", VA = "0x1805C5A70")]
		public static string ToStringFull(this AnimatorStateInfo info)
		{
			return null;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x5C5C40", Offset = "0x5C4240", VA = "0x1805C5C40")]
		public static string ToStringFull(this AnimatorClipInfo info)
		{
			return null;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x5C5D90", Offset = "0x5C4390", VA = "0x1805C5D90")]
		public static string ToStringFull(this AnimatorTransitionInfo info)
		{
			return null;
		}

		// Token: 0x04000065 RID: 101
		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x0")]
		private static string[] POpen;

		// Token: 0x04000066 RID: 102
		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x8")]
		private static string[] PClose;
	}
}
