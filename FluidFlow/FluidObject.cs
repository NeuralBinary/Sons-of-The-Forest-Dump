using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace FluidSimulation
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	[PreferBinarySerialization]
	public class FluidObject : ScriptableObject
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000E RID: 14 RVA: 0x000020B8 File Offset: 0x000002B8
		[Token(Token = "0x17000001")]
		public int TextureSize
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000F RID: 15 RVA: 0x000020D0 File Offset: 0x000002D0
		[Token(Token = "0x17000002")]
		public UV UVChanel
		{
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x9FA1D0", Offset = "0x9F87D0", VA = "0x1809FA1D0")]
			get
			{
				return UV.UV1;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000010 RID: 16 RVA: 0x000020E8 File Offset: 0x000002E8
		[Token(Token = "0x17000003")]
		public int SubmeshMask
		{
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00002100 File Offset: 0x00000300
		[Token(Token = "0x17000004")]
		public int UnpaddedTriangleCount
		{
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x7814F0", Offset = "0x77FAF0", VA = "0x1807814F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00002118 File Offset: 0x00000318
		[Token(Token = "0x17000005")]
		public int PaddedTriangleCount
		{
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x632000", Offset = "0x630600", VA = "0x180632000")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000013 RID: 19 RVA: 0x00002130 File Offset: 0x00000330
		[Token(Token = "0x17000006")]
		public BoundingBox MeshBounds
		{
			[Token(Token = "0x6000013")]
			[Address(RVA = "0xAFD010", Offset = "0xAFB610", VA = "0x180AFD010")]
			get
			{
				return default(BoundingBox);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000007")]
		public string BaseMeshName
		{
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x661070", Offset = "0x65F670", VA = "0x180661070")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002148 File Offset: 0x00000348
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x671150", Offset = "0x66F750", VA = "0x180671150")]
		public bool hasSkeletonData()
		{
			return default(bool);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002160 File Offset: 0x00000360
		[Token(Token = "0x6000016")]
		[Address(RVA = "0xAFD030", Offset = "0xAFB630", VA = "0x180AFD030")]
		public Vector3 TransformPointToDefaultPose(Transform bone, int boneId, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002178 File Offset: 0x00000378
		[Token(Token = "0x6000017")]
		[Address(RVA = "0xAFD2B0", Offset = "0xAFB8B0", VA = "0x180AFD2B0")]
		public Vector3 TransformDirectionToDefaultPose(Transform bone, int boneId, Vector3 direction)
		{
			return default(Vector3);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002190 File Offset: 0x00000390
		[Token(Token = "0x6000018")]
		[Address(RVA = "0xAFD4D0", Offset = "0xAFBAD0", VA = "0x180AFD4D0")]
		public int FindClosestBoneDefaultPose(Vector3 position)
		{
			return 0;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000021A8 File Offset: 0x000003A8
		[Token(Token = "0x6000019")]
		[Address(RVA = "0xAFD610", Offset = "0xAFBC10", VA = "0x180AFD610")]
		public Vector3 TransformPointFromDefaultPose(Transform bone, int boneId, Vector3 position)
		{
			return default(Vector3);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600001A")]
		[Address(RVA = "0xAFD8B0", Offset = "0xAFBEB0", VA = "0x180AFD8B0")]
		public ComputeBuffer GetTriangleBuffer()
		{
			return null;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600001B")]
		[Address(RVA = "0xAFD9B0", Offset = "0xAFBFB0", VA = "0x180AFD9B0")]
		public ComputeBuffer GetRawTextureBuffer()
		{
			return null;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600001C")]
		[Address(RVA = "0xAFDAB0", Offset = "0xAFC0B0", VA = "0x180AFDAB0")]
		public ComputeBuffer GetTangentsBuffer()
		{
			return null;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000021C0 File Offset: 0x000003C0
		[Token(Token = "0x600001D")]
		[Address(RVA = "0xAFDBB0", Offset = "0xAFC1B0", VA = "0x180AFDBB0")]
		public CompressionState GetCompressionState()
		{
			return CompressionState.Decompressed;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600001E")]
		[Address(RVA = "0xAFDBC0", Offset = "0xAFC1C0", VA = "0x180AFDBC0")]
		public IEnumerator DecompressDataRuntime()
		{
			return null;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001F")]
		[Address(RVA = "0xAFDC50", Offset = "0xAFC250", VA = "0x180AFDC50")]
		private void decompress()
		{
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000020")]
		[Address(RVA = "0xAFDDD0", Offset = "0xAFC3D0", VA = "0x180AFDDD0")]
		public FluidObject()
		{
		}

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int textureSize;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private UV uvChanel;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int submeshMask;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private int unpaddedTriangleCount;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int paddedTriangleCount;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private BoundingBox meshBounds;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private string baseMeshName;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Matrix4x4[] baseSkeletonPoseL2W;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Matrix4x4[] baseSkeletonPoseW2L;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Vector3[] baseSkeletonPoseBonePositions;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private bool fromSkinnedMesh;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private CompressionState compressionState;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private byte[] tangents;

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private byte[] texelMapRaw;

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private byte[] trianglesPacked;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private byte[] texelMapRawCompressed;

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private byte[] tangentsCompressed;

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private byte[] trianglesPackedCompressed;

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0xA8")]
		[NonSerialized]
		private CompressionState compressionStateTmp;

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0xB0")]
		[NonSerialized]
		private byte[] texelMapTmp;

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0xB8")]
		[NonSerialized]
		private byte[] tangentsTmp;

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0xC0")]
		[NonSerialized]
		private byte[] trianglesPackedTmp;
	}
}
