using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000089 RID: 137
	[Token(Token = "0x2000089")]
	public class SelfValidationResult
	{
		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600015D RID: 349 RVA: 0x00002388 File Offset: 0x00000588
		[Token(Token = "0x17000041")]
		public int Count
		{
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000042 RID: 66
		[Token(Token = "0x17000042")]
		public SelfValidationResult.ResultItem this[int index]
		{
			[Token(Token = "0x600015E")]
			[Address(RVA = "0x1AFA440", Offset = "0x1AF8A40", VA = "0x181AFA440")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600015F")]
		[Address(RVA = "0x2A8BEE0", Offset = "0x2A8A4E0", VA = "0x182A8BEE0")]
		public ref SelfValidationResult.ResultItem AddError(string error)
		{
			return null;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000160")]
		[Address(RVA = "0x2A8BFD0", Offset = "0x2A8A5D0", VA = "0x182A8BFD0")]
		public ref SelfValidationResult.ResultItem AddWarning(string warning)
		{
			return null;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000161")]
		[Address(RVA = "0x2A8C0C0", Offset = "0x2A8A6C0", VA = "0x182A8C0C0")]
		public ref SelfValidationResult.ResultItem Add(ValidatorSeverity severity, string message)
		{
			return null;
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000162")]
		[Address(RVA = "0x2A8C2B0", Offset = "0x2A8A8B0", VA = "0x182A8C2B0")]
		public ref SelfValidationResult.ResultItem Add(SelfValidationResult.ResultItem item)
		{
			return null;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000163")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public SelfValidationResult()
		{
		}

		// Token: 0x0400014F RID: 335
		[Token(Token = "0x400014F")]
		[FieldOffset(Offset = "0x0")]
		private static SelfValidationResult.ResultItem NoResultItem;

		// Token: 0x04000150 RID: 336
		[Token(Token = "0x4000150")]
		[FieldOffset(Offset = "0x10")]
		private SelfValidationResult.ResultItem[] items;

		// Token: 0x04000151 RID: 337
		[Token(Token = "0x4000151")]
		[FieldOffset(Offset = "0x18")]
		private int itemsCount;

		// Token: 0x0200008A RID: 138
		[Token(Token = "0x200008A")]
		public struct ContextMenuItem
		{
			// Token: 0x04000152 RID: 338
			[Token(Token = "0x4000152")]
			[FieldOffset(Offset = "0x0")]
			public string Path;

			// Token: 0x04000153 RID: 339
			[Token(Token = "0x4000153")]
			[FieldOffset(Offset = "0x8")]
			public bool On;

			// Token: 0x04000154 RID: 340
			[Token(Token = "0x4000154")]
			[FieldOffset(Offset = "0x9")]
			public bool AddSeparatorBefore;

			// Token: 0x04000155 RID: 341
			[Token(Token = "0x4000155")]
			[FieldOffset(Offset = "0x10")]
			public Action OnClick;
		}

		// Token: 0x0200008B RID: 139
		[Token(Token = "0x200008B")]
		public enum ResultType
		{
			// Token: 0x04000157 RID: 343
			[Token(Token = "0x4000157")]
			Error,
			// Token: 0x04000158 RID: 344
			[Token(Token = "0x4000158")]
			Warning,
			// Token: 0x04000159 RID: 345
			[Token(Token = "0x4000159")]
			Valid
		}

		// Token: 0x0200008C RID: 140
		[Token(Token = "0x200008C")]
		public struct ResultItem
		{
			// Token: 0x0400015A RID: 346
			[Token(Token = "0x400015A")]
			[FieldOffset(Offset = "0x0")]
			public string Message;

			// Token: 0x0400015B RID: 347
			[Token(Token = "0x400015B")]
			[FieldOffset(Offset = "0x8")]
			public SelfValidationResult.ResultType ResultType;

			// Token: 0x0400015C RID: 348
			[Token(Token = "0x400015C")]
			[FieldOffset(Offset = "0x10")]
			public SelfFix? Fix;

			// Token: 0x0400015D RID: 349
			[Token(Token = "0x400015D")]
			[FieldOffset(Offset = "0x30")]
			public SelfValidationResult.ResultItemMetaData[] MetaData;

			// Token: 0x0400015E RID: 350
			[Token(Token = "0x400015E")]
			[FieldOffset(Offset = "0x38")]
			public Func<IEnumerable<SelfValidationResult.ContextMenuItem>> OnContextClick;

			// Token: 0x0400015F RID: 351
			[Token(Token = "0x400015F")]
			[FieldOffset(Offset = "0x40")]
			public Action OnSceneGUI;
		}

		// Token: 0x0200008D RID: 141
		[Token(Token = "0x200008D")]
		public struct ResultItemMetaData
		{
			// Token: 0x06000164 RID: 356 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000164")]
			[Address(RVA = "0x649120", Offset = "0x647720", VA = "0x180649120")]
			public ResultItemMetaData(string name, object value, params Attribute[] attributes)
			{
			}

			// Token: 0x04000160 RID: 352
			[Token(Token = "0x4000160")]
			[FieldOffset(Offset = "0x0")]
			public string Name;

			// Token: 0x04000161 RID: 353
			[Token(Token = "0x4000161")]
			[FieldOffset(Offset = "0x8")]
			public object Value;

			// Token: 0x04000162 RID: 354
			[Token(Token = "0x4000162")]
			[FieldOffset(Offset = "0x10")]
			public Attribute[] Attributes;
		}
	}
}
