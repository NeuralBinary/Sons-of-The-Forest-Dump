using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Backtrace.Unity.Model.Breadcrumbs.InMemory
{
	// Token: 0x02000061 RID: 97
	[Token(Token = "0x2000061")]
	internal sealed class BacktraceInMemoryLogManager : IBacktraceLogManager
	{
		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060002E2 RID: 738 RVA: 0x00002F0C File Offset: 0x0000110C
		// (set) Token: 0x060002E3 RID: 739 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700008D")]
		public int MaximumNumberOfBreadcrumbs
		{
			[Token(Token = "0x60002E2")]
			[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60002E3")]
			[Address(RVA = "0x5EDA40", Offset = "0x5EC040", VA = "0x1805EDA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x761370", Offset = "0x75F970", VA = "0x180761370")]
		public BacktraceInMemoryLogManager()
		{
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700008E")]
		public string BreadcrumbsFilePath
		{
			[Token(Token = "0x60002E5")]
			[Address(RVA = "0x7614E0", Offset = "0x75FAE0", VA = "0x1807614E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00002F24 File Offset: 0x00001124
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x761520", Offset = "0x75FB20", VA = "0x180761520", Slot = "5")]
		public bool Add(string message, BreadcrumbLevel type, UnityEngineLogLevel level, IDictionary<string, string> attributes)
		{
			return default(bool);
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00002F3C File Offset: 0x0000113C
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x7619C0", Offset = "0x75FFC0", VA = "0x1807619C0", Slot = "6")]
		public bool Clear()
		{
			return default(bool);
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00002F54 File Offset: 0x00001154
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "7")]
		public bool Enable()
		{
			return default(bool);
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00002F6C File Offset: 0x0000116C
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x761A10", Offset = "0x760010", VA = "0x180761A10", Slot = "8")]
		public int Length()
		{
			return 0;
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00002F84 File Offset: 0x00001184
		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x5FD5A0", Offset = "0x5FBBA0", VA = "0x1805FD5A0", Slot = "9")]
		public double BreadcrumbId()
		{
			return 0.0;
		}

		// Token: 0x0400020D RID: 525
		[Token(Token = "0x400020D")]
		public const int DefaultMaximumNumberOfInMemoryBreadcrumbs = 100;

		// Token: 0x0400020F RID: 527
		[Token(Token = "0x400020F")]
		[FieldOffset(Offset = "0x18")]
		private object _lockObject;

		// Token: 0x04000210 RID: 528
		[Token(Token = "0x4000210")]
		[FieldOffset(Offset = "0x20")]
		internal readonly Queue<InMemoryBreadcrumb> Breadcrumbs;

		// Token: 0x04000211 RID: 529
		[Token(Token = "0x4000211")]
		[FieldOffset(Offset = "0x28")]
		private double _breadcrumbId;
	}
}
