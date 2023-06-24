using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Rendering;

namespace Crest
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	public abstract class QueryBase
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000021 RID: 33
		[Token(Token = "0x17000001")]
		protected abstract string QueryShaderName { [Token(Token = "0x6000021")] get; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000022 RID: 34
		[Token(Token = "0x17000002")]
		protected abstract string QueryKernelName { [Token(Token = "0x6000022")] get; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000023 RID: 35 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x17000003")]
		protected virtual ComputeShader ShaderProcessQueries
		{
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x9C7150", Offset = "0x9C5750", VA = "0x1809C7150")]
		public QueryBase()
		{
		}

		// Token: 0x06000025 RID: 37
		[Token(Token = "0x6000025")]
		protected abstract void BindInputsAndOutputs(PropertyWrapperComputeStandalone wrapper, ComputeBuffer resultsBuffer);

		// Token: 0x06000026 RID: 38 RVA: 0x000020E8 File Offset: 0x000002E8
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x9C7A40", Offset = "0x9C6040", VA = "0x1809C7A40")]
		protected bool UpdateQueryPoints(int i_ownerHash, float i_minSpatialLength, Vector3[] queryPoints, Vector3[] queryNormals)
		{
			return default(bool);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x9C8240", Offset = "0x9C6840", VA = "0x1809C8240")]
		public void RemoveQueryPoints(int guid)
		{
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x9C8360", Offset = "0x9C6960", VA = "0x1809C8360")]
		public void CompactQueryStorage()
		{
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002100 File Offset: 0x00000300
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x9C8490", Offset = "0x9C6A90", VA = "0x1809C8490")]
		protected bool RetrieveResults(int guid, Vector3[] displacements, float[] heights, Vector3[] normals)
		{
			return default(bool);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002118 File Offset: 0x00000318
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x9C8A60", Offset = "0x9C7060", VA = "0x1809C8A60")]
		protected int CalculateVelocities(int i_ownerHash, Vector3[] results)
		{
			return 0;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x9C8C90", Offset = "0x9C7290", VA = "0x1809C8C90", Slot = "8")]
		public void UpdateQueries()
		{
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x9C91F0", Offset = "0x9C77F0", VA = "0x1809C91F0")]
		private void ExecuteQueries()
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x9C9360", Offset = "0x9C7960", VA = "0x1809C9360")]
		private void DataArrived(AsyncGPUReadbackRequest req)
		{
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x9C9A10", Offset = "0x9C8010", VA = "0x1809C9A10", Slot = "9")]
		public void CleanUp()
		{
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002130 File Offset: 0x00000330
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x9C9BC0", Offset = "0x9C81C0", VA = "0x1809C9BC0", Slot = "10")]
		public int Query(int i_ownerHash, float i_minSpatialLength, Vector3[] i_queryPoints, Vector3[] o_resultDisps, Vector3[] o_resultNorms, Vector3[] o_resultVels)
		{
			return 0;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002148 File Offset: 0x00000348
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x9C9C80", Offset = "0x9C8280", VA = "0x1809C9C80", Slot = "11")]
		public bool RetrieveSucceeded(int queryStatus)
		{
			return default(bool);
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00002160 File Offset: 0x00000360
		[Token(Token = "0x17000004")]
		public int ResultGuidCount
		{
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x9C9C90", Offset = "0x9C8290", VA = "0x1809C9C90")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00002178 File Offset: 0x00000378
		[Token(Token = "0x17000005")]
		public int RequestCount
		{
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x9C9CE0", Offset = "0x9C82E0", VA = "0x1809C9CE0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x10")]
		protected int _kernelHandle;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		private const int s_maxRequests = 7;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		private const int s_maxGuids = 1024;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x18")]
		private ComputeShader _shaderProcessQueries;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x20")]
		private PropertyWrapperComputeStandalone _wrapper;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x28")]
		private Action<AsyncGPUReadbackRequest> _dataArrivedAction;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		private const int s_computeGroupSize = 64;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x0")]
		public static bool s_useComputeCollQueries;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x30")]
		private readonly int sp_queryPositions_minGridSizes;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		private const float s_finiteDiffDx = 0.1f;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x38")]
		private ComputeBuffer _computeBufQueries;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x40")]
		private ComputeBuffer _computeBufResults;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		public const int MAX_QUERY_COUNT_DEFAULT = 4096;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x48")]
		private int _maxQueryCount;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x50")]
		private Vector3[] _queryPosXZ_minGridSize;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x58")]
		private QueryBase.SegmentRegistrarRingBuffer _segmentRegistrarRingBuffer;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x60")]
		private NativeArray<Vector3> _queryResults;

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x70")]
		private float _queryResultsTime;

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x78")]
		private Dictionary<int, Vector3Int> _resultSegments;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x80")]
		private NativeArray<Vector3> _queryResultsLast;

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x90")]
		private float _queryResultsTimeLast;

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x98")]
		private Dictionary<int, Vector3Int> _resultSegmentsLast;

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0xA0")]
		private List<QueryBase.ReadbackRequest> _requests;

		// Token: 0x0200000C RID: 12
		[Token(Token = "0x200000C")]
		private class SegmentRegistrar
		{
			// Token: 0x06000034 RID: 52 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x9C9D60", Offset = "0x9C8360", VA = "0x1809C9D60")]
			public SegmentRegistrar()
			{
			}

			// Token: 0x04000023 RID: 35
			[Token(Token = "0x4000023")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<int, Vector3Int> _segments;

			// Token: 0x04000024 RID: 36
			[Token(Token = "0x4000024")]
			[FieldOffset(Offset = "0x18")]
			public int _numQueries;
		}

		// Token: 0x0200000D RID: 13
		[Token(Token = "0x200000D")]
		private class SegmentRegistrarRingBuffer
		{
			// Token: 0x17000006 RID: 6
			// (get) Token: 0x06000035 RID: 53 RVA: 0x000020E2 File Offset: 0x000002E2
			[Token(Token = "0x17000006")]
			public QueryBase.SegmentRegistrar Current
			{
				[Token(Token = "0x6000035")]
				[Address(RVA = "0x9C9E90", Offset = "0x9C8490", VA = "0x1809C9E90")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000036 RID: 54 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x9C9EC0", Offset = "0x9C84C0", VA = "0x1809C9EC0")]
			public SegmentRegistrarRingBuffer()
			{
			}

			// Token: 0x06000037 RID: 55 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x9CA220", Offset = "0x9C8820", VA = "0x1809CA220")]
			public void AcquireNew()
			{
			}

			// Token: 0x06000038 RID: 56 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x9CA620", Offset = "0x9C8C20", VA = "0x1809CA620")]
			public void ReleaseLast()
			{
			}

			// Token: 0x06000039 RID: 57 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x9CA650", Offset = "0x9C8C50", VA = "0x1809CA650")]
			public void RemoveRegistrations(int key)
			{
			}

			// Token: 0x0600003A RID: 58 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x9CA770", Offset = "0x9C8D70", VA = "0x1809CA770")]
			public void ClearAvailable()
			{
			}

			// Token: 0x0600003B RID: 59 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x9CA890", Offset = "0x9C8E90", VA = "0x1809CA890")]
			public void ClearAll()
			{
			}

			// Token: 0x04000025 RID: 37
			[Token(Token = "0x4000025")]
			[FieldOffset(Offset = "0x0")]
			private static readonly int s_poolSize;

			// Token: 0x04000026 RID: 38
			[Token(Token = "0x4000026")]
			[FieldOffset(Offset = "0x10")]
			private QueryBase.SegmentRegistrar[] _segments;

			// Token: 0x04000027 RID: 39
			[Token(Token = "0x4000027")]
			[FieldOffset(Offset = "0x18")]
			public int _segmentRelease;

			// Token: 0x04000028 RID: 40
			[Token(Token = "0x4000028")]
			[FieldOffset(Offset = "0x1C")]
			public int _segmentAcquire;
		}

		// Token: 0x0200000E RID: 14
		[Token(Token = "0x200000E")]
		private struct ReadbackRequest
		{
			// Token: 0x04000029 RID: 41
			[Token(Token = "0x4000029")]
			[FieldOffset(Offset = "0x0")]
			public AsyncGPUReadbackRequest _request;

			// Token: 0x0400002A RID: 42
			[Token(Token = "0x400002A")]
			[FieldOffset(Offset = "0x10")]
			public float _dataTimestamp;

			// Token: 0x0400002B RID: 43
			[Token(Token = "0x400002B")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<int, Vector3Int> _segments;
		}

		// Token: 0x0200000F RID: 15
		[Token(Token = "0x200000F")]
		public enum QueryStatus
		{
			// Token: 0x0400002D RID: 45
			[Token(Token = "0x400002D")]
			OK,
			// Token: 0x0400002E RID: 46
			[Token(Token = "0x400002E")]
			RetrieveFailed,
			// Token: 0x0400002F RID: 47
			[Token(Token = "0x400002F")]
			PostFailed,
			// Token: 0x04000030 RID: 48
			[Token(Token = "0x4000030")]
			NotEnoughDataForVels = 4,
			// Token: 0x04000031 RID: 49
			[Token(Token = "0x4000031")]
			VelocityDataInvalidated = 8,
			// Token: 0x04000032 RID: 50
			[Token(Token = "0x4000032")]
			InvalidDtForVelocity = 16
		}
	}
}
