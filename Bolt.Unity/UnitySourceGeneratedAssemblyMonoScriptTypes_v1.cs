using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

// Token: 0x0200001B RID: 27
[Token(Token = "0x200001B")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
	// Token: 0x060000B4 RID: 180 RVA: 0x00002598 File Offset: 0x00000798
	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x7AD1E0", Offset = "0x7AB7E0", VA = "0x1807AD1E0")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get()
	{
		return default(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData);
	}

	// Token: 0x060000B5 RID: 181 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	public UnitySourceGeneratedAssemblyMonoScriptTypes_v1()
	{
	}

	// Token: 0x0200001C RID: 28
	[Token(Token = "0x200001C")]
	private struct MonoScriptData
	{
		// Token: 0x0400004D RID: 77
		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x0")]
		public byte[] FilePathsData;

		// Token: 0x0400004E RID: 78
		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x8")]
		public byte[] TypesData;

		// Token: 0x0400004F RID: 79
		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x10")]
		public int TotalTypes;

		// Token: 0x04000050 RID: 80
		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x14")]
		public int TotalFiles;

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x18")]
		public bool IsEditorOnly;
	}
}
