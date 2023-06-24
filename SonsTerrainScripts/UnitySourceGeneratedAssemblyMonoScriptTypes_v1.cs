using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

// Token: 0x02000003 RID: 3
[Token(Token = "0x2000003")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
	// Token: 0x06000002 RID: 2 RVA: 0x00002054 File Offset: 0x00000254
	[Token(Token = "0x6000002")]
	[Address(RVA = "0x31A5A00", Offset = "0x31A4000", VA = "0x1831A5A00")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get()
	{
		return default(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData);
	}

	// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000003")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	public UnitySourceGeneratedAssemblyMonoScriptTypes_v1()
	{
	}

	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	private struct MonoScriptData
	{
		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x0")]
		public byte[] FilePathsData;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x8")]
		public byte[] TypesData;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x10")]
		public int TotalTypes;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x14")]
		public int TotalFiles;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x18")]
		public bool IsEditorOnly;
	}
}
