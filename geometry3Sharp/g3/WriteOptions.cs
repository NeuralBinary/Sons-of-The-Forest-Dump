using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200019A RID: 410
	[Token(Token = "0x200019A")]
	public struct WriteOptions
	{
		// Token: 0x0400066D RID: 1645
		[Token(Token = "0x400066D")]
		[FieldOffset(Offset = "0x0")]
		public bool bWriteBinary;

		// Token: 0x0400066E RID: 1646
		[Token(Token = "0x400066E")]
		[FieldOffset(Offset = "0x1")]
		public bool bPerVertexNormals;

		// Token: 0x0400066F RID: 1647
		[Token(Token = "0x400066F")]
		[FieldOffset(Offset = "0x2")]
		public bool bPerVertexColors;

		// Token: 0x04000670 RID: 1648
		[Token(Token = "0x4000670")]
		[FieldOffset(Offset = "0x3")]
		public bool bPerVertexUVs;

		// Token: 0x04000671 RID: 1649
		[Token(Token = "0x4000671")]
		[FieldOffset(Offset = "0x4")]
		public bool bWriteGroups;

		// Token: 0x04000672 RID: 1650
		[Token(Token = "0x4000672")]
		[FieldOffset(Offset = "0x5")]
		public bool bCombineMeshes;

		// Token: 0x04000673 RID: 1651
		[Token(Token = "0x4000673")]
		[FieldOffset(Offset = "0x8")]
		public int RealPrecisionDigits;

		// Token: 0x04000674 RID: 1652
		[Token(Token = "0x4000674")]
		[FieldOffset(Offset = "0xC")]
		public bool bWriteMaterials;

		// Token: 0x04000675 RID: 1653
		[Token(Token = "0x4000675")]
		[FieldOffset(Offset = "0x10")]
		public string MaterialFilePath;

		// Token: 0x04000676 RID: 1654
		[Token(Token = "0x4000676")]
		[FieldOffset(Offset = "0x18")]
		public string groupNamePrefix;

		// Token: 0x04000677 RID: 1655
		[Token(Token = "0x4000677")]
		[FieldOffset(Offset = "0x20")]
		public Func<int, string> GroupNameF;

		// Token: 0x04000678 RID: 1656
		[Token(Token = "0x4000678")]
		[FieldOffset(Offset = "0x28")]
		public Action<int, int> ProgressFunc;

		// Token: 0x04000679 RID: 1657
		[Token(Token = "0x4000679")]
		[FieldOffset(Offset = "0x30")]
		public Func<string> AsciiHeaderFunc;

		// Token: 0x0400067A RID: 1658
		[Token(Token = "0x400067A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly WriteOptions Defaults;
	}
}
