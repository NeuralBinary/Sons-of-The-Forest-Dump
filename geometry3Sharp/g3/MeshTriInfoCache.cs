using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200024C RID: 588
	[Token(Token = "0x200024C")]
	public class MeshTriInfoCache
	{
		// Token: 0x060014F6 RID: 5366 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014F6")]
		[Address(RVA = "0x1E8BC20", Offset = "0x1E8A220", VA = "0x181E8BC20")]
		public MeshTriInfoCache(DMesh3 mesh)
		{
		}

		// Token: 0x060014F7 RID: 5367 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014F7")]
		[Address(RVA = "0x1E8BF90", Offset = "0x1E8A590", VA = "0x181E8BF90")]
		public void GetTriInfo(int tid, ref Vector3d n, ref double a, ref Vector3d c)
		{
		}

		// Token: 0x040009BB RID: 2491
		[Token(Token = "0x40009BB")]
		[FieldOffset(Offset = "0x10")]
		public DVector<Vector3d> Centroids;

		// Token: 0x040009BC RID: 2492
		[Token(Token = "0x40009BC")]
		[FieldOffset(Offset = "0x18")]
		public DVector<Vector3d> Normals;

		// Token: 0x040009BD RID: 2493
		[Token(Token = "0x40009BD")]
		[FieldOffset(Offset = "0x20")]
		public DVector<double> Areas;
	}
}
