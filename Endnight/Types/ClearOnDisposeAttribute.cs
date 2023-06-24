using System;
using Il2CppDummyDll;

namespace Endnight.Types
{
	// Token: 0x0200006C RID: 108
	[Token(Token = "0x200006C")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class ClearOnDisposeAttribute : Attribute
	{
		// Token: 0x0600026A RID: 618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600026A")]
		[Address(RVA = "0xA905A0", Offset = "0xA8EBA0", VA = "0x180A905A0")]
		public ClearOnDisposeAttribute()
		{
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600026B")]
		[Address(RVA = "0xA90600", Offset = "0xA8EC00", VA = "0x180A90600")]
		public ClearOnDisposeAttribute(object defaultValue)
		{
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600026C RID: 620 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700001E")]
		public object DefaultValue
		{
			[Token(Token = "0x600026C")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600026D RID: 621 RVA: 0x00003378 File Offset: 0x00001578
		[Token(Token = "0x1700001F")]
		public bool IsDefaultValueDefined
		{
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x75A6A0", Offset = "0x758CA0", VA = "0x18075A6A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x04000173 RID: 371
		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0x10")]
		private readonly object _defaultValue;

		// Token: 0x04000174 RID: 372
		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0x18")]
		private readonly bool _defaultValueDefined;
	}
}
