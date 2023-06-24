using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020002FF RID: 767
	[Token(Token = "0x20002FF")]
	public class SimpleHoleFiller
	{
		// Token: 0x060019E0 RID: 6624 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60019E0")]
		[Address(RVA = "0x1F16840", Offset = "0x1F14E40", VA = "0x181F16840")]
		public SimpleHoleFiller(DMesh3 mesh, EdgeLoop loop)
		{
		}

		// Token: 0x060019E1 RID: 6625 RVA: 0x00012D04 File Offset: 0x00010F04
		[Token(Token = "0x60019E1")]
		[Address(RVA = "0x1EF8500", Offset = "0x1EF6B00", VA = "0x181EF8500", Slot = "4")]
		public virtual ValidationStatus Validate()
		{
			return ValidationStatus.Ok;
		}

		// Token: 0x060019E2 RID: 6626 RVA: 0x00012D1C File Offset: 0x00010F1C
		[Token(Token = "0x60019E2")]
		[Address(RVA = "0x1F16960", Offset = "0x1F14F60", VA = "0x181F16960", Slot = "5")]
		public virtual bool Fill(int group_id = -1)
		{
			return default(bool);
		}

		// Token: 0x04000DAA RID: 3498
		[Token(Token = "0x4000DAA")]
		[FieldOffset(Offset = "0x10")]
		public DMesh3 Mesh;

		// Token: 0x04000DAB RID: 3499
		[Token(Token = "0x4000DAB")]
		[FieldOffset(Offset = "0x18")]
		public EdgeLoop Loop;

		// Token: 0x04000DAC RID: 3500
		[Token(Token = "0x4000DAC")]
		[FieldOffset(Offset = "0x20")]
		public int NewVertex;

		// Token: 0x04000DAD RID: 3501
		[Token(Token = "0x4000DAD")]
		[FieldOffset(Offset = "0x28")]
		public int[] NewTriangles;
	}
}
