using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Backtrace.Unity.Json;
using Backtrace.Unity.Types;
using Il2CppDummyDll;

namespace Backtrace.Unity.Model
{
	// Token: 0x0200003A RID: 58
	[Token(Token = "0x200003A")]
	public class BacktraceStackFrame
	{
		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060001AE RID: 430 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700004E")]
		public string FileName
		{
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0x74FA10", Offset = "0x74E010", VA = "0x18074FA10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060001AF RID: 431 RVA: 0x000028DC File Offset: 0x00000ADC
		// (set) Token: 0x060001B0 RID: 432 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700004F")]
		public bool InvalidFrame
		{
			[Token(Token = "0x60001AF")]
			[Address(RVA = "0x5F2120", Offset = "0x5F0720", VA = "0x1805F2120")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0x5F2110", Offset = "0x5F0710", VA = "0x1805F2110")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x74FC30", Offset = "0x74E230", VA = "0x18074FC30")]
		public BacktraceJObject ToJson()
		{
			return null;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public BacktraceStackFrame()
		{
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x74FF20", Offset = "0x74E520", VA = "0x18074FF20")]
		public BacktraceStackFrame(StackFrame frame, bool generatedByException)
		{
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x750360", Offset = "0x74E960", VA = "0x180750360")]
		private string GetMethodName(MethodBase method)
		{
			return null;
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x7504E0", Offset = "0x74EAE0", VA = "0x1807504E0")]
		private string GetFileNameFromLibraryName()
		{
			return null;
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x750630", Offset = "0x74EC30", VA = "0x180750630")]
		private string GetFileNameFromFunctionName()
		{
			return null;
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x7509A0", Offset = "0x74EFA0", VA = "0x1807509A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000174 RID: 372
		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0x0")]
		private static string[] _frameSeparators;

		// Token: 0x04000175 RID: 373
		[Token(Token = "0x4000175")]
		[FieldOffset(Offset = "0x10")]
		public string FunctionName;

		// Token: 0x04000176 RID: 374
		[Token(Token = "0x4000176")]
		[FieldOffset(Offset = "0x18")]
		internal BacktraceStackFrameType StackFrameType;

		// Token: 0x04000177 RID: 375
		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0x1C")]
		public int Line;

		// Token: 0x04000178 RID: 376
		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0x20")]
		public string MemberInfo;

		// Token: 0x04000179 RID: 377
		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0x28")]
		public string SourceCodeFullPath;

		// Token: 0x0400017A RID: 378
		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0x30")]
		public int Column;

		// Token: 0x0400017B RID: 379
		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0x34")]
		public int ILOffset;

		// Token: 0x0400017C RID: 380
		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0x38")]
		public string SourceCode;

		// Token: 0x0400017D RID: 381
		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0x40")]
		public string Address;

		// Token: 0x0400017E RID: 382
		[Token(Token = "0x400017E")]
		[FieldOffset(Offset = "0x48")]
		public string Assembly;

		// Token: 0x04000180 RID: 384
		[Token(Token = "0x4000180")]
		[FieldOffset(Offset = "0x58")]
		public string Library;
	}
}
