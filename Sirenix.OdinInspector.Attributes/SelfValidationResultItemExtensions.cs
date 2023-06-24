using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000085 RID: 133
	[Token(Token = "0x2000085")]
	public static class SelfValidationResultItemExtensions
	{
		// Token: 0x0600014A RID: 330 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x2A8AC40", Offset = "0x2A89240", VA = "0x182A8AC40")]
		public static ref SelfValidationResult.ResultItem WithFix(this SelfValidationResult.ResultItem item, string title, Action fix, bool offerInInspector = true)
		{
			return null;
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600014B")]
		public static ref SelfValidationResult.ResultItem WithFix<T>(this SelfValidationResult.ResultItem item, string title, Action<T> fix, bool offerInInspector = true) where T : new()
		{
			return null;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x2A8ADA0", Offset = "0x2A893A0", VA = "0x182A8ADA0")]
		public static ref SelfValidationResult.ResultItem WithFix(this SelfValidationResult.ResultItem item, Action fix, bool offerInInspector = true)
		{
			return null;
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600014D")]
		public static ref SelfValidationResult.ResultItem WithFix<T>(this SelfValidationResult.ResultItem item, Action<T> fix, bool offerInInspector = true) where T : new()
		{
			return null;
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x2A8AF10", Offset = "0x2A89510", VA = "0x182A8AF10")]
		public static ref SelfValidationResult.ResultItem WithFix(this SelfValidationResult.ResultItem item, SelfFix fix)
		{
			return null;
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x2A8B020", Offset = "0x2A89620", VA = "0x182A8B020")]
		public static ref SelfValidationResult.ResultItem WithContextClick(this SelfValidationResult.ResultItem item, Func<IEnumerable<SelfValidationResult.ContextMenuItem>> onContextClick)
		{
			return null;
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x2A8B080", Offset = "0x2A89680", VA = "0x182A8B080")]
		public static ref SelfValidationResult.ResultItem WithContextClick(this SelfValidationResult.ResultItem item, string path, Action onClick)
		{
			return null;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x2A8B230", Offset = "0x2A89830", VA = "0x182A8B230")]
		public static ref SelfValidationResult.ResultItem WithContextClick(this SelfValidationResult.ResultItem item, string path, bool on, Action onClick)
		{
			return null;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x2A8B3E0", Offset = "0x2A899E0", VA = "0x182A8B3E0")]
		public static ref SelfValidationResult.ResultItem WithContextClick(this SelfValidationResult.ResultItem item, SelfValidationResult.ContextMenuItem onContextClick)
		{
			return null;
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000153")]
		[Address(RVA = "0x2A8B560", Offset = "0x2A89B60", VA = "0x182A8B560")]
		public static ref SelfValidationResult.ResultItem WithSceneGUI(this SelfValidationResult.ResultItem item, Action onSceneGUI)
		{
			return null;
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000154")]
		[Address(RVA = "0x2A8B5C0", Offset = "0x2A89BC0", VA = "0x182A8B5C0")]
		public static ref SelfValidationResult.ResultItem WithMetaData(this SelfValidationResult.ResultItem resultItem, string name, object value, params Attribute[] attributes)
		{
			return null;
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000155")]
		[Address(RVA = "0x2A8B780", Offset = "0x2A89D80", VA = "0x182A8B780")]
		public static ref SelfValidationResult.ResultItem WithMetaData(this SelfValidationResult.ResultItem resultItem, object value, params Attribute[] attributes)
		{
			return null;
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000156")]
		[Address(RVA = "0x2A8B940", Offset = "0x2A89F40", VA = "0x182A8B940")]
		public static ref SelfValidationResult.ResultItem WithButton(this SelfValidationResult.ResultItem resultItem, string name, Action onClick)
		{
			return null;
		}
	}
}
