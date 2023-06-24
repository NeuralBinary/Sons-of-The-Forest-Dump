using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020002D2 RID: 722
	[Token(Token = "0x20002D2")]
	public class MeshExtrudeFaces
	{
		// Token: 0x06001911 RID: 6417 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001911")]
		[Address(RVA = "0x1EF71C0", Offset = "0x1EF57C0", VA = "0x181EF71C0")]
		public MeshExtrudeFaces(DMesh3 mesh, int[] triangles, bool bForceCopyArray = false)
		{
		}

		// Token: 0x06001912 RID: 6418 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001912")]
		[Address(RVA = "0x1EF7500", Offset = "0x1EF5B00", VA = "0x181EF7500")]
		public MeshExtrudeFaces(DMesh3 mesh, IEnumerable<int> triangles)
		{
		}

		// Token: 0x06001913 RID: 6419 RVA: 0x00012614 File Offset: 0x00010814
		[Token(Token = "0x6001913")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "4")]
		public virtual ValidationStatus Validate()
		{
			return ValidationStatus.Ok;
		}

		// Token: 0x06001914 RID: 6420 RVA: 0x0001262C File Offset: 0x0001082C
		[Token(Token = "0x6001914")]
		[Address(RVA = "0x1EF77F0", Offset = "0x1EF5DF0", VA = "0x181EF77F0", Slot = "5")]
		public virtual bool Extrude()
		{
			return default(bool);
		}

		// Token: 0x04000CA8 RID: 3240
		[Token(Token = "0x4000CA8")]
		[FieldOffset(Offset = "0x10")]
		public DMesh3 Mesh;

		// Token: 0x04000CA9 RID: 3241
		[Token(Token = "0x4000CA9")]
		[FieldOffset(Offset = "0x18")]
		public int[] Triangles;

		// Token: 0x04000CAA RID: 3242
		[Token(Token = "0x4000CAA")]
		[FieldOffset(Offset = "0x20")]
		public SetGroupBehavior Group;

		// Token: 0x04000CAB RID: 3243
		[Token(Token = "0x4000CAB")]
		[FieldOffset(Offset = "0x28")]
		public Func<Vector3d, Vector3f, int, Vector3d> ExtrudedPositionF;

		// Token: 0x04000CAC RID: 3244
		[Token(Token = "0x4000CAC")]
		[FieldOffset(Offset = "0x30")]
		public List<Index2i> EdgePairs;

		// Token: 0x04000CAD RID: 3245
		[Token(Token = "0x4000CAD")]
		[FieldOffset(Offset = "0x38")]
		public MeshVertexSelection ExtrudeVertices;

		// Token: 0x04000CAE RID: 3246
		[Token(Token = "0x4000CAE")]
		[FieldOffset(Offset = "0x40")]
		public int[] JoinTriangles;

		// Token: 0x04000CAF RID: 3247
		[Token(Token = "0x4000CAF")]
		[FieldOffset(Offset = "0x48")]
		public int JoinGroupID;

		// Token: 0x04000CB0 RID: 3248
		[Token(Token = "0x4000CB0")]
		[FieldOffset(Offset = "0x4C")]
		public bool JoinIncomplete;
	}
}
