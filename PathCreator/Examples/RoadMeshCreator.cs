using System;
using Il2CppDummyDll;
using UnityEngine;

namespace PathCreation.Examples
{
	// Token: 0x0200001A RID: 26
	[Token(Token = "0x200001A")]
	public class RoadMeshCreator : PathSceneTool
	{
		// Token: 0x060000A6 RID: 166 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x28376D0", Offset = "0x2835CD0", VA = "0x1828376D0", Slot = "5")]
		protected override void PathUpdated()
		{
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x28377B0", Offset = "0x2835DB0", VA = "0x1828377B0")]
		private void CreateRoadMesh()
		{
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x28387F0", Offset = "0x2836DF0", VA = "0x1828387F0")]
		private void AssignMeshComponents()
		{
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x2838FC0", Offset = "0x28375C0", VA = "0x182838FC0")]
		private void AssignMaterials()
		{
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x28392D0", Offset = "0x28378D0", VA = "0x1828392D0")]
		public RoadMeshCreator()
		{
		}

		// Token: 0x04000083 RID: 131
		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x38")]
		[Header("Road settings")]
		public float roadWidth;

		// Token: 0x04000084 RID: 132
		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x3C")]
		[Range(0f, 0.5f)]
		public float thickness;

		// Token: 0x04000085 RID: 133
		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x40")]
		public bool flattenSurface;

		// Token: 0x04000086 RID: 134
		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x48")]
		[Header("Material settings")]
		public Material roadMaterial;

		// Token: 0x04000087 RID: 135
		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x50")]
		public Material undersideMaterial;

		// Token: 0x04000088 RID: 136
		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x58")]
		public float textureTiling;

		// Token: 0x04000089 RID: 137
		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[HideInInspector]
		private GameObject meshHolder;

		// Token: 0x0400008A RID: 138
		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x68")]
		private MeshFilter meshFilter;

		// Token: 0x0400008B RID: 139
		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x70")]
		private MeshRenderer meshRenderer;

		// Token: 0x0400008C RID: 140
		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x78")]
		private Mesh mesh;
	}
}
