using System;
using Il2CppDummyDll;
using PathCreation;
using UnityEngine;

namespace Endnight
{
	// Token: 0x02000019 RID: 25
	[Token(Token = "0x2000019")]
	public class SplineMeshCreator : PathSceneTool
	{
		// Token: 0x06000075 RID: 117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000075")]
		[Address(RVA = "0xA66D00", Offset = "0xA65300", VA = "0x180A66D00")]
		private void Update()
		{
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000076")]
		[Address(RVA = "0xA66E30", Offset = "0xA65430", VA = "0x180A66E30", Slot = "5")]
		protected override void PathUpdated()
		{
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000077")]
		[Address(RVA = "0xA66F10", Offset = "0xA65510", VA = "0x180A66F10")]
		private void CreateMesh()
		{
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000078")]
		[Address(RVA = "0xA682C0", Offset = "0xA668C0", VA = "0x180A682C0")]
		private void AssignMeshComponents()
		{
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000079")]
		[Address(RVA = "0xA68CA0", Offset = "0xA672A0", VA = "0x180A68CA0")]
		private void AssignMaterials()
		{
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007A")]
		[Address(RVA = "0xA69010", Offset = "0xA67610", VA = "0x180A69010")]
		public SplineMeshCreator()
		{
		}

		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x38")]
		[Range(0.1f, 100f)]
		[Header("Mesh Properties:")]
		[SerializeField]
		private float _width;

		// Token: 0x04000046 RID: 70
		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private bool _useWidthCurve;

		// Token: 0x04000047 RID: 71
		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AnimationCurve _widthCurve;

		// Token: 0x04000048 RID: 72
		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x48")]
		[Range(0f, 100f)]
		[SerializeField]
		private float _thickness;

		// Token: 0x04000049 RID: 73
		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private bool _flattenSurface;

		// Token: 0x0400004A RID: 74
		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x4D")]
		[Header("Rendering Properties:")]
		[SerializeField]
		private bool _enableRendering;

		// Token: 0x0400004B RID: 75
		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _meshGameObject;

		// Token: 0x0400004C RID: 76
		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Material _material;

		// Token: 0x0400004D RID: 77
		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float textureTiling;

		// Token: 0x0400004E RID: 78
		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x68")]
		private MeshFilter _meshFilter;

		// Token: 0x0400004F RID: 79
		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x70")]
		private MeshRenderer _meshRenderer;

		// Token: 0x04000050 RID: 80
		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x78")]
		private MeshCollider _meshCollider;

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x80")]
		private Mesh _mesh;
	}
}
