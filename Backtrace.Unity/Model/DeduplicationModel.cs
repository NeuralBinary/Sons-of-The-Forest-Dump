using System;
using Backtrace.Unity.Types;
using Il2CppDummyDll;

namespace Backtrace.Unity.Model
{
	// Token: 0x0200003E RID: 62
	[Token(Token = "0x200003E")]
	public class DeduplicationModel
	{
		// Token: 0x060001D3 RID: 467 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x753680", Offset = "0x751C80", VA = "0x180753680")]
		public DeduplicationModel(BacktraceData backtraceData, DeduplicationStrategy strategy)
		{
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000055")]
		public string StackTrace
		{
			[Token(Token = "0x60001D4")]
			[Address(RVA = "0x7536E0", Offset = "0x751CE0", VA = "0x1807536E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000056")]
		public string Classifier
		{
			[Token(Token = "0x60001D5")]
			[Address(RVA = "0x753B00", Offset = "0x752100", VA = "0x180753B00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000057")]
		public string ExceptionMessage
		{
			[Token(Token = "0x60001D6")]
			[Address(RVA = "0x753C60", Offset = "0x752260", VA = "0x180753C60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000058")]
		public string Factor
		{
			[Token(Token = "0x60001D7")]
			[Address(RVA = "0x753CE0", Offset = "0x7522E0", VA = "0x180753CE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x753D40", Offset = "0x752340", VA = "0x180753D40")]
		public string GetSha()
		{
			return null;
		}

		// Token: 0x0400018E RID: 398
		[Token(Token = "0x400018E")]
		[FieldOffset(Offset = "0x10")]
		private readonly BacktraceData _backtraceData;

		// Token: 0x0400018F RID: 399
		[Token(Token = "0x400018F")]
		[FieldOffset(Offset = "0x18")]
		private readonly DeduplicationStrategy _strategy;
	}
}
