using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Collections;
using UnityEngine;

namespace MudBun
{
	// Token: 0x02000068 RID: 104
	[Token(Token = "0x2000068")]
	[ExecuteInEditMode]
	public class MudRenderer : MudRendererBase
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x060002D9 RID: 729 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060002DA RID: 730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000001")]
		public static event MudRenderer.MeshGenerated OnMeshGenerated
		{
			[Token(Token = "0x60002D9")]
			[Address(RVA = "0x23F3A10", Offset = "0x23F2010", VA = "0x1823F3A10")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60002DA")]
			[Address(RVA = "0x23F3B20", Offset = "0x23F2120", VA = "0x1823F3B20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x23F3C30", Offset = "0x23F2230", VA = "0x1823F3C30", Slot = "4")]
		public override void InvokeOnMeshGenerated(Mesh mesh)
		{
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x23F3C90", Offset = "0x23F2290", VA = "0x1823F3C90", Slot = "14")]
		protected override void OnSharedMaterialChanged(UnityEngine.Object material)
		{
		}

		// Token: 0x060002DD RID: 733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x23DB330", Offset = "0x23D9930", VA = "0x1823DB330", Slot = "19")]
		protected override void OnValidate()
		{
		}

		// Token: 0x060002DE RID: 734 RVA: 0x000037F8 File Offset: 0x000019F8
		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x16165F0", Offset = "0x1614BF0", VA = "0x1816165F0", Slot = "21")]
		protected override bool PreUpdateValidate()
		{
			return default(bool);
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x23E62C0", Offset = "0x23E48C0", VA = "0x1823E62C0", Slot = "24")]
		public override void NotifyHierarchyChange()
		{
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002E0")]
		private T AddComponentHelper<T>(GameObject go) where T : Component
		{
			return null;
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E1")]
		private void RemoveComponentHelper<T>(GameObject go) where T : Component
		{
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x23F4260", Offset = "0x23F2860", VA = "0x1823F4260", Slot = "8")]
		public override Mesh AddCollider(GameObject go, bool async, [Optional] Mesh mesh, bool forceConvexCollider = false, bool makeRigidBody = false)
		{
			return null;
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x23F43D0", Offset = "0x23F29D0", VA = "0x1823F43D0", Slot = "9")]
		public override Mesh AddLockedStandardMesh(GameObject go, bool autoRigging, bool async, [Optional] Mesh mesh, bool generateTextureUV = false, bool generateLightMapUV = false, bool weldVertices = false, bool optimizeMeshForRendering = false)
		{
			return null;
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060002E4 RID: 740 RVA: 0x00003810 File Offset: 0x00001A10
		[Token(Token = "0x1700006E")]
		protected override MudRendererBase.LockMeshIntermediateStateEnum LockMeshIntermediateState
		{
			[Token(Token = "0x60002E4")]
			[Address(RVA = "0x23F4A50", Offset = "0x23F3050", VA = "0x1823F4A50", Slot = "7")]
			get
			{
				return MudRendererBase.LockMeshIntermediateStateEnum.Idle;
			}
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x23F4A60", Offset = "0x23F3060", VA = "0x1823F4A60", Slot = "10")]
		public override void LockMesh(bool autoRigging, bool async, [Optional] Mesh mesh, bool generateTextureUV = false, bool generateLightMapUV = false, bool weldVertices = false, bool optimizeMeshForRendering = false)
		{
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x23F4B90", Offset = "0x23F3190", VA = "0x1823F4B90", Slot = "11")]
		public override void UnlockMesh()
		{
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00003828 File Offset: 0x00001A28
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "6")]
		protected override bool GenerateUV(Mesh mesh, bool generateTextureUV, bool generateLightMapUV)
		{
			return default(bool);
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x23F4F00", Offset = "0x23F3500", VA = "0x1823F4F00")]
		private static void InitSyncJobData()
		{
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x23F5160", Offset = "0x23F3760", VA = "0x1823F5160")]
		private static void DisposeSyncJobData()
		{
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x23F5230", Offset = "0x23F3830", VA = "0x1823F5230", Slot = "12")]
		public override void GenerateSdf(RenderTexture sdf, Vector3 origin, Vector3 dimension)
		{
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x23F5280", Offset = "0x23F3880", VA = "0x1823F5280", Slot = "13")]
		public override void GenerateSdf(Texture3D sdf, Vector3 origin, Vector3 dimension)
		{
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00003840 File Offset: 0x00001A40
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x23F52D0", Offset = "0x23F38D0", VA = "0x1823F52D0")]
		public Sdf.Result EvaluateSdf(Vector3 p, float maxSurfaceDistance, bool computeMaterials)
		{
			return default(Sdf.Result);
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00003858 File Offset: 0x00001A58
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x23F5630", Offset = "0x23F3C30", VA = "0x1823F5630")]
		public Sdf.EvalJobHandle EvaluateSdfAsync(NativeArray<Vector3> samples, NativeArray<Sdf.Result> results, float maxSurfaceDistance, bool computeMaterials)
		{
			return default(Sdf.EvalJobHandle);
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00003870 File Offset: 0x00001A70
		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x23F5880", Offset = "0x23F3E80", VA = "0x1823F5880")]
		public Sdf.Result EvaluateNormal(Vector3 p, float maxSurfaceDistance)
		{
			return default(Sdf.Result);
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00003888 File Offset: 0x00001A88
		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x23F5BE0", Offset = "0x23F41E0", VA = "0x1823F5BE0")]
		public Sdf.EvalJobHandle EvaluateNormalAsync(NativeArray<Vector3> samples, NativeArray<Sdf.Result> results, float maxSurfaceDistance)
		{
			return default(Sdf.EvalJobHandle);
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x000038A0 File Offset: 0x00001AA0
		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x23F5E30", Offset = "0x23F4430", VA = "0x1823F5E30")]
		public Sdf.Result EvaluateSdfAndNormal(Vector3 p, float maxSurfaceDistance, bool computeMaterials)
		{
			return default(Sdf.Result);
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x000038B8 File Offset: 0x00001AB8
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x23F61A0", Offset = "0x23F47A0", VA = "0x1823F61A0")]
		public Sdf.EvalJobHandle EvaluateSdfAndNormalAsync(NativeArray<Vector3> samples, NativeArray<Sdf.Result> results, float maxSurfaceDistance, bool computeMaterials)
		{
			return default(Sdf.EvalJobHandle);
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x000038D0 File Offset: 0x00001AD0
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x23F6400", Offset = "0x23F4A00", VA = "0x1823F6400")]
		public Sdf.Contact Raycast(Vector3 from, Vector3 direction, float maxDistance, bool computeMaterials, int maxSteps = 128, float margin = 0.01f, bool forceZeroBlendUnion = false)
		{
			return default(Sdf.Contact);
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x000038E8 File Offset: 0x00001AE8
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x23F66F0", Offset = "0x23F4CF0", VA = "0x1823F66F0")]
		public Sdf.EvalJobHandle RaycastAsync(NativeArray<Sdf.Ray> casts, NativeArray<Sdf.Contact> results, bool computeMaterials, int maxSteps = 128, float margin = 0.01f, bool forceZeroBlendUnion = false)
		{
			return default(Sdf.EvalJobHandle);
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00003900 File Offset: 0x00001B00
		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x23F6950", Offset = "0x23F4F50", VA = "0x1823F6950")]
		public Sdf.Contact RaycastChain(NativeArray<Vector3> chain, bool computeMaterials, int maxSteps = 512, float margin = 0.01f)
		{
			return default(Sdf.Contact);
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00003918 File Offset: 0x00001B18
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x23F6BB0", Offset = "0x23F51B0", VA = "0x1823F6BB0")]
		public Sdf.EvalJobHandle RaycastChainAsync(NativeArray<Vector3> chain, NativeArray<Sdf.Contact> result, bool computeMaterials, int maxSteps = 128, float margin = 0.01f)
		{
			return default(Sdf.EvalJobHandle);
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00003930 File Offset: 0x00001B30
		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x23F6E00", Offset = "0x23F5400", VA = "0x1823F6E00")]
		public Sdf.Contact SnapToSurface(Vector3 p, float maxSurfaceDistance, bool computeMaterials, int maxSteps = 128, float margin = 0.01f)
		{
			return default(Sdf.Contact);
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00003948 File Offset: 0x00001B48
		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x23F7240", Offset = "0x23F5840", VA = "0x1823F7240")]
		public Sdf.EvalJobHandle SnapToSurfaceAsync(NativeArray<Vector3> samples, NativeArray<Sdf.Contact> results, float maxSurfaceDistance, bool computeMaterials, int maxSteps = 128, float margin = 0.01f)
		{
			return default(Sdf.EvalJobHandle);
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00003960 File Offset: 0x00001B60
		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x23F74B0", Offset = "0x23F5AB0", VA = "0x1823F74B0")]
		public static Sdf.Contact Raycast(Vector3 from, Vector3 direction, float maxDistance)
		{
			return default(Sdf.Contact);
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00003978 File Offset: 0x00001B78
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x23F7860", Offset = "0x23F5E60", VA = "0x1823F7860")]
		internal static Sdf.Contact RaycastClickSelection(Vector3 from, Vector3 direction, float maxDistance)
		{
			return default(Sdf.Contact);
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x23F7C20", Offset = "0x23F6220", VA = "0x1823F7C20", Slot = "15")]
		protected override void InitBeforeFirstRenderer()
		{
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x23F7CA0", Offset = "0x23F62A0", VA = "0x1823F7CA0", Slot = "16")]
		protected override void CleanUpAfterLastRenderer()
		{
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x23F8040", Offset = "0x23F6640", VA = "0x1823F8040", Slot = "17")]
		protected override void OnEnable()
		{
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x23F8050", Offset = "0x23F6650", VA = "0x1823F8050", Slot = "18")]
		protected override void OnDisable()
		{
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x23F8060", Offset = "0x23F6660", VA = "0x1823F8060")]
		public MudRenderer()
		{
		}

		// Token: 0x040000EF RID: 239
		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x438")]
		private MudRendererBase.LockMeshIntermediateStateEnum m_lockMeshIntermediateState;

		// Token: 0x040000F0 RID: 240
		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x440")]
		[HideInInspector]
		[SerializeField]
		private List<string> m_addedComponents;

		// Token: 0x040000F1 RID: 241
		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static NativeArray<Vector3> s_aSingleSampleSync;

		// Token: 0x040000F2 RID: 242
		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static NativeArray<Sdf.Ray> s_aSingleRaySync;

		// Token: 0x040000F3 RID: 243
		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static NativeArray<Sdf.Result> s_aSingleResultSync;

		// Token: 0x040000F4 RID: 244
		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static NativeArray<Sdf.Contact> s_aSingleContactSync;

		// Token: 0x02000069 RID: 105
		// (Invoke) Token: 0x06000300 RID: 768
		[Token(Token = "0x2000069")]
		public delegate void MeshGenerated(Mesh mesh);
	}
}
