using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

// Token: 0x02000056 RID: 86
[Token(Token = "0x2000056")]
public class TentModulePlacement : MonoBehaviour
{
	// Token: 0x06000282 RID: 642 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000282")]
	[Address(RVA = "0x31B0950", Offset = "0x31AEF50", VA = "0x1831B0950")]
	private void Start()
	{
	}

	// Token: 0x06000283 RID: 643 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000283")]
	[Address(RVA = "0x31B1240", Offset = "0x31AF840", VA = "0x1831B1240")]
	private void OnDisable()
	{
	}

	// Token: 0x06000284 RID: 644 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000284")]
	[Address(RVA = "0x31B1250", Offset = "0x31AF850", VA = "0x1831B1250")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06000285 RID: 645 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000285")]
	[Address(RVA = "0x31B1260", Offset = "0x31AF860", VA = "0x1831B1260")]
	private void Update()
	{
	}

	// Token: 0x06000286 RID: 646 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000286")]
	[Address(RVA = "0x31B1BD0", Offset = "0x31B01D0", VA = "0x1831B1BD0")]
	private void CalculatePlacementPosition()
	{
	}

	// Token: 0x06000287 RID: 647 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000287")]
	[Address(RVA = "0x31B2440", Offset = "0x31B0A40", VA = "0x1831B2440")]
	private void ShowPlacementUI(bool show)
	{
	}

	// Token: 0x06000288 RID: 648 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000288")]
	[Address(RVA = "0x31B25C0", Offset = "0x31B0BC0", VA = "0x1831B25C0")]
	private void OnTriggerStay(Collider other)
	{
	}

	// Token: 0x06000289 RID: 649 RVA: 0x00002EF8 File Offset: 0x000010F8
	[Token(Token = "0x6000289")]
	[Address(RVA = "0x31B26A0", Offset = "0x31B0CA0", VA = "0x1831B26A0")]
	private bool IsABlocker(GameObject potentialBlocker)
	{
		return default(bool);
	}

	// Token: 0x0600028A RID: 650 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600028A")]
	[Address(RVA = "0x31B2720", Offset = "0x31B0D20", VA = "0x1831B2720")]
	public TentModulePlacement()
	{
	}

	// Token: 0x04000264 RID: 612
	[Token(Token = "0x4000264")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject _placementArrowPrefab;

	// Token: 0x04000265 RID: 613
	[Token(Token = "0x4000265")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject _tentPrefab;

	// Token: 0x04000266 RID: 614
	[Token(Token = "0x4000266")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject _connectorPrefab;

	// Token: 0x04000267 RID: 615
	[Token(Token = "0x4000267")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float _maxPlacementDistance;

	// Token: 0x04000268 RID: 616
	[Token(Token = "0x4000268")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private Vector3 _placementArea;

	// Token: 0x04000269 RID: 617
	[Token(Token = "0x4000269")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private LayerMask _placementRaycastLayerMask;

	// Token: 0x0400026A RID: 618
	[Token(Token = "0x400026A")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private LayerMask _blockersLayerMask;

	// Token: 0x0400026B RID: 619
	[Token(Token = "0x400026B")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private float _rotationRate;

	// Token: 0x0400026C RID: 620
	[Token(Token = "0x400026C")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Material _decalMaterial;

	// Token: 0x0400026D RID: 621
	[Token(Token = "0x400026D")]
	[FieldOffset(Offset = "0x60")]
	private float _currentAppliedRotation;

	// Token: 0x0400026E RID: 622
	[Token(Token = "0x400026E")]
	[FieldOffset(Offset = "0x68")]
	private GameObject _box;

	// Token: 0x0400026F RID: 623
	[Token(Token = "0x400026F")]
	[FieldOffset(Offset = "0x70")]
	private DecalProjector _decalProjector;

	// Token: 0x04000270 RID: 624
	[Token(Token = "0x4000270")]
	[FieldOffset(Offset = "0x78")]
	private bool _isValidPlacement;

	// Token: 0x04000271 RID: 625
	[Token(Token = "0x4000271")]
	[FieldOffset(Offset = "0x80")]
	private GameObject _arrow;

	// Token: 0x04000272 RID: 626
	[Token(Token = "0x4000272")]
	[FieldOffset(Offset = "0x88")]
	private bool _isSnappingPlacement;

	// Token: 0x04000273 RID: 627
	[Token(Token = "0x4000273")]
	[FieldOffset(Offset = "0x8C")]
	[SerializeField]
	private LayerMask _tentLayerMask;

	// Token: 0x04000274 RID: 628
	[Token(Token = "0x4000274")]
	[FieldOffset(Offset = "0x90")]
	private Transform _objectSnapTransform;

	// Token: 0x04000275 RID: 629
	[Token(Token = "0x4000275")]
	[FieldOffset(Offset = "0x98")]
	private Transform _triggerSnapTransform;
}
