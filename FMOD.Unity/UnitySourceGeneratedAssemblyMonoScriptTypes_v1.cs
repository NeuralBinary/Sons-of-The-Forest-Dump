using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

// Token: 0x02000004 RID: 4
[Token(Token = "0x2000004")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
	// Token: 0x0600002D RID: 45 RVA: 0x00002204 File Offset: 0x00000404
	[Token(Token = "0x600002D")]
	[Address(RVA = "0xB0C5C0", Offset = "0xB0ABC0", VA = "0x180B0C5C0")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get()
	{
		return default(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData);
	}

	// Token: 0x0600002E RID: 46 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x600002E")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	public UnitySourceGeneratedAssemblyMonoScriptTypes_v1()
	{
	}

	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	private struct MonoScriptData
	{
		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x0")]
		public byte[] FilePathsData;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x8")]
		public byte[] TypesData;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x10")]
		public int TotalTypes;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x14")]
		public int TotalFiles;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x18")]
		public bool IsEditorOnly;
	}
}
