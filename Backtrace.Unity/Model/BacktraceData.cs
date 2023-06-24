using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Backtrace.Unity.Model.JsonData;
using Il2CppDummyDll;

namespace Backtrace.Unity.Model
{
	// Token: 0x0200002F RID: 47
	[Token(Token = "0x200002F")]
	public class BacktraceData
	{
		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000161 RID: 353 RVA: 0x000027EC File Offset: 0x000009EC
		// (set) Token: 0x06000162 RID: 354 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700003C")]
		public Guid Uuid
		{
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x74B700", Offset = "0x749D00", VA = "0x18074B700")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Token(Token = "0x6000162")]
			[Address(RVA = "0x74B710", Offset = "0x749D10", VA = "0x18074B710")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000163 RID: 355 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700003D")]
		internal string UuidString
		{
			[Token(Token = "0x6000163")]
			[Address(RVA = "0x74B720", Offset = "0x749D20", VA = "0x18074B720")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000164 RID: 356 RVA: 0x00002804 File Offset: 0x00000A04
		// (set) Token: 0x06000165 RID: 357 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700003E")]
		public long Timestamp
		{
			[Token(Token = "0x6000164")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x74B7D0", Offset = "0x749DD0", VA = "0x18074B7D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000166 RID: 358 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000167 RID: 359 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700003F")]
		public BacktraceReport Report
		{
			[Token(Token = "0x6000166")]
			[Address(RVA = "0x620F10", Offset = "0x61F510", VA = "0x180620F10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000167")]
			[Address(RVA = "0x620F20", Offset = "0x61F520", VA = "0x180620F20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000168")]
		[Address(RVA = "0x74B7E0", Offset = "0x749DE0", VA = "0x18074B7E0")]
		public BacktraceData(BacktraceReport report, [Optional] Dictionary<string, string> clientAttributes, int gameObjectDepth = -1)
		{
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000169")]
		[Address(RVA = "0x74BA60", Offset = "0x74A060", VA = "0x18074BA60")]
		public string ToJson()
		{
			return null;
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600016A")]
		[Address(RVA = "0x74C040", Offset = "0x74A640", VA = "0x18074C040")]
		private void SetThreadInformations()
		{
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600016B")]
		[Address(RVA = "0x74C2B0", Offset = "0x74A8B0", VA = "0x18074C2B0")]
		private void SetAttributes(Dictionary<string, string> clientAttributes, int gameObjectDepth)
		{
		}

		// Token: 0x04000132 RID: 306
		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string _uuidString;

		// Token: 0x04000134 RID: 308
		[Token(Token = "0x4000134")]
		public const string Lang = "csharp";

		// Token: 0x04000135 RID: 309
		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly string LangVersion;

		// Token: 0x04000136 RID: 310
		[Token(Token = "0x4000136")]
		public const string Agent = "backtrace-unity";

		// Token: 0x04000137 RID: 311
		[Token(Token = "0x4000137")]
		public const string AgentVersion = "3.7.8";

		// Token: 0x04000138 RID: 312
		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Dictionary<string, ThreadInformation> ThreadInformations;

		// Token: 0x04000139 RID: 313
		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string MainThread;

		// Token: 0x0400013A RID: 314
		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string[] Classifier;

		// Token: 0x0400013B RID: 315
		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public BacktraceSourceCode SourceCode;

		// Token: 0x0400013C RID: 316
		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public ICollection<string> Attachments;

		// Token: 0x0400013E RID: 318
		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public BacktraceAttributes Attributes;

		// Token: 0x0400013F RID: 319
		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Annotations Annotation;

		// Token: 0x04000140 RID: 320
		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public ThreadData ThreadData;

		// Token: 0x04000141 RID: 321
		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public int Deduplication;
	}
}
