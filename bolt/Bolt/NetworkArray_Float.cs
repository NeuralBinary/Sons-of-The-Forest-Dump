using System;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x02000090 RID: 144
	[Token(Token = "0x2000090")]
	[Documentation]
	public class NetworkArray_Float : NetworkArray_Values<float>
	{
		// Token: 0x060004F2 RID: 1266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x8EACA0", Offset = "0x8E92A0", VA = "0x1808EACA0")]
		internal NetworkArray_Float(int length, int stride)
		{
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x00003888 File Offset: 0x00001A88
		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x8EAD80", Offset = "0x8E9380", VA = "0x1808EAD80", Slot = "7")]
		protected override float GetValue(int index)
		{
			return 0f;
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x000038A0 File Offset: 0x00001AA0
		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x8EADD0", Offset = "0x8E93D0", VA = "0x1808EADD0", Slot = "8")]
		protected override bool SetValue(int index, float value)
		{
			return default(bool);
		}
	}
}
