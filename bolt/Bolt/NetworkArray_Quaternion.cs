using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Bolt
{
	// Token: 0x02000094 RID: 148
	[Token(Token = "0x2000094")]
	[Documentation]
	public class NetworkArray_Quaternion : NetworkArray_Values<Quaternion>
	{
		// Token: 0x060004FE RID: 1278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x8EB4D0", Offset = "0x8E9AD0", VA = "0x1808EB4D0")]
		internal NetworkArray_Quaternion(int length, int stride)
		{
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00003930 File Offset: 0x00001B30
		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x8EB5B0", Offset = "0x8E9BB0", VA = "0x1808EB5B0", Slot = "7")]
		protected override Quaternion GetValue(int index)
		{
			return default(Quaternion);
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x00003948 File Offset: 0x00001B48
		[Token(Token = "0x6000500")]
		[Address(RVA = "0x8EB620", Offset = "0x8E9C20", VA = "0x1808EB620", Slot = "8")]
		protected override bool SetValue(int index, Quaternion value)
		{
			return default(bool);
		}
	}
}
