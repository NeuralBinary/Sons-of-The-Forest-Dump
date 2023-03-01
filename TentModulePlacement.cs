using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

// Token: 0x02000055 RID: 85
[Token(Token = "0x2000055")]
public class TentModulePlacement : MonoBehaviour
{
	// Token: 0x06000265 RID: 613 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000265")]
	[Address(RVA = "0x2B7FE80", Offset = "0x2B7EE80", VA = "0x182B7FE80")]
	private void Start()
	{
	}

	// Token: 0x06000266 RID: 614 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000266")]
	[Address(RVA = "0x2B7FC60", Offset = "0x2B7EC60", VA = "0x182B7FC60")]
	private void OnDisable()
	{
	}

	// Token: 0x06000267 RID: 615 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000267")]
	[Address(RVA = "0x27E6930", Offset = "0x27E5930", VA = "0x1827E6930")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06000268 RID: 616 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000268")]
	[Address(RVA = "0x2B80310", Offset = "0x2B7F310", VA = "0x182B80310")]
	private void Update()
	{
	}

	// Token: 0x06000269 RID: 617 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000269")]
	[Address(RVA = "0x2B7F690", Offset = "0x2B7E690", VA = "0x182B7F690")]
	private void CalculatePlacementPosition()
	{
	}

	// Token: 0x0600026A RID: 618 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600026A")]
	[Address(RVA = "0x2B7FD80", Offset = "0x2B7ED80", VA = "0x182B7FD80")]
	private void ShowPlacementUI(bool show)
	{
	}

	// Token: 0x0600026B RID: 619 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600026B")]
	[Address(RVA = "0x2B7FD00", Offset = "0x2B7ED00", VA = "0x182B7FD00")]
	private void OnTriggerStay(Collider other)
	{
	}

	// Token: 0x0600026C RID: 620 RVA: 0x00002E20 File Offset: 0x00001020
	[Token(Token = "0x600026C")]
	[Address(RVA = "0x2B7FC10", Offset = "0x2B7EC10", VA = "0x182B7FC10")]
	private bool IsABlocker(GameObject potentialBlocker)
	{
		return default(bool);
	}

	// Token: 0x0600026D RID: 621 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600026D")]
	[Address(RVA = "0x2B80AD0", Offset = "0x2B7FAD0", VA = "0x182B80AD0")]
	public TentModulePlacement()
	{
	}

	// Token: 0x04000238 RID: 568
	[Token(Token = "0x4000238")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject _placementArrowPrefab;

	// Token: 0x04000239 RID: 569
	[Token(Token = "0x4000239")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject _tentPrefab;

	// Token: 0x0400023A RID: 570
	[Token(Token = "0x400023A")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject _connectorPrefab;

	// Token: 0x0400023B RID: 571
	[Token(Token = "0x400023B")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float _maxPlacementDistance;

	// Token: 0x0400023C RID: 572
	[Token(Token = "0x400023C")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private Vector3 _placementArea;

	// Token: 0x0400023D RID: 573
	[Token(Token = "0x400023D")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private LayerMask _placementRaycastLayerMask;

	// Token: 0x0400023E RID: 574
	[Token(Token = "0x400023E")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private LayerMask _blockersLayerMask;

	// Token: 0x0400023F RID: 575
	[Token(Token = "0x400023F")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private float _rotationRate;

	// Token: 0x04000240 RID: 576
	[Token(Token = "0x4000240")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Material _decalMaterial;

	// Token: 0x04000241 RID: 577
	[Token(Token = "0x4000241")]
	[FieldOffset(Offset = "0x60")]
	private float _currentAppliedRotation;

	// Token: 0x04000242 RID: 578
	[Token(Token = "0x4000242")]
	[FieldOffset(Offset = "0x68")]
	private GameObject _box;

	// Token: 0x04000243 RID: 579
	[Token(Token = "0x4000243")]
	[FieldOffset(Offset = "0x70")]
	private DecalProjector _decalProjector;

	// Token: 0x04000244 RID: 580
	[Token(Token = "0x4000244")]
	[FieldOffset(Offset = "0x78")]
	private bool _isValidPlacement;

	// Token: 0x04000245 RID: 581
	[Token(Token = "0x4000245")]
	[FieldOffset(Offset = "0x80")]
	private GameObject _arrow;

	// Token: 0x04000246 RID: 582
	[Token(Token = "0x4000246")]
	[FieldOffset(Offset = "0x88")]
	private bool _isSnappingPlacement;

	// Token: 0x04000247 RID: 583
	[Token(Token = "0x4000247")]
	[FieldOffset(Offset = "0x8C")]
	[SerializeField]
	private LayerMask _tentLayerMask;

	// Token: 0x04000248 RID: 584
	[Token(Token = "0x4000248")]
	[FieldOffset(Offset = "0x90")]
	private Transform _objectSnapTransform;

	// Token: 0x04000249 RID: 585
	[Token(Token = "0x4000249")]
	[FieldOffset(Offset = "0x98")]
	private Transform _triggerSnapTransform;
}
