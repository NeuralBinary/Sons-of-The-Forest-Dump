using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

// Token: 0x02000002 RID: 2
[Token(Token = "0x2000002")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x26EDBB0", Offset = "0x26EC1B0", VA = "0x1826EDBB0")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get()
	{
		return default(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData);
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6000002")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	public UnitySourceGeneratedAssemblyMonoScriptTypes_v1()
	{
	}

	// Token: 0x02000003 RID: 3
	[Token(Token = "0x2000003")]
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
