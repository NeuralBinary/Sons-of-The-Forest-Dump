using System;
using Il2CppDummyDll;

namespace MudBun
{
	// Token: 0x020000A9 RID: 169
	[Token(Token = "0x20000A9")]
	public class RegisterSdfBrushEvalFuncAttribute : Attribute
	{
		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060004AA RID: 1194 RVA: 0x00004920 File Offset: 0x00002B20
		[Token(Token = "0x170000DB")]
		public int BrushType
		{
			[Token(Token = "0x60004AA")]
			[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x5EDA40", Offset = "0x5EC040", VA = "0x1805EDA40")]
		public RegisterSdfBrushEvalFuncAttribute(SdfBrush.TypeEnum brushType)
		{
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x5EDA40", Offset = "0x5EC040", VA = "0x1805EDA40")]
		public RegisterSdfBrushEvalFuncAttribute(int brushType)
		{
		}

		// Token: 0x04000351 RID: 849
		[Token(Token = "0x4000351")]
		[FieldOffset(Offset = "0x10")]
		private int m_brushType;
	}
}
