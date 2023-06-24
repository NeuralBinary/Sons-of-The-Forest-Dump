using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NWH.DWP2.WaterObjects
{
	// Token: 0x0200000F RID: 15
	[Token(Token = "0x200000F")]
	[Serializable]
	public struct SerializedMesh
	{
		// Token: 0x06000045 RID: 69 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x2700510", Offset = "0x26FEB10", VA = "0x182700510")]
		public void Serialize(Mesh mesh)
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000021CE File Offset: 0x000003CE
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x27005F0", Offset = "0x26FEBF0", VA = "0x1827005F0")]
		public Mesh Deserialize()
		{
			return null;
		}

		// Token: 0x0400003F RID: 63
		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		public Vector3[] vertices;

		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		public int[] triangles;
	}
}
