using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

// Token: 0x020002FF RID: 767
[Token(Token = "0x20002FF")]
[EditorBrowsable(1)]
[CompilerGenerated]
internal class UnitySourceGeneratedAssemblyMonoScriptTypes
{
	// Token: 0x06001371 RID: 4977 RVA: 0x00006870 File Offset: 0x00004A70
	[Token(Token = "0x6001371")]
	[Address(RVA = "0x53ABD0", Offset = "0x539BD0", VA = "0x18053ABD0")]
	private static bool IsEditorOnly()
	{
		return default(bool);
	}

	// Token: 0x06001372 RID: 4978 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001372")]
	[Address(RVA = "0x2B989B0", Offset = "0x2B979B0", VA = "0x182B989B0")]
	private static UnitySourceGeneratedAssemblyMonoScriptTypes.FileMonoScripts[] Get()
	{
		return null;
	}

	// Token: 0x06001373 RID: 4979 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001373")]
	[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
	public UnitySourceGeneratedAssemblyMonoScriptTypes()
	{
	}

	// Token: 0x02000300 RID: 768
	[Token(Token = "0x2000300")]
	private struct MonoScriptInfo
	{
		// Token: 0x04001356 RID: 4950
		[Token(Token = "0x4001356")]
		[FieldOffset(Offset = "0x0")]
		public string nameSpace;

		// Token: 0x04001357 RID: 4951
		[Token(Token = "0x4001357")]
		[FieldOffset(Offset = "0x8")]
		public string className;

		// Token: 0x04001358 RID: 4952
		[Token(Token = "0x4001358")]
		[FieldOffset(Offset = "0x10")]
		public bool isPartial;
	}

	// Token: 0x02000301 RID: 769
	[Token(Token = "0x2000301")]
	private struct FileMonoScripts
	{
		// Token: 0x04001359 RID: 4953
		[Token(Token = "0x4001359")]
		[FieldOffset(Offset = "0x0")]
		public string filePath;

		// Token: 0x0400135A RID: 4954
		[Token(Token = "0x400135A")]
		[FieldOffset(Offset = "0x8")]
		public UnitySourceGeneratedAssemblyMonoScriptTypes.MonoScriptInfo[] monoScriptInfos;
	}
}
