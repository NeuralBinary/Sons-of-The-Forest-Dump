using System;
using System.Reflection;
using CSharpx;
using Il2CppDummyDll;

namespace CommandLine.Core
{
	// Token: 0x020000ED RID: 237
	[Token(Token = "0x20000ED")]
	internal class SpecificationProperty
	{
		// Token: 0x06000527 RID: 1319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000527")]
		[Address(RVA = "0x9B12F0", Offset = "0x9AF8F0", VA = "0x1809B12F0")]
		private SpecificationProperty(Specification specification, PropertyInfo property, Maybe<object> value)
		{
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000528")]
		[Address(RVA = "0x9B1410", Offset = "0x9AFA10", VA = "0x1809B1410")]
		public static SpecificationProperty Create(Specification specification, PropertyInfo property, Maybe<object> value)
		{
			return null;
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000529 RID: 1321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D8")]
		public Specification Specification
		{
			[Token(Token = "0x6000529")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x0600052A RID: 1322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D9")]
		public PropertyInfo Property
		{
			[Token(Token = "0x600052A")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600052B RID: 1323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000DA")]
		public Maybe<object> Value
		{
			[Token(Token = "0x600052B")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x040002B9 RID: 697
		[Token(Token = "0x40002B9")]
		[FieldOffset(Offset = "0x10")]
		private readonly Specification specification;

		// Token: 0x040002BA RID: 698
		[Token(Token = "0x40002BA")]
		[FieldOffset(Offset = "0x18")]
		private readonly PropertyInfo property;

		// Token: 0x040002BB RID: 699
		[Token(Token = "0x40002BB")]
		[FieldOffset(Offset = "0x20")]
		private readonly Maybe<object> value;
	}
}
