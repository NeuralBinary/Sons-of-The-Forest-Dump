using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

// Token: 0x02000009 RID: 9
[Token(Token = "0x2000009")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
	// Token: 0x06000015 RID: 21 RVA: 0x000020E8 File Offset: 0x000002E8
	[Token(Token = "0x6000015")]
	[Address(RVA = "0x2FCA930", Offset = "0x2FC8F30", VA = "0x182FCA930")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get()
	{
		return default(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData);
	}

	// Token: 0x06000016 RID: 22 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000016")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	public UnitySourceGeneratedAssemblyMonoScriptTypes_v1()
	{
	}

	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	private struct MonoScriptData
	{
		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x0")]
		public byte[] FilePathsData;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x8")]
		public byte[] TypesData;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x10")]
		public int TotalTypes;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x14")]
		public int TotalFiles;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x18")]
		public bool IsEditorOnly;
	}
}
