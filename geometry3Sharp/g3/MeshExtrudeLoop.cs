using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020002D4 RID: 724
	[Token(Token = "0x20002D4")]
	public class MeshExtrudeLoop
	{
		// Token: 0x06001919 RID: 6425 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001919")]
		[Address(RVA = "0x1EF82C0", Offset = "0x1EF68C0", VA = "0x181EF82C0")]
		public MeshExtrudeLoop(DMesh3 mesh, EdgeLoop loop)
		{
		}

		// Token: 0x0600191A RID: 6426 RVA: 0x00012674 File Offset: 0x00010874
		[Token(Token = "0x600191A")]
		[Address(RVA = "0x1EF8500", Offset = "0x1EF6B00", VA = "0x181EF8500", Slot = "4")]
		public virtual ValidationStatus Validate()
		{
			return ValidationStatus.Ok;
		}

		// Token: 0x0600191B RID: 6427 RVA: 0x0001268C File Offset: 0x0001088C
		[Token(Token = "0x600191B")]
		[Address(RVA = "0x1EF8680", Offset = "0x1EF6C80", VA = "0x181EF8680", Slot = "5")]
		public virtual bool Extrude(int group_id = -1)
		{
			return default(bool);
		}

		// Token: 0x04000CB4 RID: 3252
		[Token(Token = "0x4000CB4")]
		[FieldOffset(Offset = "0x10")]
		public DMesh3 Mesh;

		// Token: 0x04000CB5 RID: 3253
		[Token(Token = "0x4000CB5")]
		[FieldOffset(Offset = "0x18")]
		public EdgeLoop Loop;

		// Token: 0x04000CB6 RID: 3254
		[Token(Token = "0x4000CB6")]
		[FieldOffset(Offset = "0x20")]
		public Func<Vector3d, Vector3f, int, Vector3d> PositionF;

		// Token: 0x04000CB7 RID: 3255
		[Token(Token = "0x4000CB7")]
		[FieldOffset(Offset = "0x28")]
		public int[] NewTriangles;

		// Token: 0x04000CB8 RID: 3256
		[Token(Token = "0x4000CB8")]
		[FieldOffset(Offset = "0x30")]
		public EdgeLoop NewLoop;
	}
}
