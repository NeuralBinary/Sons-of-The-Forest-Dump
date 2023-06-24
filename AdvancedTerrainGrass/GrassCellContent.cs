using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace AdvancedTerrainGrass
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	[Serializable]
	public class GrassCellContent
	{
		// Token: 0x06000009 RID: 9 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x59FB30", Offset = "0x59E130", VA = "0x18059FB30")]
		public void ReleaseCompleteCellContent()
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x59FCD0", Offset = "0x59E2D0", VA = "0x18059FCD0")]
		public void ReleaseCellContent()
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x59FE10", Offset = "0x59E410", VA = "0x18059FE10")]
		public void InitCellContent_Delegated(bool UseCompute, bool usingSinglePassInstanced)
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x5A01F0", Offset = "0x59E7F0", VA = "0x1805A01F0")]
		public void DrawCellContent_Delegated(Camera CameraInWichGrassWillBeDrawn, int CameraLayer, Vector3 TerrainShift)
		{
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public GrassCellContent()
		{
		}

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x10")]
		public int index;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x14")]
		public int Layer;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x18")]
		public int[] SoftlyMergedLayers;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x20")]
		public int state;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x28")]
		public Mesh v_mesh;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x30")]
		public Material v_mat;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x38")]
		public Material d_mat;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x40")]
		public int GrassMatrixBufferPID;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x44")]
		public ShadowCastingMode ShadowCastingMode;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x48")]
		public MotionVectorGenerationMode motionVectorGenerationMode;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x4C")]
		public int Instances;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x50")]
		public Vector3 Center;

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x5C")]
		public Vector3 Pivot;

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x68")]
		public Matrix4x4[] v_matrices;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x70")]
		public int PatchOffsetX;

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x74")]
		public int PatchOffsetZ;

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		public GraphicsBuffer matrixBuffer;

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x80")]
		[NonSerialized]
		public RenderParams rp;

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0xE0")]
		[NonSerialized]
		public GraphicsBuffer commandBuf;

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0xE8")]
		[NonSerialized]
		public GraphicsBuffer.IndirectDrawIndexedArgs[] commandData;

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0xF0")]
		private Bounds bounds;
	}
}
