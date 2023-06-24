using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

// Token: 0x02000006 RID: 6
[Token(Token = "0x2000006")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
	// Token: 0x06000007 RID: 7 RVA: 0x00002058 File Offset: 0x00000258
	[Token(Token = "0x6000007")]
	[Address(RVA = "0x28D8660", Offset = "0x28D6C60", VA = "0x1828D8660")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get()
	{
		return default(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData);
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000008")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	public UnitySourceGeneratedAssemblyMonoScriptTypes_v1()
	{
	}

	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	private struct MonoScriptData
	{
		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x0")]
		public byte[] FilePathsData;

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x8")]
		public byte[] TypesData;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x10")]
		public int TotalTypes;

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x14")]
		public int TotalFiles;

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x18")]
		public bool IsEditorOnly;
	}
}
