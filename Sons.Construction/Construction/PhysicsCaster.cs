using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Construction.Branching;
using UnityEngine;

namespace Construction
{
	// Token: 0x020000C6 RID: 198
	[Token(Token = "0x20000C6")]
	[Serializable]
	public class PhysicsCaster : IAimRayProvider
	{
		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000598 RID: 1432 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000599 RID: 1433 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001CB")]
		public ConstructionManager Manager
		{
			[Token(Token = "0x6000598")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000599")]
			[Address(RVA = "0x5B2560", Offset = "0x5B0B60", VA = "0x1805B2560")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x0600059A RID: 1434 RVA: 0x0000455C File Offset: 0x0000275C
		// (set) Token: 0x0600059B RID: 1435 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001CC")]
		public int HitCount
		{
			[Token(Token = "0x600059A")]
			[Address(RVA = "0x784B40", Offset = "0x783140", VA = "0x180784B40")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600059B")]
			[Address(RVA = "0x8F80C0", Offset = "0x8F66C0", VA = "0x1808F80C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x0600059C RID: 1436 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170001CD")]
		public Collider[] OverlapResults
		{
			[Token(Token = "0x600059C")]
			[Address(RVA = "0x661070", Offset = "0x65F670", VA = "0x180661070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x0600059D RID: 1437 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170001CE")]
		public RaycastHit[] CastResults
		{
			[Token(Token = "0x600059D")]
			[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x0600059E RID: 1438 RVA: 0x00004574 File Offset: 0x00002774
		[Token(Token = "0x170001CF")]
		public Vector3 CastOrigin
		{
			[Token(Token = "0x600059E")]
			[Address(RVA = "0x2E1F270", Offset = "0x2E1D870", VA = "0x182E1F270")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x0600059F RID: 1439 RVA: 0x0000458C File Offset: 0x0000278C
		[Token(Token = "0x170001D0")]
		public Vector3 CastForward
		{
			[Token(Token = "0x600059F")]
			[Address(RVA = "0x2E1F2A0", Offset = "0x2E1D8A0", VA = "0x182E1F2A0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060005A0 RID: 1440 RVA: 0x000045A4 File Offset: 0x000027A4
		[Token(Token = "0x170001D1")]
		public Vector3 CastRight
		{
			[Token(Token = "0x60005A0")]
			[Address(RVA = "0x2E1F310", Offset = "0x2E1D910", VA = "0x182E1F310")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x060005A1 RID: 1441 RVA: 0x000045BC File Offset: 0x000027BC
		[Token(Token = "0x170001D2")]
		public Vector3 CastUp
		{
			[Token(Token = "0x60005A1")]
			[Address(RVA = "0x2E1F380", Offset = "0x2E1D980", VA = "0x182E1F380")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x060005A2 RID: 1442 RVA: 0x000045D4 File Offset: 0x000027D4
		// (set) Token: 0x060005A3 RID: 1443 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001D3")]
		public Vector3 OverlapLookupCenter
		{
			[Token(Token = "0x60005A2")]
			[Address(RVA = "0x23C25B0", Offset = "0x23C0BB0", VA = "0x1823C25B0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60005A3")]
			[Address(RVA = "0x2DDE520", Offset = "0x2DDCB20", VA = "0x182DDE520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060005A4 RID: 1444 RVA: 0x000045EC File Offset: 0x000027EC
		// (set) Token: 0x060005A5 RID: 1445 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001D4")]
		public Vector3 OverlapLookupLookAt
		{
			[Token(Token = "0x60005A4")]
			[Address(RVA = "0x1F7DB50", Offset = "0x1F7C150", VA = "0x181F7DB50")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60005A5")]
			[Address(RVA = "0x2B3F240", Offset = "0x2B3D840", VA = "0x182B3F240")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060005A6 RID: 1446 RVA: 0x00004604 File Offset: 0x00002804
		[Token(Token = "0x170001D5")]
		public bool FoundTargets
		{
			[Token(Token = "0x60005A6")]
			[Address(RVA = "0x2E1F3F0", Offset = "0x2E1D9F0", VA = "0x182E1F3F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x060005A7 RID: 1447 RVA: 0x0000461C File Offset: 0x0000281C
		[Token(Token = "0x170001D6")]
		public float CastDistance
		{
			[Token(Token = "0x60005A7")]
			[Address(RVA = "0x70B930", Offset = "0x709F30", VA = "0x18070B930")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060005A8 RID: 1448 RVA: 0x00004634 File Offset: 0x00002834
		// (set) Token: 0x060005A9 RID: 1449 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001D7")]
		public float ClosestHitDistance
		{
			[Token(Token = "0x60005A8")]
			[Address(RVA = "0x23C2640", Offset = "0x23C0C40", VA = "0x1823C2640")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60005A9")]
			[Address(RVA = "0x28D8B80", Offset = "0x28D7180", VA = "0x1828D8B80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x060005AA RID: 1450 RVA: 0x0000464C File Offset: 0x0000284C
		// (set) Token: 0x060005AB RID: 1451 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001D8")]
		public float ClosestHitDistanceFlat
		{
			[Token(Token = "0x60005AA")]
			[Address(RVA = "0x6124A0", Offset = "0x610AA0", VA = "0x1806124A0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60005AB")]
			[Address(RVA = "0x6124B0", Offset = "0x610AB0", VA = "0x1806124B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060005AC RID: 1452 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x060005AD RID: 1453 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001D9")]
		public Transform ClosestHitTransform
		{
			[Token(Token = "0x60005AC")]
			[Address(RVA = "0x737410", Offset = "0x735A10", VA = "0x180737410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005AD")]
			[Address(RVA = "0x8DD040", Offset = "0x8DB640", VA = "0x1808DD040")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060005AE RID: 1454 RVA: 0x00004664 File Offset: 0x00002864
		[Token(Token = "0x170001DA")]
		public Ray AimRay
		{
			[Token(Token = "0x60005AE")]
			[Address(RVA = "0x2E1F400", Offset = "0x2E1DA00", VA = "0x182E1F400", Slot = "4")]
			get
			{
				return default(Ray);
			}
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x5B2560", Offset = "0x5B0B60", VA = "0x1805B2560")]
		public void Init(ConstructionManager manager)
		{
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x8F80C0", Offset = "0x8F66C0", VA = "0x1808F80C0")]
		public void SetHitCount(int hitCount)
		{
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x2E1F530", Offset = "0x2E1DB30", VA = "0x182E1F530")]
		public void LookupPhysicsObjects(LookupType lookupType)
		{
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x0000467C File Offset: 0x0000287C
		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x2E1FC60", Offset = "0x2E1E260", VA = "0x182E1FC60")]
		public bool LookupPhysicsObjectOnPredictedGrid(Vector3 areaCenter, float areaSize)
		{
			return default(bool);
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x2E1FE70", Offset = "0x2E1E470", VA = "0x182E1FE70")]
		public void CheckForOccluderHit()
		{
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x2E202F0", Offset = "0x2E1E8F0", VA = "0x182E202F0")]
		private void ResetClosestHit()
		{
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x2E20350", Offset = "0x2E1E950", VA = "0x182E20350")]
		public PhysicsCaster()
		{
		}

		// Token: 0x040004B3 RID: 1203
		[Token(Token = "0x40004B3")]
		[FieldOffset(Offset = "0x0")]
		public static int MaxTargets;

		// Token: 0x040004B4 RID: 1204
		[Token(Token = "0x40004B4")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[Header("Dynamic Targets Cast Settings")]
		private LayerMask _castLayers;

		// Token: 0x040004B5 RID: 1205
		[Token(Token = "0x40004B5")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private LayerMask _castLayersInCaves;

		// Token: 0x040004B6 RID: 1206
		[Token(Token = "0x40004B6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _castRadius;

		// Token: 0x040004B7 RID: 1207
		[Token(Token = "0x40004B7")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _castDistance;

		// Token: 0x040004B8 RID: 1208
		[Token(Token = "0x40004B8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _capsuleCastRadiusRatio;

		// Token: 0x040004B9 RID: 1209
		[Token(Token = "0x40004B9")]
		[FieldOffset(Offset = "0x24")]
		[Header("Occluder Check Cast Settings")]
		[SerializeField]
		private float _occluderCastRadius;

		// Token: 0x040004BA RID: 1210
		[Token(Token = "0x40004BA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Vector3 _occluderCastOffset;

		// Token: 0x040004BB RID: 1211
		[Token(Token = "0x40004BB")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		[Header("Predicted SnapPoints Cast Settings")]
		private LayerMask _predictedSnapPointsCastLayers;

		// Token: 0x040004BC RID: 1212
		[Token(Token = "0x40004BC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Header("Debug")]
		private bool _showCastGizmo;
	}
}
