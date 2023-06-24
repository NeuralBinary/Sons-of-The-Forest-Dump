using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace MTAssets.EasyMeshCombiner
{
	// Token: 0x0200007D RID: 125
	[Token(Token = "0x200007D")]
	[AddComponentMenu("MT Assets/Easy Mesh Combiner/Runtime Mesh Combiner")]
	public class RuntimeMeshCombiner : MonoBehaviour
	{
		// Token: 0x06000262 RID: 610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000262")]
		[Address(RVA = "0x60E8E0", Offset = "0x60CEE0", VA = "0x18060E8E0")]
		private void Awake()
		{
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000263")]
		[Address(RVA = "0x60E9E0", Offset = "0x60CFE0", VA = "0x18060E9E0")]
		private void Start()
		{
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x6000264")]
		[Address(RVA = "0x60EAE0", Offset = "0x60D0E0", VA = "0x18060EAE0")]
		private RuntimeMeshCombiner.GameObjectWithMesh[] GetValidatedTargetGameObjects()
		{
			return null;
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00002BC8 File Offset: 0x00000DC8
		[Token(Token = "0x6000265")]
		[Address(RVA = "0x60FD10", Offset = "0x60E310", VA = "0x18060FD10")]
		public bool CombineMeshes()
		{
			return default(bool);
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00002BE0 File Offset: 0x00000DE0
		[Token(Token = "0x6000266")]
		[Address(RVA = "0x6116D0", Offset = "0x60FCD0", VA = "0x1806116D0")]
		public bool UndoMerge()
		{
			return default(bool);
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00002BF8 File Offset: 0x00000DF8
		[Token(Token = "0x6000267")]
		[Address(RVA = "0x5F2120", Offset = "0x5F0720", VA = "0x1805F2120")]
		public bool isTargetMeshesMerged()
		{
			return default(bool);
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000268")]
		[Address(RVA = "0x611E50", Offset = "0x610450", VA = "0x180611E50")]
		public RuntimeMeshCombiner()
		{
		}

		// Token: 0x04000337 RID: 823
		[Token(Token = "0x4000337")]
		[FieldOffset(Offset = "0x20")]
		private int MAX_VERTICES_FOR_16BITS_MESH;

		// Token: 0x04000338 RID: 824
		[Token(Token = "0x4000338")]
		[FieldOffset(Offset = "0x24")]
		private Vector3 originalPosition;

		// Token: 0x04000339 RID: 825
		[Token(Token = "0x4000339")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 originalEulerAngles;

		// Token: 0x0400033A RID: 826
		[Token(Token = "0x400033A")]
		[FieldOffset(Offset = "0x3C")]
		private Vector3 originalScale;

		// Token: 0x0400033B RID: 827
		[Token(Token = "0x400033B")]
		[FieldOffset(Offset = "0x48")]
		private List<RuntimeMeshCombiner.OriginalGameObjectWithMesh> originalGameObjectsWithMeshToRestore;

		// Token: 0x0400033C RID: 828
		[Token(Token = "0x400033C")]
		[FieldOffset(Offset = "0x50")]
		private bool targetMeshesMerged;

		// Token: 0x0400033D RID: 829
		[Token(Token = "0x400033D")]
		[FieldOffset(Offset = "0x54")]
		[HideInInspector]
		public RuntimeMeshCombiner.AfterMerge afterMerge;

		// Token: 0x0400033E RID: 830
		[Token(Token = "0x400033E")]
		[FieldOffset(Offset = "0x58")]
		[HideInInspector]
		public bool addMeshColliderAfter;

		// Token: 0x0400033F RID: 831
		[Token(Token = "0x400033F")]
		[FieldOffset(Offset = "0x5C")]
		[HideInInspector]
		public RuntimeMeshCombiner.CombineOnStart combineMeshesAtStartUp;

		// Token: 0x04000340 RID: 832
		[Token(Token = "0x4000340")]
		[FieldOffset(Offset = "0x60")]
		[HideInInspector]
		public bool combineInChildren;

		// Token: 0x04000341 RID: 833
		[Token(Token = "0x4000341")]
		[FieldOffset(Offset = "0x61")]
		[HideInInspector]
		public bool combineInactives;

		// Token: 0x04000342 RID: 834
		[Token(Token = "0x4000342")]
		[FieldOffset(Offset = "0x62")]
		[HideInInspector]
		public bool recalculateNormals;

		// Token: 0x04000343 RID: 835
		[Token(Token = "0x4000343")]
		[FieldOffset(Offset = "0x63")]
		[HideInInspector]
		public bool recalculateTangents;

		// Token: 0x04000344 RID: 836
		[Token(Token = "0x4000344")]
		[FieldOffset(Offset = "0x64")]
		[HideInInspector]
		public bool optimizeResultingMesh;

		// Token: 0x04000345 RID: 837
		[Token(Token = "0x4000345")]
		[FieldOffset(Offset = "0x68")]
		[HideInInspector]
		public List<GameObject> targetMeshes;

		// Token: 0x04000346 RID: 838
		[Token(Token = "0x4000346")]
		[FieldOffset(Offset = "0x70")]
		[HideInInspector]
		public bool showDebugLogs;

		// Token: 0x04000347 RID: 839
		[Token(Token = "0x4000347")]
		[FieldOffset(Offset = "0x71")]
		[HideInInspector]
		public bool garbageCollectorAfterUndo;

		// Token: 0x04000348 RID: 840
		[Token(Token = "0x4000348")]
		[FieldOffset(Offset = "0x78")]
		public UnityEvent onDoneMerge;

		// Token: 0x04000349 RID: 841
		[Token(Token = "0x4000349")]
		[FieldOffset(Offset = "0x80")]
		public UnityEvent onDoneUnmerge;

		// Token: 0x0200007E RID: 126
		[Token(Token = "0x200007E")]
		private class GameObjectWithMesh
		{
			// Token: 0x06000269 RID: 617 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000269")]
			[Address(RVA = "0x612090", Offset = "0x610690", VA = "0x180612090")]
			public GameObjectWithMesh(GameObject gameObject, MeshFilter meshFilter, MeshRenderer meshRenderer)
			{
			}

			// Token: 0x0400034A RID: 842
			[Token(Token = "0x400034A")]
			[FieldOffset(Offset = "0x10")]
			public GameObject gameObject;

			// Token: 0x0400034B RID: 843
			[Token(Token = "0x400034B")]
			[FieldOffset(Offset = "0x18")]
			public MeshFilter meshFilter;

			// Token: 0x0400034C RID: 844
			[Token(Token = "0x400034C")]
			[FieldOffset(Offset = "0x20")]
			public MeshRenderer meshRenderer;
		}

		// Token: 0x0200007F RID: 127
		[Token(Token = "0x200007F")]
		private class OriginalGameObjectWithMesh
		{
			// Token: 0x0600026A RID: 618 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600026A")]
			[Address(RVA = "0x6121B0", Offset = "0x6107B0", VA = "0x1806121B0")]
			public OriginalGameObjectWithMesh(GameObject gameObject, bool originalGoState, MeshRenderer meshRenderer, bool originalMrState)
			{
			}

			// Token: 0x0400034D RID: 845
			[Token(Token = "0x400034D")]
			[FieldOffset(Offset = "0x10")]
			public GameObject gameObject;

			// Token: 0x0400034E RID: 846
			[Token(Token = "0x400034E")]
			[FieldOffset(Offset = "0x18")]
			public bool originalGoState;

			// Token: 0x0400034F RID: 847
			[Token(Token = "0x400034F")]
			[FieldOffset(Offset = "0x20")]
			public MeshRenderer meshRenderer;

			// Token: 0x04000350 RID: 848
			[Token(Token = "0x4000350")]
			[FieldOffset(Offset = "0x28")]
			public bool originalMrState;
		}

		// Token: 0x02000080 RID: 128
		[Token(Token = "0x2000080")]
		private class SubMeshToCombine
		{
			// Token: 0x0600026B RID: 619 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600026B")]
			[Address(RVA = "0x612270", Offset = "0x610870", VA = "0x180612270")]
			public SubMeshToCombine(Transform transform, MeshFilter meshFilter, MeshRenderer meshRenderer, int subMeshIndex)
			{
			}

			// Token: 0x04000351 RID: 849
			[Token(Token = "0x4000351")]
			[FieldOffset(Offset = "0x10")]
			public Transform transform;

			// Token: 0x04000352 RID: 850
			[Token(Token = "0x4000352")]
			[FieldOffset(Offset = "0x18")]
			public MeshFilter meshFilter;

			// Token: 0x04000353 RID: 851
			[Token(Token = "0x4000353")]
			[FieldOffset(Offset = "0x20")]
			public MeshRenderer meshRenderer;

			// Token: 0x04000354 RID: 852
			[Token(Token = "0x4000354")]
			[FieldOffset(Offset = "0x28")]
			public int subMeshIndex;
		}

		// Token: 0x02000081 RID: 129
		[Token(Token = "0x2000081")]
		public enum CombineOnStart
		{
			// Token: 0x04000356 RID: 854
			[Token(Token = "0x4000356")]
			Disabled,
			// Token: 0x04000357 RID: 855
			[Token(Token = "0x4000357")]
			OnStart,
			// Token: 0x04000358 RID: 856
			[Token(Token = "0x4000358")]
			OnAwake
		}

		// Token: 0x02000082 RID: 130
		[Token(Token = "0x2000082")]
		public enum AfterMerge
		{
			// Token: 0x0400035A RID: 858
			[Token(Token = "0x400035A")]
			DisableOriginalMeshes,
			// Token: 0x0400035B RID: 859
			[Token(Token = "0x400035B")]
			DeactiveOriginalGameObjects,
			// Token: 0x0400035C RID: 860
			[Token(Token = "0x400035C")]
			DoNothing
		}
	}
}
