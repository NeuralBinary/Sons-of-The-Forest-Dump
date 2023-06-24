using System;
using System.Collections.Generic;
using CSharpx;
using Il2CppDummyDll;

namespace CommandLine.Core
{
	// Token: 0x02000116 RID: 278
	[Token(Token = "0x2000116")]
	internal sealed class ValueSpecification : Specification
	{
		// Token: 0x0600062E RID: 1582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600062E")]
		[Address(RVA = "0x9C51D0", Offset = "0x9C37D0", VA = "0x1809C51D0")]
		public ValueSpecification(int index, string metaName, bool required, Maybe<int> min, Maybe<int> max, Maybe<object> defaultValue, string helpText, string metaValue, IEnumerable<string> enumValues, Type conversionType, TargetType targetType, bool hidden = false)
		{
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600062F")]
		[Address(RVA = "0x9C52D0", Offset = "0x9C38D0", VA = "0x1809C52D0")]
		public static ValueSpecification FromAttribute(ValueAttribute attribute, Type conversionType, IEnumerable<string> enumValues)
		{
			return null;
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000630 RID: 1584 RVA: 0x00003FF0 File Offset: 0x000021F0
		[Token(Token = "0x170000E9")]
		public int Index
		{
			[Token(Token = "0x6000630")]
			[Address(RVA = "0x8F47A0", Offset = "0x8F2DA0", VA = "0x1808F47A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000631 RID: 1585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000EA")]
		public string MetaName
		{
			[Token(Token = "0x6000631")]
			[Address(RVA = "0x620F10", Offset = "0x61F510", VA = "0x180620F10")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000384 RID: 900
		[Token(Token = "0x4000384")]
		[FieldOffset(Offset = "0x58")]
		private readonly int index;

		// Token: 0x04000385 RID: 901
		[Token(Token = "0x4000385")]
		[FieldOffset(Offset = "0x60")]
		private readonly string metaName;
	}
}
