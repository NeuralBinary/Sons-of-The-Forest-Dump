using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000002 RID: 2
	[Token(Token = "0x2000002")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public sealed class AssetListAttribute : Attribute
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x2A87790", Offset = "0x2A85D90", VA = "0x182A87790")]
		public AssetListAttribute()
		{
		}

		// Token: 0x04000001 RID: 1
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x10")]
		public bool AutoPopulate;

		// Token: 0x04000002 RID: 2
		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x18")]
		public string Tags;

		// Token: 0x04000003 RID: 3
		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x20")]
		public string LayerNames;

		// Token: 0x04000004 RID: 4
		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x28")]
		public string AssetNamePrefix;

		// Token: 0x04000005 RID: 5
		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x30")]
		public string Path;

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x38")]
		public string CustomFilterMethod;
	}
}
