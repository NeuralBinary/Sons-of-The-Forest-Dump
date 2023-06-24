using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000042 RID: 66
[Token(Token = "0x2000042")]
public class VehicleTrailSpawner : MonoBehaviour
{
	// Token: 0x060001CB RID: 459 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x31A5B60", Offset = "0x31A4160", VA = "0x1831A5B60")]
	private void Awake()
	{
	}

	// Token: 0x060001CC RID: 460 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x31A5C30", Offset = "0x31A4230", VA = "0x1831A5C30")]
	private void OnValidate()
	{
	}

	// Token: 0x060001CD RID: 461 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001CD")]
	[Address(RVA = "0x31A62D0", Offset = "0x31A48D0", VA = "0x1831A62D0")]
	private void Update()
	{
	}

	// Token: 0x060001CE RID: 462 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001CE")]
	[Address(RVA = "0x31A6420", Offset = "0x31A4A20", VA = "0x1831A6420")]
	private void Trigger()
	{
	}

	// Token: 0x060001CF RID: 463 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x31A6F10", Offset = "0x31A5510", VA = "0x1831A6F10")]
	public VehicleTrailSpawner()
	{
	}

	// Token: 0x040001C7 RID: 455
	[Token(Token = "0x40001C7")]
	private const float MaxViewerDistance = 60f;

	// Token: 0x040001C8 RID: 456
	[Token(Token = "0x40001C8")]
	private const float MinWaterHeight = 0.1f;

	// Token: 0x040001C9 RID: 457
	[Token(Token = "0x40001C9")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float _updateFrequency;

	// Token: 0x040001CA RID: 458
	[Token(Token = "0x40001CA")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float _requiredSnowDepth;

	// Token: 0x040001CB RID: 459
	[Token(Token = "0x40001CB")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _maxEmissionHeight;

	// Token: 0x040001CC RID: 460
	[Token(Token = "0x40001CC")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float _speedThreshold;

	// Token: 0x040001CD RID: 461
	[Token(Token = "0x40001CD")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private ParticleSystem[] _leafEmissionObjects;

	// Token: 0x040001CE RID: 462
	[Token(Token = "0x40001CE")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private ParticleSystem[] _dirtEmissionObjects;

	// Token: 0x040001CF RID: 463
	[Token(Token = "0x40001CF")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private ParticleSystem[] _waterEmissionObjects;

	// Token: 0x040001D0 RID: 464
	[Token(Token = "0x40001D0")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private ParticleSystem[] _snowEmissionObjects;

	// Token: 0x040001D1 RID: 465
	[Token(Token = "0x40001D1")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 _previousPosition;

	// Token: 0x040001D2 RID: 466
	[Token(Token = "0x40001D2")]
	[FieldOffset(Offset = "0x60")]
	public float[] _leafEmissionObjectsRates;

	// Token: 0x040001D3 RID: 467
	[Token(Token = "0x40001D3")]
	[FieldOffset(Offset = "0x68")]
	public float[] _dirtEmissionObjectsRates;

	// Token: 0x040001D4 RID: 468
	[Token(Token = "0x40001D4")]
	[FieldOffset(Offset = "0x70")]
	public float[] _waterEmissionObjectsRates;

	// Token: 0x040001D5 RID: 469
	[Token(Token = "0x40001D5")]
	[FieldOffset(Offset = "0x78")]
	public float[] _snowEmissionObjectsRates;

	// Token: 0x040001D6 RID: 470
	[Token(Token = "0x40001D6")]
	[FieldOffset(Offset = "0x80")]
	private bool _groundTriggered;

	// Token: 0x040001D7 RID: 471
	[Token(Token = "0x40001D7")]
	[FieldOffset(Offset = "0x81")]
	private bool _leavesTriggered;

	// Token: 0x040001D8 RID: 472
	[Token(Token = "0x40001D8")]
	[FieldOffset(Offset = "0x82")]
	private bool _snowTriggered;

	// Token: 0x040001D9 RID: 473
	[Token(Token = "0x40001D9")]
	[FieldOffset(Offset = "0x83")]
	private bool _waterTriggered;

	// Token: 0x040001DA RID: 474
	[Token(Token = "0x40001DA")]
	[FieldOffset(Offset = "0x84")]
	private bool _isInValidTerrain;

	// Token: 0x040001DB RID: 475
	[Token(Token = "0x40001DB")]
	[FieldOffset(Offset = "0x85")]
	private bool _isInSnow;

	// Token: 0x040001DC RID: 476
	[Token(Token = "0x40001DC")]
	[FieldOffset(Offset = "0x88")]
	private float _updateTimer;
}
