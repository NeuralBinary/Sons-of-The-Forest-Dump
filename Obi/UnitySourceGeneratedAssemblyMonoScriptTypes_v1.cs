using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

// Token: 0x02000014 RID: 20
[Token(Token = "0x2000014")]
[EditorBrowsable(EditorBrowsableState.Never)]
[CompilerGenerated]
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
	// Token: 0x0600008C RID: 140 RVA: 0x00002170 File Offset: 0x00000370
	[Token(Token = "0x600008C")]
	[Address(RVA = "0x2739340", Offset = "0x2737940", VA = "0x182739340")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get()
	{
		return default(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData);
	}

	// Token: 0x0600008D RID: 141 RVA: 0x000020F6 File Offset: 0x000002F6
	[Token(Token = "0x600008D")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	public UnitySourceGeneratedAssemblyMonoScriptTypes_v1()
	{
	}

	// Token: 0x02000015 RID: 21
	[Token(Token = "0x2000015")]
	private struct MonoScriptData
	{
		// Token: 0x04000065 RID: 101
		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x0")]
		public byte[] FilePathsData;

		// Token: 0x04000066 RID: 102
		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x8")]
		public byte[] TypesData;

		// Token: 0x04000067 RID: 103
		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x10")]
		public int TotalTypes;

		// Token: 0x04000068 RID: 104
		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x14")]
		public int TotalFiles;

		// Token: 0x04000069 RID: 105
		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x18")]
		public bool IsEditorOnly;
	}
}
