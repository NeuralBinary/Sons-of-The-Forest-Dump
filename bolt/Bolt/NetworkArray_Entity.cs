using System;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x0200008F RID: 143
	[Token(Token = "0x200008F")]
	[Documentation]
	public class NetworkArray_Entity : NetworkArray_Values<BoltEntity>
	{
		// Token: 0x060004EF RID: 1263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x8EAA30", Offset = "0x8E9030", VA = "0x1808EAA30")]
		internal NetworkArray_Entity(int length, int stride)
		{
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x8EAA90", Offset = "0x8E9090", VA = "0x1808EAA90", Slot = "7")]
		protected override BoltEntity GetValue(int index)
		{
			return null;
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x00003870 File Offset: 0x00001A70
		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x8EAB30", Offset = "0x8E9130", VA = "0x1808EAB30", Slot = "8")]
		protected override bool SetValue(int index, BoltEntity value)
		{
			return default(bool);
		}
	}
}
