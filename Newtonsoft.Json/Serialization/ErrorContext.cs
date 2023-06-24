using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200010A RID: 266
	[Token(Token = "0x200010A")]
	[NullableContext(1)]
	[Nullable(0)]
	public class ErrorContext
	{
		// Token: 0x060007B3 RID: 1971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x257E800", Offset = "0x257CE00", VA = "0x18257E800")]
		internal ErrorContext([Nullable(2)] object originalObject, [Nullable(2)] object member, string path, Exception error)
		{
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060007B4 RID: 1972 RVA: 0x000046F8 File Offset: 0x000028F8
		// (set) Token: 0x060007B5 RID: 1973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000F0")]
		internal bool Traced
		{
			[Token(Token = "0x60007B4")]
			[Address(RVA = "0x5FD4E0", Offset = "0x5FBAE0", VA = "0x1805FD4E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007B5")]
			[Address(RVA = "0x5FD4F0", Offset = "0x5FBAF0", VA = "0x1805FD4F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060007B6 RID: 1974 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000F1")]
		public Exception Error
		{
			[Token(Token = "0x60007B6")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060007B7 RID: 1975 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000F2")]
		[Nullable(2)]
		public object OriginalObject
		{
			[Token(Token = "0x60007B7")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			[NullableContext(2)]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060007B8 RID: 1976 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000F3")]
		[Nullable(2)]
		public object Member
		{
			[Token(Token = "0x60007B8")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			[CompilerGenerated]
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060007B9 RID: 1977 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000F4")]
		public string Path
		{
			[Token(Token = "0x60007B9")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060007BA RID: 1978 RVA: 0x00004710 File Offset: 0x00002910
		// (set) Token: 0x060007BB RID: 1979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000F5")]
		public bool Handled
		{
			[Token(Token = "0x60007BA")]
			[Address(RVA = "0x5FD5C0", Offset = "0x5FBBC0", VA = "0x1805FD5C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007BB")]
			[Address(RVA = "0x5FD5D0", Offset = "0x5FBBD0", VA = "0x1805FD5D0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
