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
	// Token: 0x06000003 RID: 3 RVA: 0x00002054 File Offset: 0x00000254
	[Token(Token = "0x6000003")]
	[Address(RVA = "0x76B4A0", Offset = "0x769AA0", VA = "0x18076B4A0")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get()
	{
		return default(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData);
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000004")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	public UnitySourceGeneratedAssemblyMonoScriptTypes_v1()
	{
	}

	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	private struct MonoScriptData
	{
		// Token: 0x04000001 RID: 1
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x0")]
		public byte[] FilePathsData;

		// Token: 0x04000002 RID: 2
		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x8")]
		public byte[] TypesData;

		// Token: 0x04000003 RID: 3
		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x10")]
		public int TotalTypes;

		// Token: 0x04000004 RID: 4
		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x14")]
		public int TotalFiles;

		// Token: 0x04000005 RID: 5
		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x18")]
		public bool IsEditorOnly;
	}
}
