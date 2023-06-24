using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200009F RID: 159
	[Token(Token = "0x200009F")]
	[NullableContext(1)]
	[Nullable(0)]
	internal class TypeInformation
	{
		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000533 RID: 1331 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000B4")]
		public Type Type
		{
			[Token(Token = "0x6000533")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000534 RID: 1332 RVA: 0x00003498 File Offset: 0x00001698
		[Token(Token = "0x170000B5")]
		public PrimitiveTypeCode TypeCode
		{
			[Token(Token = "0x6000534")]
			[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520")]
			[CompilerGenerated]
			get
			{
				return PrimitiveTypeCode.Empty;
			}
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000535")]
		[Address(RVA = "0x753680", Offset = "0x751C80", VA = "0x180753680")]
		public TypeInformation(Type type, PrimitiveTypeCode typeCode)
		{
		}
	}
}
