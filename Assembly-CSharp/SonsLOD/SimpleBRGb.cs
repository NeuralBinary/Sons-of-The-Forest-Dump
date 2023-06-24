using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Rendering.FrustumPlanes;
using UnityEngine;
using UnityEngine.Rendering;

namespace SonsLOD
{
	// Token: 0x02000046 RID: 70
	[Token(Token = "0x2000046")]
	public class SimpleBRGb : MonoBehaviour
	{
		// Token: 0x060000E9 RID: 233 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x60000E9")]
		public unsafe static T* Malloc<T>(int count) where T : struct
		{
			return null;
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x5E4BC0", Offset = "0x5E31C0", VA = "0x1805E4BC0")]
		private void OnEnable()
		{
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x5E54C0", Offset = "0x5E3AC0", VA = "0x1805E54C0")]
		private void GetAllRenderers()
		{
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x5E5610", Offset = "0x5E3C10", VA = "0x1805E5610")]
		private void AllocateInstanceDateBuffer()
		{
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x5E56F0", Offset = "0x5E3CF0", VA = "0x1805E56F0")]
		private void AddRenderers()
		{
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x5E6020", Offset = "0x5E4620", VA = "0x1805E6020")]
		private void Update()
		{
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x5E6350", Offset = "0x5E4950", VA = "0x1805E6350")]
		private void OnDisable()
		{
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x000022E0 File Offset: 0x000004E0
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x5DD8E0", Offset = "0x5DBEE0", VA = "0x1805DD8E0")]
		private int BufferCountForInstances(int bytesPerInstance, int numInstances, int extraBytes = 0)
		{
			return 0;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x000022F8 File Offset: 0x000004F8
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x5E6480", Offset = "0x5E4A80", VA = "0x1805E6480")]
		public JobHandle OnPerformCulling(BatchRendererGroup rendererGroup, BatchCullingContext cullingContext, BatchCullingOutput cullingOutput, IntPtr userContext)
		{
			return default(JobHandle);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00002310 File Offset: 0x00000510
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x5E82C0", Offset = "0x5E68C0", VA = "0x1805E82C0")]
		private static float GetShadowVolumeLengthFromCasterAndFrustumAndLightDir(float3 lightDir, float3 casterPosition, float casterRadius, NativeArray<Plane> planes)
		{
			return 0f;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00002328 File Offset: 0x00000528
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x5E8510", Offset = "0x5E6B10", VA = "0x1805E8510")]
		private static float RayDistanceToFrustumOriented(Ray ray, NativeArray<Plane> planes, out int planeNumber)
		{
			return 0f;
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00002340 File Offset: 0x00000540
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x5E87A0", Offset = "0x5E6DA0", VA = "0x1805E87A0")]
		private static bool IntersectRayPlaneOriented(Ray ray, Plane plane, out float distance)
		{
			return default(bool);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00002358 File Offset: 0x00000558
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x5E88F0", Offset = "0x5E6EF0", VA = "0x1805E88F0")]
		private static bool IsInsideSphere(BoundingSphere sphere, BoundingSphere containingSphere)
		{
			return default(bool);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00002370 File Offset: 0x00000570
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x5E8970", Offset = "0x5E6F70", VA = "0x1805E8970")]
		private static bool IsCapsuleInsideSphere(float3 capsuleBegin, float3 capsuleEnd, float capsuleRadius, BoundingSphere sphere)
		{
			return default(bool);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x5E8AD0", Offset = "0x5E70D0", VA = "0x1805E8AD0")]
		public SimpleBRGb()
		{
		}

		// Token: 0x040001E6 RID: 486
		[Token(Token = "0x40001E6")]
		[FieldOffset(Offset = "0x20")]
		[Header("Base Settings")]
		[Space(8f)]
		public Mesh mesh;

		// Token: 0x040001E7 RID: 487
		[Token(Token = "0x40001E7")]
		[FieldOffset(Offset = "0x28")]
		public Material material;

		// Token: 0x040001E8 RID: 488
		[Token(Token = "0x40001E8")]
		[FieldOffset(Offset = "0x30")]
		public Material addmaterial;

		// Token: 0x040001E9 RID: 489
		[Token(Token = "0x40001E9")]
		[FieldOffset(Offset = "0x38")]
		[Space(8f)]
		[Header("Batch Settings")]
		public int _capacity;

		// Token: 0x040001EA RID: 490
		[Token(Token = "0x40001EA")]
		[FieldOffset(Offset = "0x40")]
		[Space(8f)]
		[Header("LOD and Culling")]
		public Mesh meshLod;

		// Token: 0x040001EB RID: 491
		[Token(Token = "0x40001EB")]
		[FieldOffset(Offset = "0x48")]
		public float _lodDistance;

		// Token: 0x040001EC RID: 492
		[Token(Token = "0x40001EC")]
		[FieldOffset(Offset = "0x4C")]
		public bool _RenderOnlyLod1;

		// Token: 0x040001ED RID: 493
		[Token(Token = "0x40001ED")]
		[FieldOffset(Offset = "0x50")]
		[Header("Culling")]
		[Space(8f)]
		public float _cullDistance;

		// Token: 0x040001EE RID: 494
		[Token(Token = "0x40001EE")]
		[FieldOffset(Offset = "0x54")]
		public float _shadowDistance;

		// Token: 0x040001EF RID: 495
		[Token(Token = "0x40001EF")]
		[FieldOffset(Offset = "0x58")]
		[Header("Testing")]
		[Space(8f)]
		public bool _addRenderers;

		// Token: 0x040001F0 RID: 496
		[Token(Token = "0x40001F0")]
		[FieldOffset(Offset = "0x5C")]
		public int _renderesToAdd;

		// Token: 0x040001F1 RID: 497
		[Token(Token = "0x40001F1")]
		[FieldOffset(Offset = "0x60")]
		public bool _outputStats;

		// Token: 0x040001F2 RID: 498
		[Token(Token = "0x40001F2")]
		[FieldOffset(Offset = "0x68")]
		private NativeArray<SonsDrawRenderer> m_rendererbounds;

		// Token: 0x040001F3 RID: 499
		[Token(Token = "0x40001F3")]
		[FieldOffset(Offset = "0x78")]
		private Component[] _renderers;

		// Token: 0x040001F4 RID: 500
		[Token(Token = "0x40001F4")]
		[FieldOffset(Offset = "0x80")]
		private bool _hasBeenCreated;

		// Token: 0x040001F5 RID: 501
		[Token(Token = "0x40001F5")]
		[FieldOffset(Offset = "0x84")]
		private int _currentActiveInstances;

		// Token: 0x040001F6 RID: 502
		[Token(Token = "0x40001F6")]
		[FieldOffset(Offset = "0x88")]
		private int _LODCount;

		// Token: 0x040001F7 RID: 503
		[Token(Token = "0x40001F7")]
		[FieldOffset(Offset = "0x90")]
		private BatchRendererGroup m_BatchRendererGroup;

		// Token: 0x040001F8 RID: 504
		[Token(Token = "0x40001F8")]
		[FieldOffset(Offset = "0x98")]
		private GraphicsBuffer m_InstanceData;

		// Token: 0x040001F9 RID: 505
		[Token(Token = "0x40001F9")]
		[FieldOffset(Offset = "0xA0")]
		private BatchID m_BatchID;

		// Token: 0x040001FA RID: 506
		[Token(Token = "0x40001FA")]
		[FieldOffset(Offset = "0xA4")]
		private BatchMeshID m_MeshID;

		// Token: 0x040001FB RID: 507
		[Token(Token = "0x40001FB")]
		[FieldOffset(Offset = "0xA8")]
		private BatchID m_BatchIDLod;

		// Token: 0x040001FC RID: 508
		[Token(Token = "0x40001FC")]
		[FieldOffset(Offset = "0xAC")]
		private BatchMeshID m_MeshIDLod;

		// Token: 0x040001FD RID: 509
		[Token(Token = "0x40001FD")]
		[FieldOffset(Offset = "0xB0")]
		private BatchMaterialID m_MaterialID;

		// Token: 0x040001FE RID: 510
		[Token(Token = "0x40001FE")]
		[FieldOffset(Offset = "0xB4")]
		private BatchMaterialID m_MaterialAddID;

		// Token: 0x040001FF RID: 511
		[Token(Token = "0x40001FF")]
		[FieldOffset(Offset = "0xB8")]
		private NativeList<SonsDrawBatch> m_drawBatches;

		// Token: 0x04000200 RID: 512
		[Token(Token = "0x4000200")]
		[FieldOffset(Offset = "0xC8")]
		private NativeList<SonsDrawRange> m_drawRanges;

		// Token: 0x04000201 RID: 513
		[Token(Token = "0x4000201")]
		[FieldOffset(Offset = "0xD8")]
		private uint _byteAddressObjectToWorld;

		// Token: 0x04000202 RID: 514
		[Token(Token = "0x4000202")]
		[FieldOffset(Offset = "0xDC")]
		private uint _byteAddressWorldToObject;

		// Token: 0x04000203 RID: 515
		[Token(Token = "0x4000203")]
		[FieldOffset(Offset = "0xE0")]
		private uint _byteAddressSHCoefficients;

		// Token: 0x04000204 RID: 516
		[Token(Token = "0x4000204")]
		[FieldOffset(Offset = "0xE8")]
		private NativeArray<Vector4> _vectorBuffer;

		// Token: 0x04000205 RID: 517
		[Token(Token = "0x4000205")]
		private const int kSizeOfMatrix = 64;

		// Token: 0x04000206 RID: 518
		[Token(Token = "0x4000206")]
		private const int kSizeOfPackedMatrix = 48;

		// Token: 0x04000207 RID: 519
		[Token(Token = "0x4000207")]
		private const int kSizeOfFloat4 = 16;

		// Token: 0x04000208 RID: 520
		[Token(Token = "0x4000208")]
		private const int kBytesPerInstance = 224;

		// Token: 0x04000209 RID: 521
		[Token(Token = "0x4000209")]
		private const int kExtraBytes = 64;

		// Token: 0x0400020A RID: 522
		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0x0")]
		private static int s_objectToWorldID;

		// Token: 0x0400020B RID: 523
		[Token(Token = "0x400020B")]
		[FieldOffset(Offset = "0x4")]
		private static int s_worldToObjectID;

		// Token: 0x0400020C RID: 524
		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0x8")]
		private static int s_SHCoefficientsID;

		// Token: 0x02000047 RID: 71
		[Token(Token = "0x2000047")]
		[BurstCompile]
		private struct SortCommanOutputJob : IJob
		{
			// Token: 0x060000F9 RID: 249 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x5E9250", Offset = "0x5E7850", VA = "0x1805E9250", Slot = "4")]
			public void Execute()
			{
			}

			// Token: 0x0400020D RID: 525
			[Token(Token = "0x400020D")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public float3 sortDir;

			// Token: 0x0400020E RID: 526
			[Token(Token = "0x400020E")]
			[FieldOffset(Offset = "0xC")]
			[ReadOnly]
			public bool isLightCulling;

			// Token: 0x0400020F RID: 527
			[Token(Token = "0x400020F")]
			[FieldOffset(Offset = "0x10")]
			[ReadOnly]
			public float3 camPos;

			// Token: 0x04000210 RID: 528
			[Token(Token = "0x4000210")]
			[FieldOffset(Offset = "0x20")]
			[ReadOnly]
			public NativeArray<SonsDrawRenderer> renderers;

			// Token: 0x04000211 RID: 529
			[Token(Token = "0x4000211")]
			[FieldOffset(Offset = "0x30")]
			public NativeArray<BatchCullingOutputDrawCommands> drawCommands;

			// Token: 0x04000212 RID: 530
			[Token(Token = "0x4000212")]
			[FieldOffset(Offset = "0x40")]
			[ReadOnly]
			public int capacity;

			// Token: 0x02000048 RID: 72
			[Token(Token = "0x2000048")]
			private struct DistanceComparer : IComparer<int>
			{
				// Token: 0x060000FA RID: 250 RVA: 0x00002388 File Offset: 0x00000588
				[Token(Token = "0x60000FA")]
				[Address(RVA = "0x5E96D0", Offset = "0x5E7CD0", VA = "0x1805E96D0", Slot = "4")]
				public int Compare(int x, int y)
				{
					return 0;
				}

				// Token: 0x04000213 RID: 531
				[Token(Token = "0x4000213")]
				[FieldOffset(Offset = "0x0")]
				public NativeArray<float> Distances;
			}
		}

		// Token: 0x02000049 RID: 73
		[Token(Token = "0x2000049")]
		[BurstCompile]
		private struct CullingJob : IJobParallelFor
		{
			// Token: 0x060000FB RID: 251 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x5E9740", Offset = "0x5E7D40", VA = "0x1805E9740", Slot = "4")]
			public void Execute(int index)
			{
			}

			// Token: 0x04000214 RID: 532
			[Token(Token = "0x4000214")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeArray<Plane> shadowFrustumPlanes;

			// Token: 0x04000215 RID: 533
			[Token(Token = "0x4000215")]
			[FieldOffset(Offset = "0x10")]
			[DeallocateOnJobCompletion]
			[ReadOnly]
			public UnsafeList<float4> splitsSphereCentersRadii;

			// Token: 0x04000216 RID: 534
			[Token(Token = "0x4000216")]
			[FieldOffset(Offset = "0x30")]
			[ReadOnly]
			[DeallocateOnJobCompletion]
			public UnsafeList<float> cascadeBlendCullingFactors;

			// Token: 0x04000217 RID: 535
			[Token(Token = "0x4000217")]
			[FieldOffset(Offset = "0x50")]
			[ReadOnly]
			[DeallocateOnJobCompletion]
			public NativeArray<Unity.Rendering.FrustumPlanes.FrustumPlanes.PlanePacket4> planes;

			// Token: 0x04000218 RID: 536
			[Token(Token = "0x4000218")]
			[FieldOffset(Offset = "0x60")]
			[ReadOnly]
			[DeallocateOnJobCompletion]
			public NativeArray<Unity.Rendering.FrustumPlanes.FrustumPlanes.PlanePacket4> receiverPlanes;

			// Token: 0x04000219 RID: 537
			[Token(Token = "0x4000219")]
			[FieldOffset(Offset = "0x70")]
			[ReadOnly]
			public bool isLightCulling;

			// Token: 0x0400021A RID: 538
			[Token(Token = "0x400021A")]
			[FieldOffset(Offset = "0x78")]
			[ReadOnly]
			[DeallocateOnJobCompletion]
			public NativeArray<int> splitCounts;

			// Token: 0x0400021B RID: 539
			[Token(Token = "0x400021B")]
			[FieldOffset(Offset = "0x88")]
			[ReadOnly]
			public NativeArray<SonsDrawRenderer> renderers;

			// Token: 0x0400021C RID: 540
			[Token(Token = "0x400021C")]
			[FieldOffset(Offset = "0x98")]
			[WriteOnly]
			public NativeArray<ulong> rendererVisibilityLOD0;

			// Token: 0x0400021D RID: 541
			[Token(Token = "0x400021D")]
			[FieldOffset(Offset = "0xA8")]
			[WriteOnly]
			public NativeArray<ulong> rendererVisibilityLOD1;

			// Token: 0x0400021E RID: 542
			[Token(Token = "0x400021E")]
			[FieldOffset(Offset = "0xB8")]
			[ReadOnly]
			public float3 camPos;

			// Token: 0x0400021F RID: 543
			[Token(Token = "0x400021F")]
			[FieldOffset(Offset = "0xC4")]
			[ReadOnly]
			public int currentActiveInstances;

			// Token: 0x04000220 RID: 544
			[Token(Token = "0x4000220")]
			[FieldOffset(Offset = "0xC8")]
			[ReadOnly]
			public float LodDistanceSqr;

			// Token: 0x04000221 RID: 545
			[Token(Token = "0x4000221")]
			[FieldOffset(Offset = "0xCC")]
			[ReadOnly]
			public float3 LightAxisX;

			// Token: 0x04000222 RID: 546
			[Token(Token = "0x4000222")]
			[FieldOffset(Offset = "0xD8")]
			[ReadOnly]
			public float3 LightAxisY;

			// Token: 0x04000223 RID: 547
			[Token(Token = "0x4000223")]
			[FieldOffset(Offset = "0xE4")]
			[ReadOnly]
			public float3 LightAxisZ;

			// Token: 0x04000224 RID: 548
			[Token(Token = "0x4000224")]
			[FieldOffset(Offset = "0xF0")]
			[ReadOnly]
			[DeallocateOnJobCompletion]
			public UnsafeList<float4> ReceiverCenterX;

			// Token: 0x04000225 RID: 549
			[Token(Token = "0x4000225")]
			[FieldOffset(Offset = "0x110")]
			[DeallocateOnJobCompletion]
			[ReadOnly]
			public UnsafeList<float4> ReceiverCenterY;

			// Token: 0x04000226 RID: 550
			[Token(Token = "0x4000226")]
			[FieldOffset(Offset = "0x130")]
			[DeallocateOnJobCompletion]
			[ReadOnly]
			public UnsafeList<float4> ReceiverCenterZ;

			// Token: 0x04000227 RID: 551
			[Token(Token = "0x4000227")]
			[FieldOffset(Offset = "0x150")]
			[DeallocateOnJobCompletion]
			[ReadOnly]
			public UnsafeList<float4> ReceiverRadius;

			// Token: 0x04000228 RID: 552
			[Token(Token = "0x4000228")]
			[FieldOffset(Offset = "0x170")]
			[ReadOnly]
			public float CullDistanceSqr;

			// Token: 0x04000229 RID: 553
			[Token(Token = "0x4000229")]
			[FieldOffset(Offset = "0x174")]
			[ReadOnly]
			public float ShadowDistanceSqr;
		}

		// Token: 0x0200004A RID: 74
		[Token(Token = "0x200004A")]
		[BurstCompile]
		private struct DrawCommandOutputJob : IJob
		{
			// Token: 0x060000FC RID: 252 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000FC")]
			[Address(RVA = "0x5E9EC0", Offset = "0x5E84C0", VA = "0x1805E9EC0", Slot = "4")]
			public void Execute()
			{
			}

			// Token: 0x060000FD RID: 253 RVA: 0x000023A0 File Offset: 0x000005A0
			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x5EA650", Offset = "0x5E8C50", VA = "0x1805EA650")]
			private BatchCullingOutputDrawCommands CountAndAllocateDrawCommands()
			{
				return default(BatchCullingOutputDrawCommands);
			}

			// Token: 0x0400022A RID: 554
			[Token(Token = "0x400022A")]
			[FieldOffset(Offset = "0x0")]
			[DeallocateOnJobCompletion]
			[ReadOnly]
			public NativeArray<ulong> rendererVisibilityLOD0;

			// Token: 0x0400022B RID: 555
			[Token(Token = "0x400022B")]
			[FieldOffset(Offset = "0x10")]
			[ReadOnly]
			[DeallocateOnJobCompletion]
			public NativeArray<ulong> rendererVisibilityLOD1;

			// Token: 0x0400022C RID: 556
			[Token(Token = "0x400022C")]
			[FieldOffset(Offset = "0x20")]
			[ReadOnly]
			public NativeList<SonsDrawBatch> drawBatches;

			// Token: 0x0400022D RID: 557
			[Token(Token = "0x400022D")]
			[FieldOffset(Offset = "0x30")]
			public NativeArray<BatchCullingOutputDrawCommands> drawCommands;

			// Token: 0x0400022E RID: 558
			[Token(Token = "0x400022E")]
			[FieldOffset(Offset = "0x40")]
			[ReadOnly]
			public int currentActiveInstances;

			// Token: 0x0400022F RID: 559
			[Token(Token = "0x400022F")]
			[FieldOffset(Offset = "0x44")]
			[ReadOnly]
			public BatchID batchID_in;

			// Token: 0x04000230 RID: 560
			[Token(Token = "0x4000230")]
			[FieldOffset(Offset = "0x48")]
			[ReadOnly]
			public NativeList<SonsDrawRange> drawRanges;

			// Token: 0x04000231 RID: 561
			[Token(Token = "0x4000231")]
			[FieldOffset(Offset = "0x58")]
			[ReadOnly]
			public int capacity;

			// Token: 0x04000232 RID: 562
			[Token(Token = "0x4000232")]
			[FieldOffset(Offset = "0x5C")]
			[ReadOnly]
			public bool RenderOnlyLod1;

			// Token: 0x04000233 RID: 563
			[Token(Token = "0x4000233")]
			[FieldOffset(Offset = "0x60")]
			[ReadOnly]
			public float3 sortDir;

			// Token: 0x04000234 RID: 564
			[Token(Token = "0x4000234")]
			[FieldOffset(Offset = "0x70")]
			[ReadOnly]
			public NativeArray<SonsDrawRenderer> renderers;
		}
	}
}
