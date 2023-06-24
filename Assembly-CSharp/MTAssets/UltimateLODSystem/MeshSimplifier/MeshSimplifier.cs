using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using MTAssets.UltimateLODSystem.MeshSimplifier.Internal;
using UnityEngine;

namespace MTAssets.UltimateLODSystem.MeshSimplifier
{
	// Token: 0x0200006A RID: 106
	[Token(Token = "0x200006A")]
	public sealed class MeshSimplifier
	{
		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060001BD RID: 445 RVA: 0x000028B0 File Offset: 0x00000AB0
		// (set) Token: 0x060001BE RID: 446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000017")]
		public SimplificationOptions SimplificationOptions
		{
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x5FD4A0", Offset = "0x5FBAA0", VA = "0x1805FD4A0")]
			get
			{
				return default(SimplificationOptions);
			}
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x5FD4C0", Offset = "0x5FBAC0", VA = "0x1805FD4C0")]
			set
			{
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060001BF RID: 447 RVA: 0x000028C8 File Offset: 0x00000AC8
		// (set) Token: 0x060001C0 RID: 448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000018")]
		[Obsolete("Use MeshSimplifier.SimplificationOptions instead.", false)]
		public bool PreserveBorderEdges
		{
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0x5FD4E0", Offset = "0x5FBAE0", VA = "0x1805FD4E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x5FD4F0", Offset = "0x5FBAF0", VA = "0x1805FD4F0")]
			set
			{
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x000028E0 File Offset: 0x00000AE0
		// (set) Token: 0x060001C2 RID: 450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000019")]
		[Obsolete("Use MeshSimplifier.SimplificationOptions instead.", false)]
		public bool PreserveUVSeamEdges
		{
			[Token(Token = "0x60001C1")]
			[Address(RVA = "0x5FD500", Offset = "0x5FBB00", VA = "0x1805FD500")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x5FD510", Offset = "0x5FBB10", VA = "0x1805FD510")]
			set
			{
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x000028F8 File Offset: 0x00000AF8
		// (set) Token: 0x060001C4 RID: 452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001A")]
		[Obsolete("Use MeshSimplifier.SimplificationOptions instead.", false)]
		public bool PreserveUVFoldoverEdges
		{
			[Token(Token = "0x60001C3")]
			[Address(RVA = "0x5FD520", Offset = "0x5FBB20", VA = "0x1805FD520")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x5FD530", Offset = "0x5FBB30", VA = "0x1805FD530")]
			set
			{
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060001C5 RID: 453 RVA: 0x00002910 File Offset: 0x00000B10
		// (set) Token: 0x060001C6 RID: 454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001B")]
		[Obsolete("Use MeshSimplifier.SimplificationOptions instead.", false)]
		public bool PreserveSurfaceCurvature
		{
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x5FD540", Offset = "0x5FBB40", VA = "0x1805FD540")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x5FD550", Offset = "0x5FBB50", VA = "0x1805FD550")]
			set
			{
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x00002928 File Offset: 0x00000B28
		// (set) Token: 0x060001C8 RID: 456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001C")]
		[Obsolete("Use MeshSimplifier.SimplificationOptions instead.", false)]
		public bool EnableSmartLink
		{
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x5FD560", Offset = "0x5FBB60", VA = "0x1805FD560")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x5FD570", Offset = "0x5FBB70", VA = "0x1805FD570")]
			set
			{
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x00002940 File Offset: 0x00000B40
		// (set) Token: 0x060001CA RID: 458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001D")]
		[Obsolete("Use MeshSimplifier.SimplificationOptions instead.", false)]
		public int MaxIterationCount
		{
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x5FD590", Offset = "0x5FBB90", VA = "0x1805FD590")]
			set
			{
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060001CB RID: 459 RVA: 0x00002958 File Offset: 0x00000B58
		// (set) Token: 0x060001CC RID: 460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001E")]
		[Obsolete("Use MeshSimplifier.SimplificationOptions instead.", false)]
		public double Agressiveness
		{
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x5FD5A0", Offset = "0x5FBBA0", VA = "0x1805FD5A0")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0x5FD5B0", Offset = "0x5FBBB0", VA = "0x1805FD5B0")]
			set
			{
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060001CD RID: 461 RVA: 0x00002970 File Offset: 0x00000B70
		// (set) Token: 0x060001CE RID: 462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001F")]
		public bool Verbose
		{
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x5FD5C0", Offset = "0x5FBBC0", VA = "0x1805FD5C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x5FD5D0", Offset = "0x5FBBD0", VA = "0x1805FD5D0")]
			set
			{
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060001CF RID: 463 RVA: 0x00002988 File Offset: 0x00000B88
		// (set) Token: 0x060001D0 RID: 464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000020")]
		[Obsolete("Use MeshSimplifier.SimplificationOptions instead.", false)]
		public double VertexLinkDistance
		{
			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x5FD5E0", Offset = "0x5FBBE0", VA = "0x1805FD5E0")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x60001D0")]
			[Address(RVA = "0x5FD5F0", Offset = "0x5FBBF0", VA = "0x1805FD5F0")]
			set
			{
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x000029A0 File Offset: 0x00000BA0
		// (set) Token: 0x060001D2 RID: 466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000021")]
		[Obsolete("Use MeshSimplifier.SimplificationOptions instead.", false)]
		public double VertexLinkDistanceSqr
		{
			[Token(Token = "0x60001D1")]
			[Address(RVA = "0x5FD610", Offset = "0x5FBC10", VA = "0x1805FD610")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x60001D2")]
			[Address(RVA = "0x5FD620", Offset = "0x5FBC20", VA = "0x1805FD620")]
			set
			{
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x0000209A File Offset: 0x0000029A
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000022")]
		public Vector3[] Vertices
		{
			[Token(Token = "0x60001D3")]
			[Address(RVA = "0x5FD6A0", Offset = "0x5FBCA0", VA = "0x1805FD6A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001D4")]
			[Address(RVA = "0x5FD810", Offset = "0x5FBE10", VA = "0x1805FD810")]
			set
			{
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x000029B8 File Offset: 0x00000BB8
		[Token(Token = "0x17000023")]
		public int SubMeshCount
		{
			[Token(Token = "0x60001D5")]
			[Address(RVA = "0x5FDAB0", Offset = "0x5FC0B0", VA = "0x1805FDAB0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x000029D0 File Offset: 0x00000BD0
		[Token(Token = "0x17000024")]
		public int BlendShapeCount
		{
			[Token(Token = "0x60001D6")]
			[Address(RVA = "0x5FDAC0", Offset = "0x5FC0C0", VA = "0x1805FDAC0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x0000209A File Offset: 0x0000029A
		// (set) Token: 0x060001D8 RID: 472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000025")]
		public Vector3[] Normals
		{
			[Token(Token = "0x60001D7")]
			[Address(RVA = "0x5FDB00", Offset = "0x5FC100", VA = "0x1805FDB00")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0x5FDB40", Offset = "0x5FC140", VA = "0x1805FDB40")]
			set
			{
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x0000209A File Offset: 0x0000029A
		// (set) Token: 0x060001DA RID: 474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000026")]
		public Vector4[] Tangents
		{
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x5FDBB0", Offset = "0x5FC1B0", VA = "0x1805FDBB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001DA")]
			[Address(RVA = "0x5FDBF0", Offset = "0x5FC1F0", VA = "0x1805FDBF0")]
			set
			{
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060001DB RID: 475 RVA: 0x0000209A File Offset: 0x0000029A
		// (set) Token: 0x060001DC RID: 476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000027")]
		public Vector2[] UV1
		{
			[Token(Token = "0x60001DB")]
			[Address(RVA = "0x5FDC60", Offset = "0x5FC260", VA = "0x1805FDC60")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001DC")]
			[Address(RVA = "0x5FDC70", Offset = "0x5FC270", VA = "0x1805FDC70")]
			set
			{
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060001DD RID: 477 RVA: 0x0000209A File Offset: 0x0000029A
		// (set) Token: 0x060001DE RID: 478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000028")]
		public Vector2[] UV2
		{
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0x5FDC80", Offset = "0x5FC280", VA = "0x1805FDC80")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001DE")]
			[Address(RVA = "0x5FDC90", Offset = "0x5FC290", VA = "0x1805FDC90")]
			set
			{
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060001DF RID: 479 RVA: 0x0000209A File Offset: 0x0000029A
		// (set) Token: 0x060001E0 RID: 480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000029")]
		public Vector2[] UV3
		{
			[Token(Token = "0x60001DF")]
			[Address(RVA = "0x5FDCA0", Offset = "0x5FC2A0", VA = "0x1805FDCA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0x5FDCB0", Offset = "0x5FC2B0", VA = "0x1805FDCB0")]
			set
			{
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x0000209A File Offset: 0x0000029A
		// (set) Token: 0x060001E2 RID: 482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002A")]
		public Vector2[] UV4
		{
			[Token(Token = "0x60001E1")]
			[Address(RVA = "0x5FDCC0", Offset = "0x5FC2C0", VA = "0x1805FDCC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0x5FDCD0", Offset = "0x5FC2D0", VA = "0x1805FDCD0")]
			set
			{
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x0000209A File Offset: 0x0000029A
		// (set) Token: 0x060001E4 RID: 484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002B")]
		public Color[] Colors
		{
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x5FDCE0", Offset = "0x5FC2E0", VA = "0x1805FDCE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x5FDD30", Offset = "0x5FC330", VA = "0x1805FDD30")]
			set
			{
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x0000209A File Offset: 0x0000029A
		// (set) Token: 0x060001E6 RID: 486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002C")]
		public BoneWeight[] BoneWeights
		{
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x5FDDA0", Offset = "0x5FC3A0", VA = "0x1805FDDA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x5FDDF0", Offset = "0x5FC3F0", VA = "0x1805FDDF0")]
			set
			{
			}
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x5FDE60", Offset = "0x5FC460", VA = "0x1805FDE60")]
		public MeshSimplifier()
		{
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x5FE3B0", Offset = "0x5FC9B0", VA = "0x1805FE3B0")]
		public MeshSimplifier(Mesh mesh)
		{
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E9")]
		private void InitializeVertexAttribute<T>(T[] attributeValues, ref ResizableArray<T> attributeArray, string attributeName)
		{
		}

		// Token: 0x060001EA RID: 490 RVA: 0x000029E8 File Offset: 0x00000BE8
		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x5FE490", Offset = "0x5FCA90", VA = "0x1805FE490")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static double VertexError(ref SymmetricMatrix q, double x, double y, double z)
		{
			return 0.0;
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00002A00 File Offset: 0x00000C00
		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x5FE580", Offset = "0x5FCB80", VA = "0x1805FE580")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private double CurvatureError(ref Vertex vert0, ref Vertex vert1)
		{
			return 0.0;
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00002A18 File Offset: 0x00000C18
		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x5FEC40", Offset = "0x5FD240", VA = "0x1805FEC40")]
		private double CalculateError(ref Vertex vert0, ref Vertex vert1, out Vector3d result)
		{
			return 0.0;
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x5FF410", Offset = "0x5FDA10", VA = "0x1805FF410")]
		private static void CalculateBarycentricCoords(ref Vector3d point, ref Vector3d a, ref Vector3d b, ref Vector3d c, out Vector3 result)
		{
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00002A30 File Offset: 0x00000C30
		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x5FF6C0", Offset = "0x5FDCC0", VA = "0x1805FF6C0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static Vector4 NormalizeTangent(Vector4 tangent)
		{
			return default(Vector4);
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00002A48 File Offset: 0x00000C48
		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x5FF730", Offset = "0x5FDD30", VA = "0x1805FF730")]
		private bool Flipped(ref Vector3d p, int i0, int i1, ref Vertex v0, bool[] deleted)
		{
			return default(bool);
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x5FFDD0", Offset = "0x5FE3D0", VA = "0x1805FFDD0")]
		private void UpdateTriangles(int i0, int ia0, ref Vertex v, ResizableArray<bool> deleted, ref int deletedTriangles)
		{
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x6002E0", Offset = "0x5FE8E0", VA = "0x1806002E0")]
		private void InterpolateVertexAttributes(int dst, int i0, int i1, int i2, ref Vector3 barycentricCoord)
		{
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00002A60 File Offset: 0x00000C60
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x600E10", Offset = "0x5FF410", VA = "0x180600E10")]
		private bool AreUVsTheSame(int channel, int indexA, int indexB)
		{
			return default(bool);
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x6010C0", Offset = "0x5FF6C0", VA = "0x1806010C0")]
		private void RemoveVertexPass(int startTrisCount, int targetTrisCount, double threshold, ResizableArray<bool> deleted0, ResizableArray<bool> deleted1, ref int deletedTris)
		{
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x6019F0", Offset = "0x5FFFF0", VA = "0x1806019F0")]
		private void UpdateMesh(int iteration)
		{
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x602DE0", Offset = "0x6013E0", VA = "0x180602DE0")]
		private void UpdateReferences()
		{
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x603170", Offset = "0x601770", VA = "0x180603170")]
		private void CompactMesh()
		{
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x604600", Offset = "0x602C00", VA = "0x180604600")]
		private void CalculateSubMeshOffsets()
		{
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x6047A0", Offset = "0x602DA0", VA = "0x1806047A0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void GetTrianglesContainingVertex(ref Vertex vert, HashSet<Triangle> tris)
		{
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x604910", Offset = "0x602F10", VA = "0x180604910")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void GetTrianglesContainingBothVertices(ref Vertex vert0, ref Vertex vert1, HashSet<Triangle> tris)
		{
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x604B40", Offset = "0x603140", VA = "0x180604B40")]
		public int[][] GetAllSubMeshTriangles()
		{
			return null;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x604C20", Offset = "0x603220", VA = "0x180604C20")]
		public int[] GetSubMeshTriangles(int subMeshIndex)
		{
			return null;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x604F10", Offset = "0x603510", VA = "0x180604F10")]
		public void ClearSubMeshes()
		{
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x604FE0", Offset = "0x6035E0", VA = "0x180604FE0")]
		public void AddSubMeshTriangles(int[] triangles)
		{
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x605290", Offset = "0x603890", VA = "0x180605290")]
		public void AddSubMeshTriangles(int[][] triangles)
		{
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x605690", Offset = "0x603C90", VA = "0x180605690")]
		public Vector2[] GetUVs2D(int channel)
		{
			return null;
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x6000200")]
		[Address(RVA = "0x6057C0", Offset = "0x603DC0", VA = "0x1806057C0")]
		public Vector3[] GetUVs3D(int channel)
		{
			return null;
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x6000201")]
		[Address(RVA = "0x6058F0", Offset = "0x603EF0", VA = "0x1806058F0")]
		public Vector4[] GetUVs4D(int channel)
		{
			return null;
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000202")]
		[Address(RVA = "0x605A20", Offset = "0x604020", VA = "0x180605A20")]
		public void GetUVs(int channel, List<Vector2> uvs)
		{
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000203")]
		[Address(RVA = "0x605C00", Offset = "0x604200", VA = "0x180605C00")]
		public void GetUVs(int channel, List<Vector3> uvs)
		{
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000204")]
		[Address(RVA = "0x605DE0", Offset = "0x6043E0", VA = "0x180605DE0")]
		public void GetUVs(int channel, List<Vector4> uvs)
		{
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000205")]
		[Address(RVA = "0x605FC0", Offset = "0x6045C0", VA = "0x180605FC0")]
		public void SetUVs(int channel, IList<Vector2> uvs)
		{
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000206")]
		[Address(RVA = "0x6062C0", Offset = "0x6048C0", VA = "0x1806062C0")]
		public void SetUVs(int channel, IList<Vector3> uvs)
		{
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000207")]
		[Address(RVA = "0x6065C0", Offset = "0x604BC0", VA = "0x1806065C0")]
		public void SetUVs(int channel, IList<Vector4> uvs)
		{
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000208")]
		[Address(RVA = "0x6068D0", Offset = "0x604ED0", VA = "0x1806068D0")]
		public void SetUVs(int channel, IList<Vector4> uvs, int uvComponentCount)
		{
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000209")]
		[Address(RVA = "0x606DB0", Offset = "0x6053B0", VA = "0x180606DB0")]
		public void SetUVsAuto(int channel, IList<Vector4> uvs)
		{
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x600020A")]
		[Address(RVA = "0x606EB0", Offset = "0x6054B0", VA = "0x180606EB0")]
		public BlendShape[] GetAllBlendShapes()
		{
			return null;
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00002A78 File Offset: 0x00000C78
		[Token(Token = "0x600020B")]
		[Address(RVA = "0x607010", Offset = "0x605610", VA = "0x180607010")]
		public BlendShape GetBlendShape(int blendShapeIndex)
		{
			return default(BlendShape);
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020C")]
		[Address(RVA = "0x607100", Offset = "0x605700", VA = "0x180607100")]
		public void ClearBlendShapes()
		{
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020D")]
		[Address(RVA = "0x6071A0", Offset = "0x6057A0", VA = "0x1806071A0")]
		public void AddBlendShape(BlendShape blendShape)
		{
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020E")]
		[Address(RVA = "0x607340", Offset = "0x605940", VA = "0x180607340")]
		public void AddBlendShapes(BlendShape[] blendShapes)
		{
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020F")]
		[Address(RVA = "0x6075D0", Offset = "0x605BD0", VA = "0x1806075D0")]
		public void Initialize(Mesh mesh)
		{
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000210")]
		[Address(RVA = "0x607D50", Offset = "0x606350", VA = "0x180607D50")]
		public void SimplifyMesh(float quality)
		{
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000211")]
		[Address(RVA = "0x6082E0", Offset = "0x6068E0", VA = "0x1806082E0")]
		public void SimplifyMeshLossless()
		{
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x6000212")]
		[Address(RVA = "0x608780", Offset = "0x606D80", VA = "0x180608780")]
		public Mesh ToMesh()
		{
			return null;
		}

		// Token: 0x040002E3 RID: 739
		[Token(Token = "0x40002E3")]
		private const int TriangleEdgeCount = 3;

		// Token: 0x040002E4 RID: 740
		[Token(Token = "0x40002E4")]
		private const int TriangleVertexCount = 3;

		// Token: 0x040002E5 RID: 741
		[Token(Token = "0x40002E5")]
		private const double DoubleEpsilon = 0.001;

		// Token: 0x040002E6 RID: 742
		[Token(Token = "0x40002E6")]
		private const double DenomEpilson = 1E-08;

		// Token: 0x040002E7 RID: 743
		[Token(Token = "0x40002E7")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int UVChannelCount;

		// Token: 0x040002E8 RID: 744
		[Token(Token = "0x40002E8")]
		[FieldOffset(Offset = "0x10")]
		private SimplificationOptions simplificationOptions;

		// Token: 0x040002E9 RID: 745
		[Token(Token = "0x40002E9")]
		[FieldOffset(Offset = "0x38")]
		private bool verbose;

		// Token: 0x040002EA RID: 746
		[Token(Token = "0x40002EA")]
		[FieldOffset(Offset = "0x3C")]
		private int subMeshCount;

		// Token: 0x040002EB RID: 747
		[Token(Token = "0x40002EB")]
		[FieldOffset(Offset = "0x40")]
		private int[] subMeshOffsets;

		// Token: 0x040002EC RID: 748
		[Token(Token = "0x40002EC")]
		[FieldOffset(Offset = "0x48")]
		private ResizableArray<Triangle> triangles;

		// Token: 0x040002ED RID: 749
		[Token(Token = "0x40002ED")]
		[FieldOffset(Offset = "0x50")]
		private ResizableArray<Vertex> vertices;

		// Token: 0x040002EE RID: 750
		[Token(Token = "0x40002EE")]
		[FieldOffset(Offset = "0x58")]
		private ResizableArray<Ref> refs;

		// Token: 0x040002EF RID: 751
		[Token(Token = "0x40002EF")]
		[FieldOffset(Offset = "0x60")]
		private ResizableArray<Vector3> vertNormals;

		// Token: 0x040002F0 RID: 752
		[Token(Token = "0x40002F0")]
		[FieldOffset(Offset = "0x68")]
		private ResizableArray<Vector4> vertTangents;

		// Token: 0x040002F1 RID: 753
		[Token(Token = "0x40002F1")]
		[FieldOffset(Offset = "0x70")]
		private UVChannels<Vector2> vertUV2D;

		// Token: 0x040002F2 RID: 754
		[Token(Token = "0x40002F2")]
		[FieldOffset(Offset = "0x78")]
		private UVChannels<Vector3> vertUV3D;

		// Token: 0x040002F3 RID: 755
		[Token(Token = "0x40002F3")]
		[FieldOffset(Offset = "0x80")]
		private UVChannels<Vector4> vertUV4D;

		// Token: 0x040002F4 RID: 756
		[Token(Token = "0x40002F4")]
		[FieldOffset(Offset = "0x88")]
		private ResizableArray<Color> vertColors;

		// Token: 0x040002F5 RID: 757
		[Token(Token = "0x40002F5")]
		[FieldOffset(Offset = "0x90")]
		private ResizableArray<BoneWeight> vertBoneWeights;

		// Token: 0x040002F6 RID: 758
		[Token(Token = "0x40002F6")]
		[FieldOffset(Offset = "0x98")]
		private ResizableArray<BlendShapeContainer> blendShapes;

		// Token: 0x040002F7 RID: 759
		[Token(Token = "0x40002F7")]
		[FieldOffset(Offset = "0xA0")]
		private Matrix4x4[] bindposes;

		// Token: 0x040002F8 RID: 760
		[Token(Token = "0x40002F8")]
		[FieldOffset(Offset = "0xA8")]
		private readonly double[] errArr;

		// Token: 0x040002F9 RID: 761
		[Token(Token = "0x40002F9")]
		[FieldOffset(Offset = "0xB0")]
		private readonly int[] attributeIndexArr;

		// Token: 0x040002FA RID: 762
		[Token(Token = "0x40002FA")]
		[FieldOffset(Offset = "0xB8")]
		private readonly HashSet<Triangle> triangleHashSet1;

		// Token: 0x040002FB RID: 763
		[Token(Token = "0x40002FB")]
		[FieldOffset(Offset = "0xC0")]
		private readonly HashSet<Triangle> triangleHashSet2;
	}
}
