using System;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x02000096 RID: 150
	[Token(Token = "0x2000096")]
	[Documentation]
	public class NetworkArray_Transform : NetworkArray_Values<NetworkTransform>
	{
		// Token: 0x170000F4 RID: 244
		[Token(Token = "0x170000F4")]
		public new NetworkTransform this[int index]
		{
			[Token(Token = "0x6000504")]
			[Address(RVA = "0x8EB9C0", Offset = "0x8E9FC0", VA = "0x1808EB9C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000505")]
		[Address(RVA = "0x8EBA10", Offset = "0x8EA010", VA = "0x1808EBA10")]
		internal NetworkArray_Transform(int length, int stride)
		{
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000506")]
		[Address(RVA = "0x8EBA70", Offset = "0x8EA070", VA = "0x1808EBA70", Slot = "7")]
		protected override NetworkTransform GetValue(int index)
		{
			return null;
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x00003978 File Offset: 0x00001B78
		[Token(Token = "0x6000507")]
		[Address(RVA = "0x8EBAD0", Offset = "0x8EA0D0", VA = "0x1808EBAD0", Slot = "8")]
		protected override bool SetValue(int index, NetworkTransform value)
		{
			return default(bool);
		}
	}
}
