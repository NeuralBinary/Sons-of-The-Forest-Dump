using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Crest
{
	// Token: 0x0200005F RID: 95
	[Token(Token = "0x200005F")]
	[ExecuteAlways]
	public class OceanChunkRenderer : MonoBehaviour
	{
		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000211 RID: 529 RVA: 0x000020E2 File Offset: 0x000002E2
		// (set) Token: 0x06000212 RID: 530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007D")]
		public Renderer Rend
		{
			[Token(Token = "0x6000211")]
			[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000212")]
			[Address(RVA = "0x6610F0", Offset = "0x65F6F0", VA = "0x1806610F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000213")]
		[Address(RVA = "0xA01290", Offset = "0x9FF890", VA = "0x180A01290")]
		private void Start()
		{
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000214")]
		[Address(RVA = "0xA01490", Offset = "0x9FFA90", VA = "0x180A01490")]
		private void SetOneTimeMPBParams()
		{
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000215")]
		[Address(RVA = "0xA01660", Offset = "0x9FFC60", VA = "0x180A01660")]
		private static void BeginCameraRendering(ScriptableRenderContext context, Camera camera)
		{
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000216")]
		[Address(RVA = "0xA016F0", Offset = "0x9FFCF0", VA = "0x180A016F0")]
		private void Update()
		{
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000217")]
		[Address(RVA = "0xA01810", Offset = "0x9FFE10", VA = "0x180A01810")]
		private void UpdateMeshBounds()
		{
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000218")]
		[Address(RVA = "0xA018F0", Offset = "0x9FFEF0", VA = "0x180A018F0")]
		internal void BindOceanData(Camera camera)
		{
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000219")]
		[Address(RVA = "0xA01D20", Offset = "0xA00320", VA = "0x180A01D20")]
		private void OnWillRenderObject()
		{
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021A")]
		[Address(RVA = "0xA025B0", Offset = "0xA00BB0", VA = "0x180A025B0")]
		public static void ExpandBoundsForDisplacements(Transform transform, ref Bounds bounds)
		{
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021B")]
		[Address(RVA = "0xA02740", Offset = "0xA00D40", VA = "0x180A02740")]
		public void SetInstanceData(int lodIndex, int totalLodCount, int lodDataResolution, int geoDownSampleFactor)
		{
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021C")]
		[Address(RVA = "0xA02760", Offset = "0xA00D60", VA = "0x180A02760")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void InitStatics()
		{
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021D")]
		[Address(RVA = "0xA027F0", Offset = "0xA00DF0", VA = "0x180A027F0")]
		[RuntimeInitializeOnLoadMethod]
		private static void RunOnStart()
		{
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021E")]
		[Address(RVA = "0xA028A0", Offset = "0xA00EA0", VA = "0x180A028A0")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021F")]
		[Address(RVA = "0xA02940", Offset = "0xA00F40", VA = "0x180A02940")]
		public OceanChunkRenderer()
		{
		}

		// Token: 0x04000199 RID: 409
		[Token(Token = "0x4000199")]
		[FieldOffset(Offset = "0x20")]
		private Transform _trans;

		// Token: 0x0400019A RID: 410
		[Token(Token = "0x400019A")]
		[FieldOffset(Offset = "0x28")]
		public OceanRenderer _ocean;

		// Token: 0x0400019B RID: 411
		[Token(Token = "0x400019B")]
		[FieldOffset(Offset = "0x30")]
		public bool _drawRenderBounds;

		// Token: 0x0400019C RID: 412
		[Token(Token = "0x400019C")]
		[FieldOffset(Offset = "0x34")]
		public Bounds _boundsLocal;

		// Token: 0x0400019D RID: 413
		[Token(Token = "0x400019D")]
		[FieldOffset(Offset = "0x50")]
		private Mesh _mesh;

		// Token: 0x0400019F RID: 415
		[Token(Token = "0x400019F")]
		[FieldOffset(Offset = "0x60")]
		private PropertyWrapperMPB _mpb;

		// Token: 0x040001A0 RID: 416
		[Token(Token = "0x40001A0")]
		[FieldOffset(Offset = "0x68")]
		internal bool _oceanDataHasBeenBound;

		// Token: 0x040001A1 RID: 417
		[Token(Token = "0x40001A1")]
		[FieldOffset(Offset = "0x6C")]
		private int _lodIndex;

		// Token: 0x040001A2 RID: 418
		[Token(Token = "0x40001A2")]
		[FieldOffset(Offset = "0x70")]
		private int _totalLodCount;

		// Token: 0x040001A3 RID: 419
		[Token(Token = "0x40001A3")]
		[FieldOffset(Offset = "0x74")]
		private int _lodDataResolution;

		// Token: 0x040001A4 RID: 420
		[Token(Token = "0x40001A4")]
		[FieldOffset(Offset = "0x78")]
		private int _geoDownSampleFactor;

		// Token: 0x040001A5 RID: 421
		[Token(Token = "0x40001A5")]
		[FieldOffset(Offset = "0x0")]
		private static Camera _currentCamera;
	}
}
