using System;
using System.Runtime.InteropServices;
using CSharpx;
using Il2CppDummyDll;

namespace CommandLine.Core
{
	// Token: 0x0200010C RID: 268
	[Token(Token = "0x200010C")]
	internal struct TypeDescriptor
	{
		// Token: 0x06000609 RID: 1545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000609")]
		[Address(RVA = "0x9C2A00", Offset = "0x9C1000", VA = "0x1809C2A00")]
		private TypeDescriptor(TargetType targetType, Maybe<int> maxItems, [Optional] Maybe<TypeDescriptor> nextValue)
		{
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600060A RID: 1546 RVA: 0x00003F00 File Offset: 0x00002100
		[Token(Token = "0x170000E4")]
		public TargetType TargetType
		{
			[Token(Token = "0x600060A")]
			[Address(RVA = "0x60E050", Offset = "0x60C650", VA = "0x18060E050")]
			get
			{
				return TargetType.Switch;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600060B RID: 1547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000E5")]
		public Maybe<int> MaxItems
		{
			[Token(Token = "0x600060B")]
			[Address(RVA = "0x9C2AC0", Offset = "0x9C10C0", VA = "0x1809C2AC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600060C RID: 1548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000E6")]
		public Maybe<TypeDescriptor> NextValue
		{
			[Token(Token = "0x600060C")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x00003F18 File Offset: 0x00002118
		[Token(Token = "0x600060D")]
		[Address(RVA = "0x9C2AD0", Offset = "0x9C10D0", VA = "0x1809C2AD0")]
		public static TypeDescriptor Create(TargetType tag, Maybe<int> maximumItems, [Optional] TypeDescriptor next)
		{
			return default(TypeDescriptor);
		}

		// Token: 0x04000369 RID: 873
		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly TargetType targetType;

		// Token: 0x0400036A RID: 874
		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly Maybe<int> maxItems;

		// Token: 0x0400036B RID: 875
		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Maybe<TypeDescriptor> nextValue;
	}
}
