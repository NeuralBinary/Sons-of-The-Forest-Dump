using System;
using System.Text.RegularExpressions;
using Il2CppDummyDll;
using Pathfinding.Ionic.Zip;

namespace Pathfinding.Ionic
{
	// Token: 0x0200001C RID: 28
	[Token(Token = "0x200001C")]
	internal class NameCriterion : SelectionCriterion
	{
		// Token: 0x0600006A RID: 106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public NameCriterion()
		{
		}

		// Token: 0x1700000E RID: 14
		// (set) Token: 0x0600006B RID: 107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000E")]
		internal virtual string MatchingFileSpec
		{
			[Token(Token = "0x600006B")]
			[Address(RVA = "0x2852580", Offset = "0x2850B80", VA = "0x182852580", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x2852960", Offset = "0x2850F60", VA = "0x182852960", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002208 File Offset: 0x00000408
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x2852AA0", Offset = "0x28510A0", VA = "0x182852AA0", Slot = "6")]
		internal override bool Evaluate(string filename)
		{
			return default(bool);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002220 File Offset: 0x00000420
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x2852AB0", Offset = "0x28510B0", VA = "0x182852AB0")]
		private bool _Evaluate(string fullpath)
		{
			return default(bool);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002238 File Offset: 0x00000438
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x2852BE0", Offset = "0x28511E0", VA = "0x182852BE0", Slot = "7")]
		internal override bool Evaluate(ZipEntry entry)
		{
			return default(bool);
		}

		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x18")]
		private Regex _re;

		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x20")]
		private string _regexString;

		// Token: 0x04000046 RID: 70
		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x28")]
		internal ComparisonOperator Operator;

		// Token: 0x04000047 RID: 71
		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x30")]
		private string _MatchingFileSpec;
	}
}
