using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x02000037 RID: 55
	[Token(Token = "0x2000037")]
	[CreateAssetMenu(fileName = "triangle skinmap", menuName = "Obi/Triangle Skinmap", order = 123)]
	public class ObiTriangleSkinMap : ScriptableObject
	{
		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000190 RID: 400 RVA: 0x00002186 File Offset: 0x00000386
		// (set) Token: 0x0600018F RID: 399 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x1700004D")]
		public ObiClothBlueprintBase master
		{
			[Token(Token = "0x6000190")]
			[Address(RVA = "0x620F10", Offset = "0x61F510", VA = "0x180620F10")]
			get
			{
				return null;
			}
			[Token(Token = "0x600018F")]
			[Address(RVA = "0x274FC90", Offset = "0x274E290", VA = "0x18274FC90")]
			set
			{
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000192 RID: 402 RVA: 0x00002186 File Offset: 0x00000386
		// (set) Token: 0x06000191 RID: 401 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x1700004E")]
		public Mesh slave
		{
			[Token(Token = "0x6000192")]
			[Address(RVA = "0x675FA0", Offset = "0x6745A0", VA = "0x180675FA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000191")]
			[Address(RVA = "0x274FE00", Offset = "0x274E400", VA = "0x18274FE00")]
			set
			{
			}
		}

		// Token: 0x06000193 RID: 403 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000193")]
		[Address(RVA = "0x2750060", Offset = "0x274E660", VA = "0x182750060")]
		public void OnEnable()
		{
		}

		// Token: 0x06000194 RID: 404 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x2750090", Offset = "0x274E690", VA = "0x182750090")]
		public void Clear()
		{
		}

		// Token: 0x06000195 RID: 405 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000195")]
		[Address(RVA = "0x27500F0", Offset = "0x274E6F0", VA = "0x1827500F0")]
		public void ValidateMasterChannels(bool clearChannels)
		{
		}

		// Token: 0x06000196 RID: 406 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x27502D0", Offset = "0x274E8D0", VA = "0x1827502D0")]
		public void ValidateSlaveChannels(bool clearChannels)
		{
		}

		// Token: 0x06000197 RID: 407 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000197")]
		[Address(RVA = "0x2750540", Offset = "0x274EB40", VA = "0x182750540")]
		public void CopyChannel(uint[] channels, int source, int dest)
		{
		}

		// Token: 0x06000198 RID: 408 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x2750610", Offset = "0x274EC10", VA = "0x182750610")]
		public void FillChannel(uint[] channels, int channel)
		{
		}

		// Token: 0x06000199 RID: 409 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000199")]
		[Address(RVA = "0x2750660", Offset = "0x274EC60", VA = "0x182750660")]
		public void ClearChannel(uint[] channels, int channel)
		{
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0000272C File Offset: 0x0000092C
		[Token(Token = "0x600019A")]
		[Address(RVA = "0x27506B0", Offset = "0x274ECB0", VA = "0x1827506B0")]
		private bool BindToFace(int slaveIndex, ObiTriangleSkinMap.MasterFace triangle, Vector3 position, Vector3 normalPoint, Vector3 tangentPoint, out ObiTriangleSkinMap.SlaveVertex skinning)
		{
			return default(bool);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00002744 File Offset: 0x00000944
		[Token(Token = "0x600019B")]
		[Address(RVA = "0x2750920", Offset = "0x274EF20", VA = "0x182750920")]
		private float GetBarycentricError(Vector3 bary)
		{
			return 0f;
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0000275C File Offset: 0x0000095C
		[Token(Token = "0x600019C")]
		[Address(RVA = "0x2750A00", Offset = "0x274F000", VA = "0x182750A00")]
		private float GetFaceMappingError(ObiTriangleSkinMap.MasterFace triangle, ObiTriangleSkinMap.SlaveVertex vertex, Vector3 normal)
		{
			return 0f;
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00002774 File Offset: 0x00000974
		[Token(Token = "0x600019D")]
		[Address(RVA = "0x2750B80", Offset = "0x274F180", VA = "0x182750B80")]
		private bool FindSkinBarycentricCoords(ObiTriangleSkinMap.MasterFace triangle, Vector3 position, int max_iterations, float min_convergence, out ObiTriangleSkinMap.BarycentricPoint barycentricPoint)
		{
			return default(bool);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x600019E")]
		[Address(RVA = "0x27512E0", Offset = "0x274F8E0", VA = "0x1827512E0")]
		public IEnumerator Bind()
		{
			return null;
		}

		// Token: 0x0600019F RID: 415 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600019F")]
		[Address(RVA = "0x2751370", Offset = "0x274F970", VA = "0x182751370")]
		public ObiTriangleSkinMap()
		{
		}

		// Token: 0x0400012F RID: 303
		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public bool bound;

		// Token: 0x04000130 RID: 304
		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		[HideInInspector]
		public float barycentricWeight;

		// Token: 0x04000131 RID: 305
		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		[HideInInspector]
		public float normalAlignmentWeight;

		// Token: 0x04000132 RID: 306
		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0x24")]
		[HideInInspector]
		[Range(0f, 1f)]
		public float elevationWeight;

		// Token: 0x04000133 RID: 307
		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public uint[] m_MasterChannels;

		// Token: 0x04000134 RID: 308
		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0x30")]
		[HideInInspector]
		public uint[] m_SlaveChannels;

		// Token: 0x04000135 RID: 309
		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0x38")]
		[HideInInspector]
		public ObiTriangleSkinMap.SkinTransform m_SlaveTransform;

		// Token: 0x04000136 RID: 310
		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0x60")]
		[HideInInspector]
		public ObiClothBlueprintBase m_Master;

		// Token: 0x04000137 RID: 311
		[Token(Token = "0x4000137")]
		[FieldOffset(Offset = "0x68")]
		[HideInInspector]
		public Mesh m_Slave;

		// Token: 0x04000138 RID: 312
		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0x70")]
		[HideInInspector]
		public List<ObiTriangleSkinMap.SlaveVertex> skinnedVertices;

		// Token: 0x02000038 RID: 56
		[Token(Token = "0x2000038")]
		private class MasterFace
		{
			// Token: 0x060001A0 RID: 416 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x60001A0")]
			[Address(RVA = "0x27516D0", Offset = "0x274FCD0", VA = "0x1827516D0")]
			public void CacheBarycentricData()
			{
			}

			// Token: 0x060001A1 RID: 417 RVA: 0x0000278C File Offset: 0x0000098C
			[Token(Token = "0x60001A1")]
			[Address(RVA = "0x2751820", Offset = "0x274FE20", VA = "0x182751820")]
			public bool BarycentricCoords(Vector3 point, ref Vector3 coords)
			{
				return default(bool);
			}

			// Token: 0x060001A2 RID: 418 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x60001A2")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public MasterFace()
			{
			}

			// Token: 0x04000139 RID: 313
			[Token(Token = "0x4000139")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 p1;

			// Token: 0x0400013A RID: 314
			[Token(Token = "0x400013A")]
			[FieldOffset(Offset = "0x1C")]
			public Vector3 p2;

			// Token: 0x0400013B RID: 315
			[Token(Token = "0x400013B")]
			[FieldOffset(Offset = "0x28")]
			public Vector3 p3;

			// Token: 0x0400013C RID: 316
			[Token(Token = "0x400013C")]
			[FieldOffset(Offset = "0x34")]
			public Vector3 n1;

			// Token: 0x0400013D RID: 317
			[Token(Token = "0x400013D")]
			[FieldOffset(Offset = "0x40")]
			public Vector3 n2;

			// Token: 0x0400013E RID: 318
			[Token(Token = "0x400013E")]
			[FieldOffset(Offset = "0x4C")]
			public Vector3 n3;

			// Token: 0x0400013F RID: 319
			[Token(Token = "0x400013F")]
			[FieldOffset(Offset = "0x58")]
			private Vector3 v0;

			// Token: 0x04000140 RID: 320
			[Token(Token = "0x4000140")]
			[FieldOffset(Offset = "0x64")]
			private Vector3 v1;

			// Token: 0x04000141 RID: 321
			[Token(Token = "0x4000141")]
			[FieldOffset(Offset = "0x70")]
			private float dot00;

			// Token: 0x04000142 RID: 322
			[Token(Token = "0x4000142")]
			[FieldOffset(Offset = "0x74")]
			private float dot01;

			// Token: 0x04000143 RID: 323
			[Token(Token = "0x4000143")]
			[FieldOffset(Offset = "0x78")]
			private float dot11;

			// Token: 0x04000144 RID: 324
			[Token(Token = "0x4000144")]
			[FieldOffset(Offset = "0x7C")]
			public Vector3 faceNormal;

			// Token: 0x04000145 RID: 325
			[Token(Token = "0x4000145")]
			[FieldOffset(Offset = "0x88")]
			public float size;

			// Token: 0x04000146 RID: 326
			[Token(Token = "0x4000146")]
			[FieldOffset(Offset = "0x8C")]
			public int index;

			// Token: 0x04000147 RID: 327
			[Token(Token = "0x4000147")]
			[FieldOffset(Offset = "0x90")]
			public uint master;
		}

		// Token: 0x02000039 RID: 57
		[Token(Token = "0x2000039")]
		[Serializable]
		public struct SkinTransform
		{
			// Token: 0x060001A3 RID: 419 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x60001A3")]
			[Address(RVA = "0x27519D0", Offset = "0x274FFD0", VA = "0x1827519D0")]
			public SkinTransform(Vector3 position, Quaternion rotation, Vector3 scale)
			{
			}

			// Token: 0x060001A4 RID: 420 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x60001A4")]
			[Address(RVA = "0x2751A00", Offset = "0x2750000", VA = "0x182751A00")]
			public SkinTransform(Transform transform)
			{
			}

			// Token: 0x060001A5 RID: 421 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x60001A5")]
			[Address(RVA = "0x2751B50", Offset = "0x2750150", VA = "0x182751B50")]
			public void Apply(Transform transform)
			{
			}

			// Token: 0x060001A6 RID: 422 RVA: 0x000027A4 File Offset: 0x000009A4
			[Token(Token = "0x60001A6")]
			[Address(RVA = "0x2751C80", Offset = "0x2750280", VA = "0x182751C80")]
			public Matrix4x4 GetMatrix4X4()
			{
				return default(Matrix4x4);
			}

			// Token: 0x060001A7 RID: 423 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x60001A7")]
			[Address(RVA = "0x2751D60", Offset = "0x2750360", VA = "0x182751D60")]
			public void Reset()
			{
			}

			// Token: 0x04000148 RID: 328
			[Token(Token = "0x4000148")]
			[FieldOffset(Offset = "0x0")]
			public Vector3 position;

			// Token: 0x04000149 RID: 329
			[Token(Token = "0x4000149")]
			[FieldOffset(Offset = "0xC")]
			public Quaternion rotation;

			// Token: 0x0400014A RID: 330
			[Token(Token = "0x400014A")]
			[FieldOffset(Offset = "0x1C")]
			public Vector3 scale;
		}

		// Token: 0x0200003A RID: 58
		[Token(Token = "0x200003A")]
		[Serializable]
		public struct BarycentricPoint
		{
			// Token: 0x1700004F RID: 79
			// (get) Token: 0x060001A8 RID: 424 RVA: 0x000027BC File Offset: 0x000009BC
			[Token(Token = "0x1700004F")]
			public static ObiTriangleSkinMap.BarycentricPoint zero
			{
				[Token(Token = "0x60001A8")]
				[Address(RVA = "0x2751E20", Offset = "0x2750420", VA = "0x182751E20")]
				get
				{
					return default(ObiTriangleSkinMap.BarycentricPoint);
				}
			}

			// Token: 0x060001A9 RID: 425 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x60001A9")]
			[Address(RVA = "0xFA17B0", Offset = "0xF9FDB0", VA = "0x180FA17B0")]
			public BarycentricPoint(Vector3 position, float height)
			{
			}

			// Token: 0x0400014B RID: 331
			[Token(Token = "0x400014B")]
			[FieldOffset(Offset = "0x0")]
			public Vector3 barycentricCoords;

			// Token: 0x0400014C RID: 332
			[Token(Token = "0x400014C")]
			[FieldOffset(Offset = "0xC")]
			public float height;
		}

		// Token: 0x0200003B RID: 59
		[Token(Token = "0x200003B")]
		[Serializable]
		public class SlaveVertex
		{
			// Token: 0x17000050 RID: 80
			// (get) Token: 0x060001AA RID: 426 RVA: 0x00002186 File Offset: 0x00000386
			[Token(Token = "0x17000050")]
			public static ObiTriangleSkinMap.SlaveVertex empty
			{
				[Token(Token = "0x60001AA")]
				[Address(RVA = "0x2751E80", Offset = "0x2750480", VA = "0x182751E80")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000051 RID: 81
			// (get) Token: 0x060001AB RID: 427 RVA: 0x000027D4 File Offset: 0x000009D4
			[Token(Token = "0x17000051")]
			public bool isEmpty
			{
				[Token(Token = "0x60001AB")]
				[Address(RVA = "0x2752020", Offset = "0x2750620", VA = "0x182752020")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060001AC RID: 428 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x60001AC")]
			[Address(RVA = "0x2752030", Offset = "0x2750630", VA = "0x182752030")]
			public SlaveVertex(int slaveIndex, int masterTriangleIndex, ObiTriangleSkinMap.BarycentricPoint position, ObiTriangleSkinMap.BarycentricPoint normal, ObiTriangleSkinMap.BarycentricPoint tangent)
			{
			}

			// Token: 0x0400014D RID: 333
			[Token(Token = "0x400014D")]
			[FieldOffset(Offset = "0x10")]
			public int slaveIndex;

			// Token: 0x0400014E RID: 334
			[Token(Token = "0x400014E")]
			[FieldOffset(Offset = "0x14")]
			public int masterTriangleIndex;

			// Token: 0x0400014F RID: 335
			[Token(Token = "0x400014F")]
			[FieldOffset(Offset = "0x18")]
			public ObiTriangleSkinMap.BarycentricPoint position;

			// Token: 0x04000150 RID: 336
			[Token(Token = "0x4000150")]
			[FieldOffset(Offset = "0x28")]
			public ObiTriangleSkinMap.BarycentricPoint normal;

			// Token: 0x04000151 RID: 337
			[Token(Token = "0x4000151")]
			[FieldOffset(Offset = "0x38")]
			public ObiTriangleSkinMap.BarycentricPoint tangent;
		}
	}
}
