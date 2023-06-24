using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.Ionic.Zip;

namespace Pathfinding.Ionic
{
	// Token: 0x0200001F RID: 31
	[Token(Token = "0x200001F")]
	public class FileSelector
	{
		// Token: 0x0600007C RID: 124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x2853370", Offset = "0x2851970", VA = "0x182853370")]
		public FileSelector(string selectionCriteria)
		{
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x2853400", Offset = "0x2851A00", VA = "0x182853400")]
		public FileSelector(string selectionCriteria, bool traverseDirectoryReparsePoints)
		{
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600007E RID: 126 RVA: 0x000020B2 File Offset: 0x000002B2
		// (set) Token: 0x0600007F RID: 127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000011")]
		public string SelectionCriteria
		{
			[Token(Token = "0x600007E")]
			[Address(RVA = "0x28534A0", Offset = "0x2851AA0", VA = "0x1828534A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600007F")]
			[Address(RVA = "0x28534C0", Offset = "0x2851AC0", VA = "0x1828534C0")]
			set
			{
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000080 RID: 128 RVA: 0x000022B0 File Offset: 0x000004B0
		// (set) Token: 0x06000081 RID: 129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000012")]
		public bool TraverseReparsePoints
		{
			[Token(Token = "0x6000080")]
			[Address(RVA = "0x75A6A0", Offset = "0x758CA0", VA = "0x18075A6A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000081")]
			[Address(RVA = "0x75A6B0", Offset = "0x758CB0", VA = "0x18075A6B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x2853690", Offset = "0x2851C90", VA = "0x182853690")]
		private static string NormalizeCriteriaExpression(string source)
		{
			return null;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x2853E30", Offset = "0x2852430", VA = "0x182853E30")]
		private static SelectionCriterion _ParseCriterion(string s)
		{
			return null;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x2855A60", Offset = "0x2854060", VA = "0x182855A60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000022C8 File Offset: 0x000004C8
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x257CB90", Offset = "0x257B190", VA = "0x18257CB90")]
		private bool Evaluate(string filename)
		{
			return default(bool);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x2855AE0", Offset = "0x28540E0", VA = "0x182855AE0")]
		[Conditional("SelectorTrace")]
		private void SelectorTrace(string format, params object[] args)
		{
		}

		// Token: 0x06000087 RID: 135 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x2855C20", Offset = "0x2854220", VA = "0x182855C20")]
		public ICollection<string> SelectFiles(string directory)
		{
			return null;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x2855C30", Offset = "0x2854230", VA = "0x182855C30")]
		public ReadOnlyCollection<string> SelectFiles(string directory, bool recurseDirectories)
		{
			return null;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000022E0 File Offset: 0x000004E0
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x2855F50", Offset = "0x2854550", VA = "0x182855F50")]
		private bool Evaluate(ZipEntry entry)
		{
			return default(bool);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x2855F80", Offset = "0x2854580", VA = "0x182855F80")]
		public ICollection<ZipEntry> SelectEntries(ZipFile zip)
		{
			return null;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x2856200", Offset = "0x2854800", VA = "0x182856200")]
		public ICollection<ZipEntry> SelectEntries(ZipFile zip, string directoryPathInArchive)
		{
			return null;
		}

		// Token: 0x0400004D RID: 77
		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x10")]
		internal SelectionCriterion _Criterion;

		// Token: 0x02000020 RID: 32
		[Token(Token = "0x2000020")]
		private enum ParseState
		{
			// Token: 0x04000051 RID: 81
			[Token(Token = "0x4000051")]
			Start,
			// Token: 0x04000052 RID: 82
			[Token(Token = "0x4000052")]
			OpenParen,
			// Token: 0x04000053 RID: 83
			[Token(Token = "0x4000053")]
			CriterionDone,
			// Token: 0x04000054 RID: 84
			[Token(Token = "0x4000054")]
			ConjunctionPending,
			// Token: 0x04000055 RID: 85
			[Token(Token = "0x4000055")]
			Whitespace
		}

		// Token: 0x02000021 RID: 33
		[Token(Token = "0x2000021")]
		private static class RegexAssertions
		{
			// Token: 0x04000056 RID: 86
			[Token(Token = "0x4000056")]
			[FieldOffset(Offset = "0x0")]
			public static readonly string PrecededByOddNumberOfSingleQuotes;

			// Token: 0x04000057 RID: 87
			[Token(Token = "0x4000057")]
			[FieldOffset(Offset = "0x8")]
			public static readonly string FollowedByOddNumberOfSingleQuotesAndLineEnd;

			// Token: 0x04000058 RID: 88
			[Token(Token = "0x4000058")]
			[FieldOffset(Offset = "0x10")]
			public static readonly string PrecededByEvenNumberOfSingleQuotes;

			// Token: 0x04000059 RID: 89
			[Token(Token = "0x4000059")]
			[FieldOffset(Offset = "0x18")]
			public static readonly string FollowedByEvenNumberOfSingleQuotesAndLineEnd;
		}
	}
}
