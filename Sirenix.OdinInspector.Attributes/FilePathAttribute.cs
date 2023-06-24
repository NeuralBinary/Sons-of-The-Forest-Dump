using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000026 RID: 38
	[Token(Token = "0x2000026")]
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	public sealed class FilePathAttribute : Attribute
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00002088 File Offset: 0x00000288
		// (set) Token: 0x06000045 RID: 69 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000008")]
		[Obsolete("Add a ReadOnly attribute to the property instead.", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool ReadOnly
		{
			[Token(Token = "0x6000044")]
			[Address(RVA = "0x2A88620", Offset = "0x2A86C20", VA = "0x182A88620")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000045")]
			[Address(RVA = "0x2A88630", Offset = "0x2A86C30", VA = "0x182A88630")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public FilePathAttribute()
		{
		}

		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x10")]
		public bool AbsolutePath;

		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x18")]
		public string Extensions;

		// Token: 0x0400003F RID: 63
		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x20")]
		public string ParentFolder;

		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x28")]
		[Obsolete("Use RequireExistingPath instead.", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool RequireValidPath;

		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x29")]
		public bool RequireExistingPath;

		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x2A")]
		public bool UseBackslashes;
	}
}
