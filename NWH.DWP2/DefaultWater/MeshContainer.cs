using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NWH.DWP2.DefaultWater
{
	// Token: 0x02000058 RID: 88
	[Token(Token = "0x2000058")]
	public class MeshContainer
	{
		// Token: 0x06000265 RID: 613 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000265")]
		[Address(RVA = "0x27296A0", Offset = "0x2727CA0", VA = "0x1827296A0")]
		public MeshContainer(Mesh m)
		{
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000266")]
		[Address(RVA = "0x2729810", Offset = "0x2727E10", VA = "0x182729810")]
		public void Update()
		{
		}

		// Token: 0x0400022C RID: 556
		[Token(Token = "0x400022C")]
		[FieldOffset(Offset = "0x10")]
		public Mesh mesh;

		// Token: 0x0400022D RID: 557
		[Token(Token = "0x400022D")]
		[FieldOffset(Offset = "0x18")]
		public Vector3[] vertices;

		// Token: 0x0400022E RID: 558
		[Token(Token = "0x400022E")]
		[FieldOffset(Offset = "0x20")]
		public Vector3[] normals;
	}
}
