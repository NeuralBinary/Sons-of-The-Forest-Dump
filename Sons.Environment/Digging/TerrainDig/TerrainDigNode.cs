using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace Sons.Environment.Digging.TerrainDig
{
	// Token: 0x02000049 RID: 73
	[Token(Token = "0x2000049")]
	public class TerrainDigNode : MonoBehaviour
	{
		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000211 RID: 529 RVA: 0x00002096 File Offset: 0x00000296
		// (remove) Token: 0x06000212 RID: 530 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x14000006")]
		public event Action<TerrainDigNode> OnDisableEvent
		{
			[Token(Token = "0x6000211")]
			[Address(RVA = "0x2FC3CA0", Offset = "0x2FC22A0", VA = "0x182FC3CA0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000212")]
			[Address(RVA = "0x2FC3E10", Offset = "0x2FC2410", VA = "0x182FC3E10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0000296C File Offset: 0x00000B6C
		[Token(Token = "0x6000213")]
		[Address(RVA = "0x2FC3F80", Offset = "0x2FC2580", VA = "0x182FC3F80")]
		public bool IsTemporary()
		{
			return default(bool);
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00002984 File Offset: 0x00000B84
		[Token(Token = "0x6000214")]
		[Address(RVA = "0x2FC3F90", Offset = "0x2FC2590", VA = "0x182FC3F90")]
		public bool IsNetworkSpawned()
		{
			return default(bool);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0000299C File Offset: 0x00000B9C
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x2FC3FA0", Offset = "0x2FC25A0", VA = "0x182FC3FA0")]
		public bool SendNetworkEvents()
		{
			return default(bool);
		}

		// Token: 0x06000216 RID: 534 RVA: 0x000029B4 File Offset: 0x00000BB4
		[Token(Token = "0x6000216")]
		[Address(RVA = "0x2403F10", Offset = "0x2402510", VA = "0x182403F10")]
		public float GetSize()
		{
			return 0f;
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000217")]
		[Address(RVA = "0xAFF300", Offset = "0xAFD900", VA = "0x180AFF300")]
		public void SetProminentTerrainLayer(int prominentTerrainLayer)
		{
		}

		// Token: 0x06000218 RID: 536 RVA: 0x000029CC File Offset: 0x00000BCC
		[Token(Token = "0x6000218")]
		[Address(RVA = "0xAFF2F0", Offset = "0xAFD8F0", VA = "0x180AFF2F0")]
		public int GetSetProminentTerrainLayer()
		{
			return 0;
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000219")]
		[Address(RVA = "0x2FC3FB0", Offset = "0x2FC25B0", VA = "0x182FC3FB0")]
		public void SetGridPos(int pointX, int pointY)
		{
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600021A")]
		[Address(RVA = "0x2FC4070", Offset = "0x2FC2670", VA = "0x182FC4070")]
		public void SetDefaultSize(float nodeSize)
		{
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600021B")]
		[Address(RVA = "0x2FC4170", Offset = "0x2FC2770", VA = "0x182FC4170")]
		public void SetSize(float nodeSize)
		{
		}

		// Token: 0x0600021C RID: 540 RVA: 0x000029E4 File Offset: 0x00000BE4
		[Token(Token = "0x600021C")]
		[Address(RVA = "0x2FC42A0", Offset = "0x2FC28A0", VA = "0x182FC42A0")]
		public bool MatchesGridPos(int pointX, int pointY)
		{
			return default(bool);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600021D")]
		[Address(RVA = "0x2FC42E0", Offset = "0x2FC28E0", VA = "0x182FC42E0")]
		private void Update()
		{
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600021E")]
		[Address(RVA = "0x2FC42F0", Offset = "0x2FC28F0", VA = "0x182FC42F0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600021F")]
		[Address(RVA = "0x2FC4360", Offset = "0x2FC2960", VA = "0x182FC4360")]
		private void UpdateAdjacentNodeFill()
		{
		}

		// Token: 0x06000220 RID: 544 RVA: 0x000029FC File Offset: 0x00000BFC
		[Token(Token = "0x6000220")]
		[Address(RVA = "0x2FC4B30", Offset = "0x2FC3130", VA = "0x182FC4B30")]
		private float GetDepthWithMultiplier()
		{
			return 0f;
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000221")]
		[Address(RVA = "0x2FC4B50", Offset = "0x2FC3150", VA = "0x182FC4B50")]
		private void CreateNewAdjacentNodeFillObject()
		{
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000222")]
		[Address(RVA = "0x2FC4DE0", Offset = "0x2FC33E0", VA = "0x182FC4DE0")]
		private void UpdateDepth()
		{
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000223")]
		[Address(RVA = "0x2FC5020", Offset = "0x2FC3620", VA = "0x182FC5020")]
		private void SetRendererMaterialDepth(float depthWithMultiplier, MeshRenderer targetRenderer, ref MaterialPropertyBlock matPropertyBlock)
		{
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000224")]
		[Address(RVA = "0x2FC5240", Offset = "0x2FC3840", VA = "0x182FC5240")]
		private void OnDisable()
		{
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000225")]
		[Address(RVA = "0x2FC5330", Offset = "0x2FC3930", VA = "0x182FC5330")]
		public void SetStructureElement(bool value)
		{
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000226")]
		[Address(RVA = "0x2FC5450", Offset = "0x2FC3A50", VA = "0x182FC5450")]
		public void OnDrawGizmosSelected()
		{
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000227")]
		[Address(RVA = "0x1D4F140", Offset = "0x1D4D740", VA = "0x181D4F140")]
		public void SetCluster(TerrainDigCluster terrainDigCluster)
		{
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x6000228")]
		[Address(RVA = "0x750FA0", Offset = "0x74F5A0", VA = "0x180750FA0")]
		public TerrainDigCluster GetCluster()
		{
			return null;
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00002A14 File Offset: 0x00000C14
		[Token(Token = "0x6000229")]
		[Address(RVA = "0x29A0830", Offset = "0x299EE30", VA = "0x1829A0830")]
		public Vector3 GetPosition()
		{
			return default(Vector3);
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600022A")]
		[Address(RVA = "0x2FC5B40", Offset = "0x2FC4140", VA = "0x182FC5B40")]
		public void SetPositionNormal(Vector3 terrainPosition, Vector3 terrainNormal)
		{
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600022B")]
		[Address(RVA = "0x2FC5C40", Offset = "0x2FC4240", VA = "0x182FC5C40")]
		public void RefreshScale()
		{
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00002A2C File Offset: 0x00000C2C
		[Token(Token = "0x600022C")]
		[Address(RVA = "0x2FC5D80", Offset = "0x2FC4380", VA = "0x182FC5D80")]
		public bool IsTouching(TerrainDigNode node)
		{
			return default(bool);
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00002A44 File Offset: 0x00000C44
		[Token(Token = "0x600022D")]
		[Address(RVA = "0x28D1490", Offset = "0x28CFA90", VA = "0x1828D1490")]
		public Vector3 GetNormal()
		{
			return default(Vector3);
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600022E")]
		[Address(RVA = "0x2FC5DF0", Offset = "0x2FC43F0", VA = "0x182FC5DF0")]
		public void SetGameObjectPosition(Vector3 newPosition)
		{
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600022F")]
		[Address(RVA = "0x2FC5F00", Offset = "0x2FC4500", VA = "0x182FC5F00")]
		public void Destruct()
		{
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000230")]
		[Address(RVA = "0x2FC6070", Offset = "0x2FC4670", VA = "0x182FC6070")]
		public void IsMergedResult(bool value)
		{
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00002A5C File Offset: 0x00000C5C
		[Token(Token = "0x6000231")]
		[Address(RVA = "0x2FC6080", Offset = "0x2FC4680", VA = "0x182FC6080")]
		public bool GetIsMergedResult()
		{
			return default(bool);
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000232")]
		[Address(RVA = "0x2FC6090", Offset = "0x2FC4690", VA = "0x182FC6090")]
		public void SetDepth(float value)
		{
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00002A74 File Offset: 0x00000C74
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x1F05980", Offset = "0x1F03F80", VA = "0x181F05980")]
		public float GetDepth()
		{
			return 0f;
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000234")]
		[Address(RVA = "0x2FC6180", Offset = "0x2FC4780", VA = "0x182FC6180")]
		public void AddAdjacent(IEnumerable<TerrainDigNode> nodes)
		{
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000235")]
		[Address(RVA = "0x2FC6430", Offset = "0x2FC4A30", VA = "0x182FC6430")]
		private void AddAdjacentInternal(TerrainDigNode eachNode, bool updateAdjacentNodeFill = true)
		{
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00002A8C File Offset: 0x00000C8C
		[Token(Token = "0x6000236")]
		[Address(RVA = "0x2FC6550", Offset = "0x2FC4B50", VA = "0x182FC6550")]
		private bool HasAdjacentNode(TerrainDigNode node)
		{
			return default(bool);
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000237")]
		[Address(RVA = "0x25A7290", Offset = "0x25A5890", VA = "0x1825A7290")]
		public void SetDigThroughTerrain(bool value)
		{
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000238")]
		[Address(RVA = "0x2FC6630", Offset = "0x2FC4C30", VA = "0x182FC6630")]
		public void SpawnItem()
		{
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000239")]
		[Address(RVA = "0x2FC66E0", Offset = "0x2FC4CE0", VA = "0x182FC66E0")]
		public TerrainDigNode()
		{
		}

		// Token: 0x04000212 RID: 530
		[Token(Token = "0x4000212")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector3 _terrainPosition;

		// Token: 0x04000213 RID: 531
		[Token(Token = "0x4000213")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Vector3 _terrainNormal;

		// Token: 0x04000214 RID: 532
		[Token(Token = "0x4000214")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _structureElement;

		// Token: 0x04000215 RID: 533
		[Token(Token = "0x4000215")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private int[] _gridPos;

		// Token: 0x04000216 RID: 534
		[Token(Token = "0x4000216")]
		[FieldOffset(Offset = "0x48")]
		[FormerlySerializedAs("_renderer")]
		[SerializeField]
		private MeshRenderer _mainRenderer;

		// Token: 0x04000217 RID: 535
		[Token(Token = "0x4000217")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private MeshRenderer _edgeRenderer;

		// Token: 0x04000218 RID: 536
		[Token(Token = "0x4000218")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _depthMultiplier;

		// Token: 0x04000219 RID: 537
		[Token(Token = "0x4000219")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float _depthFadeRate;

		// Token: 0x0400021A RID: 538
		[Token(Token = "0x400021A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _depthFadeDelay;

		// Token: 0x0400021B RID: 539
		[Token(Token = "0x400021B")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float _depth;

		// Token: 0x0400021C RID: 540
		[Token(Token = "0x400021C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private TerrainDigNodeConnector _adjacentNodeFillPrefab;

		// Token: 0x0400021D RID: 541
		[Token(Token = "0x400021D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private List<TerrainDigNode> _adjacentNodes;

		// Token: 0x0400021E RID: 542
		[Token(Token = "0x400021E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Vector3 _spawnPositionOffset;

		// Token: 0x0400021F RID: 543
		[Token(Token = "0x400021F")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UnityEvent<Vector3> _spawnItemEvent;

		// Token: 0x04000220 RID: 544
		[Token(Token = "0x4000220")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private int _prominentTerrainLayer;

		// Token: 0x04000221 RID: 545
		[Token(Token = "0x4000221")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		private bool _isTemporary;

		// Token: 0x04000222 RID: 546
		[Token(Token = "0x4000222")]
		[FieldOffset(Offset = "0x95")]
		[SerializeField]
		private bool _networkedSpawned;

		// Token: 0x04000223 RID: 547
		[Token(Token = "0x4000223")]
		[FieldOffset(Offset = "0x96")]
		[SerializeField]
		private bool _sendNetworkEvents;

		// Token: 0x04000224 RID: 548
		[Token(Token = "0x4000224")]
		[FieldOffset(Offset = "0x98")]
		private TerrainDigCluster _cluster;

		// Token: 0x04000225 RID: 549
		[Token(Token = "0x4000225")]
		[FieldOffset(Offset = "0xA0")]
		private float _defaultSize;

		// Token: 0x04000226 RID: 550
		[Token(Token = "0x4000226")]
		[FieldOffset(Offset = "0xA4")]
		private float _size;

		// Token: 0x04000227 RID: 551
		[Token(Token = "0x4000227")]
		[FieldOffset(Offset = "0xA8")]
		private MaterialPropertyBlock _mainMatBlock;

		// Token: 0x04000228 RID: 552
		[Token(Token = "0x4000228")]
		[FieldOffset(Offset = "0xB0")]
		private MaterialPropertyBlock _edgeMatBlock;

		// Token: 0x04000229 RID: 553
		[Token(Token = "0x4000229")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int ProjectedHeightScale;

		// Token: 0x0400022A RID: 554
		[Token(Token = "0x400022A")]
		[FieldOffset(Offset = "0xB8")]
		private Vector3 _baseTransformScale;

		// Token: 0x0400022B RID: 555
		[Token(Token = "0x400022B")]
		[FieldOffset(Offset = "0xC4")]
		private bool _capturedTransformScale;

		// Token: 0x0400022C RID: 556
		[Token(Token = "0x400022C")]
		[FieldOffset(Offset = "0xC5")]
		private bool _isMergedResult;

		// Token: 0x0400022D RID: 557
		[Token(Token = "0x400022D")]
		[FieldOffset(Offset = "0xC8")]
		private List<TerrainDigNodeConnector> _adjacentNodeFillObjects;

		// Token: 0x0400022E RID: 558
		[Token(Token = "0x400022E")]
		[FieldOffset(Offset = "0xD0")]
		private bool _digThroughTerrain;

		// Token: 0x0400022F RID: 559
		[Token(Token = "0x400022F")]
		[FieldOffset(Offset = "0x4")]
		private static float _digThroughTriggerDepth;

		// Token: 0x04000230 RID: 560
		[Token(Token = "0x4000230")]
		[FieldOffset(Offset = "0x8")]
		private static float _digThroughValue;

		// Token: 0x04000231 RID: 561
		[Token(Token = "0x4000231")]
		[FieldOffset(Offset = "0xD4")]
		private float _lastDepth;

		// Token: 0x04000232 RID: 562
		[Token(Token = "0x4000232")]
		[FieldOffset(Offset = "0xD8")]
		private float _lastDepthMultiplier;

		// Token: 0x04000233 RID: 563
		[Token(Token = "0x4000233")]
		[FieldOffset(Offset = "0xDC")]
		private float _fadeStartTime;

		// Token: 0x04000234 RID: 564
		[Token(Token = "0x4000234")]
		[FieldOffset(Offset = "0xE0")]
		private float _depthFade;
	}
}
