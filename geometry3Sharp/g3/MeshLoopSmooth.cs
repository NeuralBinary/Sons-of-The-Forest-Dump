using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020002EB RID: 747
	[Token(Token = "0x20002EB")]
	public class MeshLoopSmooth
	{
		// Token: 0x0600197E RID: 6526 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600197E")]
		[Address(RVA = "0x1F08E00", Offset = "0x1F07400", VA = "0x181F08E00")]
		public MeshLoopSmooth(DMesh3 mesh, EdgeLoop loop)
		{
		}

		// Token: 0x0600197F RID: 6527 RVA: 0x0001298C File Offset: 0x00010B8C
		[Token(Token = "0x600197F")]
		[Address(RVA = "0x1F08FE0", Offset = "0x1F075E0", VA = "0x181F08FE0", Slot = "4")]
		public virtual ValidationStatus Validate()
		{
			return ValidationStatus.Ok;
		}

		// Token: 0x06001980 RID: 6528 RVA: 0x000129A4 File Offset: 0x00010BA4
		[Token(Token = "0x6001980")]
		[Address(RVA = "0x1F09100", Offset = "0x1F07700", VA = "0x181F09100", Slot = "5")]
		public virtual bool Smooth()
		{
			return default(bool);
		}

		// Token: 0x04000D3B RID: 3387
		[Token(Token = "0x4000D3B")]
		[FieldOffset(Offset = "0x10")]
		public DMesh3 Mesh;

		// Token: 0x04000D3C RID: 3388
		[Token(Token = "0x4000D3C")]
		[FieldOffset(Offset = "0x18")]
		public EdgeLoop Loop;

		// Token: 0x04000D3D RID: 3389
		[Token(Token = "0x4000D3D")]
		[FieldOffset(Offset = "0x20")]
		public double Alpha;

		// Token: 0x04000D3E RID: 3390
		[Token(Token = "0x4000D3E")]
		[FieldOffset(Offset = "0x28")]
		public int Rounds;

		// Token: 0x04000D3F RID: 3391
		[Token(Token = "0x4000D3F")]
		[FieldOffset(Offset = "0x30")]
		public Func<Vector3d, int, Vector3d> ProjectF;

		// Token: 0x04000D40 RID: 3392
		[Token(Token = "0x4000D40")]
		[FieldOffset(Offset = "0x38")]
		private Vector3d[] SmoothedPostions;
	}
}
