using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace AmplifyImpostors
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	public class AmplifyImpostor : MonoBehaviour
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000004 RID: 4 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000001")]
		public AmplifyImpostorAsset Data
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
			set
			{
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000006 RID: 6 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000002")]
		public Transform RootTransform
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
			set
			{
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000008 RID: 8 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000003")]
		public LODGroup LodGroup
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x5B2E90", Offset = "0x5B1490", VA = "0x1805B2E90")]
			set
			{
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x0600000A RID: 10 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000004")]
		public Renderer[] Renderers
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x5B2F00", Offset = "0x5B1500", VA = "0x1805B2F00")]
			set
			{
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x5B2F60", Offset = "0x5B1560", VA = "0x1805B2F60")]
		private void GenerateTextures(List<TextureOutput> outputList, bool standardRendering)
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x5B37F0", Offset = "0x5B1DF0", VA = "0x1805B37F0")]
		private void GenerateAlphaTextures(List<TextureOutput> outputList)
		{
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x5B3B10", Offset = "0x5B2110", VA = "0x1805B3B10")]
		private void ClearBuffers()
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x5B3C60", Offset = "0x5B2260", VA = "0x1805B3C60")]
		private void ClearAlphaBuffers()
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x5B3DB0", Offset = "0x5B23B0", VA = "0x1805B3DB0")]
		public void RenderImpostor(ImpostorType impostorType, int targetAmount, bool impostorMaps = true, bool combinedAlphas = false, bool useMinResolution = false, [Optional] Shader customShader)
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000206C File Offset: 0x0000026C
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x5B65E0", Offset = "0x5B4BE0", VA = "0x1805B65E0")]
		private Matrix4x4 GetCameraRotationMatrix(ImpostorType impostorType, int hframes, int vframes, int x, int y)
		{
			return default(Matrix4x4);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002084 File Offset: 0x00000284
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x5B6D90", Offset = "0x5B5390", VA = "0x1805B6D90")]
		private Vector3 OctahedronToVector(Vector2 oct)
		{
			return default(Vector3);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000209C File Offset: 0x0000029C
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x5B6EE0", Offset = "0x5B54E0", VA = "0x1805B6EE0")]
		private Vector3 OctahedronToVector(float x, float y)
		{
			return default(Vector3);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000020B4 File Offset: 0x000002B4
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x5B7020", Offset = "0x5B5620", VA = "0x1805B7020")]
		private Vector3 HemiOctahedronToVector(float x, float y)
		{
			return default(Vector3);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x5B7120", Offset = "0x5B5720", VA = "0x1805B7120")]
		public void GenerateAutomaticMesh(AmplifyImpostorAsset data)
		{
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x5B7780", Offset = "0x5B5D80", VA = "0x1805B7780")]
		public Mesh GenerateMesh(Vector2[] points, Vector3 offset, float width = 1f, float height = 1f, bool invertY = true)
		{
			return null;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x5B7F60", Offset = "0x5B6560", VA = "0x1805B7F60")]
		public AmplifyImpostor()
		{
		}

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		private const string ShaderGUID = "e82933f4c0eb9ba42aab0739f48efe21";

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		private const string DilateGUID = "57c23892d43bc9f458360024c5985405";

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		private const string PackerGUID = "31bd3cd74692f384a916d9d7ea87710d";

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		private const string ShaderOctaGUID = "572f9be5706148142b8da6e9de53acdb";

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		private const string StandardPreset = "e4786beb7716da54dbb02a632681cc37";

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		private const string LWPreset = "089f3a2f6b5f48348a48c755f8d9a7a2";

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		private const string LWShaderOctaGUID = "94e2ddcdfb3257a43872042f97e2fb01";

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		private const string LWShaderGUID = "990451a2073f6994ebf9fd6f90a842b3";

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		private const string HDPreset = "47b6b3dcefe0eaf4997acf89caf8c75e";

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		private const string HDShaderOctaGUID = "56236dc63ad9b7949b63a27f0ad180b3";

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		private const string HDShaderGUID = "175c951fec709c44fa2f26b8ab78b8dd";

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		private const string UPreset = "0403878495ffa3c4e9d4bcb3eac9b559";

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		private const string UShaderOctaGUID = "83dd8de9a5c14874884f9012def4fdcc";

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		private const string UShaderGUID = "da79d698f4bf0164e910ad798d07efdf";

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AmplifyImpostorAsset m_data;

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform m_rootTransform;

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private LODGroup m_lodGroup;

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Renderer[] m_renderers;

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public LODReplacement m_lodReplacement;

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		public RenderPipelineInUse m_renderPipelineInUse;

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int m_insertIndex;

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		public GameObject m_lastImpostor;

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		public string m_folderPath;

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[NonSerialized]
		public string m_impostorName;

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		public CutMode m_cutMode;

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		[NonSerialized]
		private const float StartXRotation = -90f;

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		[NonSerialized]
		private const float StartYRotation = 90f;

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		[NonSerialized]
		private const int MinAlphaResolution = 256;

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[NonSerialized]
		private RenderTexture[] m_rtGBuffers;

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[NonSerialized]
		private RenderTexture[] m_alphaGBuffers;

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[NonSerialized]
		private RenderTexture m_trueDepth;

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[NonSerialized]
		public Texture2D m_alphaTex;

		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[NonSerialized]
		private float m_xyFitSize;

		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[NonSerialized]
		private float m_depthFitSize;

		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[NonSerialized]
		private Vector2 m_pixelOffset;

		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[NonSerialized]
		private Bounds m_originalBound;

		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[NonSerialized]
		private Vector3 m_oriPos;

		// Token: 0x0400003F RID: 63
		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[NonSerialized]
		private Quaternion m_oriRot;

		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[NonSerialized]
		private Vector3 m_oriSca;

		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000041")]
		[NonSerialized]
		private const int BlockSize = 65536;
	}
}
