using System;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x02000093 RID: 147
	[Token(Token = "0x2000093")]
	[Documentation]
	public class NetworkArray_ProtocolToken : NetworkArray_Values<IProtocolToken>
	{
		// Token: 0x060004FB RID: 1275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x8EB260", Offset = "0x8E9860", VA = "0x1808EB260")]
		internal NetworkArray_ProtocolToken(int length, int stride)
		{
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x8EB2C0", Offset = "0x8E98C0", VA = "0x1808EB2C0", Slot = "7")]
		protected override IProtocolToken GetValue(int index)
		{
			return null;
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00003918 File Offset: 0x00001B18
		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x8EB370", Offset = "0x8E9970", VA = "0x1808EB370", Slot = "8")]
		protected override bool SetValue(int index, IProtocolToken value)
		{
			return default(bool);
		}
	}
}
