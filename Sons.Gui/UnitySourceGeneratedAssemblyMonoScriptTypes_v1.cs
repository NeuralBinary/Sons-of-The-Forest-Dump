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
	// Token: 0x0600000C RID: 12 RVA: 0x00002058 File Offset: 0x00000258
	[Token(Token = "0x600000C")]
	[Address(RVA = "0x2FFF870", Offset = "0x2FFDE70", VA = "0x182FFF870")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get()
	{
		return default(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData);
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000D")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	public UnitySourceGeneratedAssemblyMonoScriptTypes_v1()
	{
	}

	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	private struct MonoScriptData
	{
		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x0")]
		public byte[] FilePathsData;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x8")]
		public byte[] TypesData;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x10")]
		public int TotalTypes;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x14")]
		public int TotalFiles;

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x18")]
		public bool IsEditorOnly;
	}
}
