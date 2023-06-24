using System;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Rendering.FrustumPlanes;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x0200002D RID: 45
[Token(Token = "0x200002D")]
public class SimpleBRGa : MonoBehaviour
{
	// Token: 0x060000A2 RID: 162 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x60000A2")]
	public unsafe static T* Malloc<T>(int count) where T : struct
	{
		return null;
	}

	// Token: 0x060000A3 RID: 163 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x5DC430", Offset = "0x5DAA30", VA = "0x1805DC430")]
	private void OnEnable()
	{
	}

	// Token: 0x060000A4 RID: 164 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x5DCBF0", Offset = "0x5DB1F0", VA = "0x1805DCBF0")]
	private void GetAllRenderers()
	{
	}

	// Token: 0x060000A5 RID: 165 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x5DCD40", Offset = "0x5DB340", VA = "0x1805DCD40")]
	private void AllocateInstanceDateBuffer()
	{
	}

	// Token: 0x060000A6 RID: 166 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x5DCE20", Offset = "0x5DB420", VA = "0x1805DCE20")]
	private void AddRenderers()
	{
	}

	// Token: 0x060000A7 RID: 167 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x5DD530", Offset = "0x5DBB30", VA = "0x1805DD530")]
	private void Update()
	{
	}

	// Token: 0x060000A8 RID: 168 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x5DD7B0", Offset = "0x5DBDB0", VA = "0x1805DD7B0")]
	private void OnDisable()
	{
	}

	// Token: 0x060000A9 RID: 169 RVA: 0x000021D8 File Offset: 0x000003D8
	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x5DD8E0", Offset = "0x5DBEE0", VA = "0x1805DD8E0")]
	private int BufferCountForInstances(int bytesPerInstance, int numInstances, int extraBytes = 0)
	{
		return 0;
	}

	// Token: 0x060000AA RID: 170 RVA: 0x000021F0 File Offset: 0x000003F0
	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x5DD910", Offset = "0x5DBF10", VA = "0x1805DD910")]
	public JobHandle OnPerformCulling(BatchRendererGroup rendererGroup, BatchCullingContext cullingContext, BatchCullingOutput cullingOutput, IntPtr userContext)
	{
		return default(JobHandle);
	}

	// Token: 0x060000AB RID: 171 RVA: 0x00002208 File Offset: 0x00000408
	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x5DE2E0", Offset = "0x5DC8E0", VA = "0x1805DE2E0")]
	public JobHandle OnPerformCullingOld(BatchRendererGroup rendererGroup, BatchCullingContext cullingContext, BatchCullingOutput cullingOutput, IntPtr userContext)
	{
		return default(JobHandle);
	}

	// Token: 0x060000AC RID: 172 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x5DE810", Offset = "0x5DCE10", VA = "0x1805DE810")]
	public SimpleBRGa()
	{
	}

	// Token: 0x0400015C RID: 348
	[Token(Token = "0x400015C")]
	[FieldOffset(Offset = "0x20")]
	public Mesh mesh;

	// Token: 0x0400015D RID: 349
	[Token(Token = "0x400015D")]
	[FieldOffset(Offset = "0x28")]
	public Material material;

	// Token: 0x0400015E RID: 350
	[Token(Token = "0x400015E")]
	[FieldOffset(Offset = "0x30")]
	public int _capacity;

	// Token: 0x0400015F RID: 351
	[Token(Token = "0x400015F")]
	[FieldOffset(Offset = "0x34")]
	[Space(8f)]
	[Header("Testing")]
	public bool _addRenderers;

	// Token: 0x04000160 RID: 352
	[Token(Token = "0x4000160")]
	[FieldOffset(Offset = "0x38")]
	public int _renderesToAdd;

	// Token: 0x04000161 RID: 353
	[Token(Token = "0x4000161")]
	[FieldOffset(Offset = "0x3C")]
	public bool _outputStats;

	// Token: 0x04000162 RID: 354
	[Token(Token = "0x4000162")]
	[FieldOffset(Offset = "0x40")]
	private NativeArray<SonsDrawRenderer> m_rendererbounds;

	// Token: 0x04000163 RID: 355
	[Token(Token = "0x4000163")]
	[FieldOffset(Offset = "0x50")]
	private Component[] _renderers;

	// Token: 0x04000164 RID: 356
	[Token(Token = "0x4000164")]
	[FieldOffset(Offset = "0x58")]
	private bool _hasBeenCreated;

	// Token: 0x04000165 RID: 357
	[Token(Token = "0x4000165")]
	[FieldOffset(Offset = "0x5C")]
	private int _currentActiveInstances;

	// Token: 0x04000166 RID: 358
	[Token(Token = "0x4000166")]
	[FieldOffset(Offset = "0x60")]
	private BatchRendererGroup m_BatchRendererGroup;

	// Token: 0x04000167 RID: 359
	[Token(Token = "0x4000167")]
	[FieldOffset(Offset = "0x68")]
	private GraphicsBuffer m_InstanceData;

	// Token: 0x04000168 RID: 360
	[Token(Token = "0x4000168")]
	[FieldOffset(Offset = "0x70")]
	private BatchID m_BatchID;

