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
	// Token: 0x06000003 RID: 3 RVA: 0x00002054 File Offset: 0x00000254
	[Token(Token = "0x6000003")]
	[Address(RVA = "0x209A060", Offset = "0x2098660", VA = "0x18209A060")]
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

	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	private struct MonoScriptData
	{
		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x0")]
		public byte[] FilePathsData;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x8")]
		public byte[] TypesData;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x10")]
		public int TotalTypes;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x14")]
		public int TotalFiles;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x18")]
		public bool IsEditorOnly;
	}
}
