using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NGUI.Internal
{
	// Token: 0x0200008B RID: 139
	[Token(Token = "0x200008B")]
	public class UIGeometry
	{
		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000544 RID: 1348 RVA: 0x000040E0 File Offset: 0x000022E0
		[Token(Token = "0x17000117")]
		public bool hasVertices
		{
			[Token(Token = "0x6000544")]
			[Address(RVA = "0x120A240", Offset = "0x1208840", VA = "0x18120A240")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000545 RID: 1349 RVA: 0x000040F8 File Offset: 0x000022F8
		[Token(Token = "0x17000118")]
		public bool hasTransformed
		{
			[Token(Token = "0x6000545")]
			[Address(RVA = "0x269AAF0", Offset = "0x26990F0", VA = "0x18269AAF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000546")]
		[Address(RVA = "0x269AB30", Offset = "0x2699130", VA = "0x18269AB30")]
		public void Clear()
		{
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000547")]
		[Address(RVA = "0x269ABB0", Offset = "0x26991B0", VA = "0x18269ABB0")]
		public void ApplyTransform(Matrix4x4 widgetToPanel, bool generateNormals = true)
		{
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000548")]
		[Address(RVA = "0x269B0A0", Offset = "0x26996A0", VA = "0x18269B0A0")]
		public void WriteToBuffers(BetterList<Vector3> v, BetterList<Vector2> u, BetterList<Color32> c, BetterList<Vector3> n, BetterList<Vector4> t)
		{
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000549")]
		[Address(RVA = "0x269B640", Offset = "0x2699C40", VA = "0x18269B640")]
		public UIGeometry()
		{
		}

		// Token: 0x0400038F RID: 911
		[Token(Token = "0x400038F")]
		[FieldOffset(Offset = "0x10")]
		public BetterList<Vector3> verts;

		// Token: 0x04000390 RID: 912
		[Token(Token = "0x4000390")]
		[FieldOffset(Offset = "0x18")]
		public BetterList<Vector2> uvs;

		// Token: 0x04000391 RID: 913
		[Token(Token = "0x4000391")]
		[FieldOffset(Offset = "0x20")]
		public BetterList<Color32> cols;

		// Token: 0x04000392 RID: 914
		[Token(Token = "0x4000392")]
		[FieldOffset(Offset = "0x28")]
		private BetterList<Vector3> mRtpVerts;

		// Token: 0x04000393 RID: 915
		[Token(Token = "0x4000393")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 mRtpNormal;

		// Token: 0x04000394 RID: 916
		[Token(Token = "0x4000394")]
		[FieldOffset(Offset = "0x3C")]
		private Vector4 mRtpTan;
	}
}
