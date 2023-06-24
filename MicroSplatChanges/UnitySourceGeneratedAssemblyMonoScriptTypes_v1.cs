using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

// Token: 0x02000004 RID: 4
[Token(Token = "0x2000004")]
[EditorBrowsable(EditorBrowsableState.Never)]
[CompilerGenerated]
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
	// Token: 0x06000012 RID: 18 RVA: 0x0000206C File Offset: 0x0000026C
	[Token(Token = "0x6000012")]
	[Address(RVA = "0x209D530", Offset = "0x209BB30", VA = "0x18209D530")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get()
	{
		return default(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData);
	}

	// Token: 0x06000013 RID: 19 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000013")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	public UnitySourceGeneratedAssemblyMonoScriptTypes_v1()
	{
	}

	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	private struct MonoScriptData
	{
		// Token: 0x04000070 RID: 112
		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x0")]
		public byte[] FilePathsData;

		// Token: 0x04000071 RID: 113
		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x8")]
		public byte[] TypesData;

		// Token: 0x04000072 RID: 114
		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x10")]
		public int TotalTypes;

		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x14")]
		public int TotalFiles;

		// Token: 0x04000074 RID: 116
		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x18")]
		public bool IsEditorOnly;
	}
}