	// Token: 0x04000169 RID: 361
	[Token(Token = "0x4000169")]
	[FieldOffset(Offset = "0x74")]
	private BatchMeshID m_MeshID;

	// Token: 0x0400016A RID: 362
	[Token(Token = "0x400016A")]
	[FieldOffset(Offset = "0x78")]
	private BatchMaterialID m_MaterialID;

	// Token: 0x0400016B RID: 363
	[Token(Token = "0x400016B")]
	[FieldOffset(Offset = "0x80")]
	private NativeList<SonsDrawBatch> m_drawBatches;

	// Token: 0x0400016C RID: 364
	[Token(Token = "0x400016C")]
	[FieldOffset(Offset = "0x90")]
	private NativeList<SonsDrawRange> m_drawRanges;

	// Token: 0x0400016D RID: 365
	[Token(Token = "0x400016D")]
	[FieldOffset(Offset = "0xA0")]
	private uint _byteAddressObjectToWorld;

	// Token: 0x0400016E RID: 366
	[Token(Token = "0x400016E")]
	[FieldOffset(Offset = "0xA4")]
	private uint _byteAddressWorldToObject;

	// Token: 0x0400016F RID: 367
	[Token(Token = "0x400016F")]
	[FieldOffset(Offset = "0xA8")]
	private NativeArray<Vector4> _vectorBuffer;

	// Token: 0x04000170 RID: 368
	[Token(Token = "0x4000170")]
	private const int kSizeOfMatrix = 64;

	// Token: 0x04000171 RID: 369
	[Token(Token = "0x4000171")]
	private const int kSizeOfPackedMatrix = 48;

	// Token: 0x04000172 RID: 370
	[Token(Token = "0x4000172")]
	private const int kSizeOfFloat4 = 16;

	// Token: 0x04000173 RID: 371
	[Token(Token = "0x4000173")]
	private const int kBytesPerInstance = 96;

	// Token: 0x04000174 RID: 372
	[Token(Token = "0x4000174")]
	private const int kExtraBytes = 64;

	// Token: 0x04000175 RID: 373
	[Token(Token = "0x4000175")]
	[FieldOffset(Offset = "0x0")]
	private static int s_objectToWorldID;

	// Token: 0x04000176 RID: 374
	[Token(Token = "0x4000176")]
	[FieldOffset(Offset = "0x4")]
	private static int s_worldToObjectID;

	// Token: 0x0200002E RID: 46
	[Token(Token = "0x200002E")]
	[BurstCompile]
	private struct CullingJob : IJobParallelFor
	{
		// Token: 0x060000AE RID: 174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x5DE950", Offset = "0x5DCF50", VA = "0x1805DE950", Slot = "4")]
		public void Execute(int index)
		{
		}

		// Token: 0x04000177 RID: 375
		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		[DeallocateOnJobCompletion]
		public NativeArray<Unity.Rendering.FrustumPlanes.FrustumPlanes.PlanePacket4> planes;

		// Token: 0x04000178 RID: 376
		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0x10")]
		[ReadOnly]
		[DeallocateOnJobCompletion]
		public NativeArray<int> splitCounts;

		// Token: 0x04000179 RID: 377
		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0x20")]
		[ReadOnly]
		public NativeArray<SonsDrawRenderer> renderers;

		// Token: 0x0400017A RID: 378
		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0x30")]
		[WriteOnly]
		public NativeArray<ulong> rendererVisibility;

		// Token: 0x0400017B RID: 379
		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0x40")]
		public int currentActiveInstances;
	}

	// Token: 0x0200002F RID: 47
	[Token(Token = "0x200002F")]
	[BurstCompile]
	private struct DrawCommandOutputJob : IJob
	{
		// Token: 0x060000AF RID: 175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x5DEA30", Offset = "0x5DD030", VA = "0x1805DEA30", Slot = "4")]
		public void Execute()
		{
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00002220 File Offset: 0x00000420
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x5DEF40", Offset = "0x5DD540", VA = "0x1805DEF40")]
		private BatchCullingOutputDrawCommands CountAndAllocateDrawCommands()
		{
			return default(BatchCullingOutputDrawCommands);
		}

		// Token: 0x0400017C RID: 380
		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0x0")]
		[DeallocateOnJobCompletion]
		[ReadOnly]
		public NativeArray<ulong> rendererVisibility;

		// Token: 0x0400017D RID: 381
		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0x10")]
		[ReadOnly]
		public NativeList<SonsDrawBatch> drawBatches;

		// Token: 0x0400017E RID: 382
		[Token(Token = "0x400017E")]
		[FieldOffset(Offset = "0x20")]
		public NativeArray<BatchCullingOutputDrawCommands> drawCommands;

		// Token: 0x0400017F RID: 383
		[Token(Token = "0x400017F")]
		[FieldOffset(Offset = "0x30")]
		public int currentActiveInstances;

		// Token: 0x04000180 RID: 384
		[Token(Token = "0x4000180")]
		[FieldOffset(Offset = "0x34")]
		public BatchID batchID_in;

		// Token: 0x04000181 RID: 385
		[Token(Token = "0x4000181")]
		[FieldOffset(Offset = "0x38")]
		[ReadOnly]
		public NativeList<SonsDrawRange> drawRanges;
	}
}
