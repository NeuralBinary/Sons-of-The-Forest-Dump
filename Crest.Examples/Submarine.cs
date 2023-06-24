using System;
using Crest;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200000C RID: 12
[Token(Token = "0x200000C")]
public class Submarine : FloatingObjectBase
{
	// Token: 0x17000004 RID: 4
	// (get) Token: 0x06000020 RID: 32 RVA: 0x00002098 File Offset: 0x00000298
	[Token(Token = "0x17000004")]
	public override float ObjectWidth
	{
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x71D320", Offset = "0x71B920", VA = "0x18071D320", Slot = "4")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x06000021 RID: 33 RVA: 0x000020B0 File Offset: 0x000002B0
	[Token(Token = "0x17000005")]
	public override bool InWater
	{
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x6124E0", Offset = "0x610AE0", VA = "0x1806124E0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x06000022 RID: 34 RVA: 0x000020C8 File Offset: 0x000002C8
	[Token(Token = "0x17000006")]
	public override Vector3 Velocity
	{
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x9F3DD0", Offset = "0x9F23D0", VA = "0x1809F3DD0", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x06000023 RID: 35 RVA: 0x00002096 File Offset: 0x00000296
	[Token(Token = "0x6000023")]
	[Address(RVA = "0x9F3E60", Offset = "0x9F2460", VA = "0x1809F3E60")]
	private void Start()
	{
	}

	// Token: 0x06000024 RID: 36 RVA: 0x00002096 File Offset: 0x00000296
	[Token(Token = "0x6000024")]
	[Address(RVA = "0x9F4030", Offset = "0x9F2630", VA = "0x1809F4030")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06000025 RID: 37 RVA: 0x00002096 File Offset: 0x00000296
	[Token(Token = "0x6000025")]
	[Address(RVA = "0x9F5B50", Offset = "0x9F4150", VA = "0x1809F5B50")]
	private void FixedUpdateOrientation(Vector3 normalSideways)
	{
	}

	// Token: 0x06000026 RID: 38 RVA: 0x00002096 File Offset: 0x00000296
	[Token(Token = "0x6000026")]
	[Address(RVA = "0x9F66D0", Offset = "0x9F4CD0", VA = "0x1809F66D0")]
	private void UpdateHull()
	{
	}

	// Token: 0x06000027 RID: 39 RVA: 0x00002096 File Offset: 0x00000296
	[Token(Token = "0x6000027")]
	[Address(RVA = "0x9F6870", Offset = "0x9F4E70", VA = "0x1809F6870")]
	private void UpdatePropeller()
	{
	}

	// Token: 0x06000028 RID: 40 RVA: 0x00002096 File Offset: 0x00000296
	[Token(Token = "0x6000028")]
	[Address(RVA = "0x9F6AE0", Offset = "0x9F50E0", VA = "0x1809F6AE0")]
	private void UpdateTail()
	{
	}

	// Token: 0x06000029 RID: 41 RVA: 0x00002096 File Offset: 0x00000296
	[Token(Token = "0x6000029")]
	[Address(RVA = "0x9F6C90", Offset = "0x9F5290", VA = "0x1809F6C90")]
	public Submarine()
	{
	}

	// Token: 0x04000047 RID: 71
	[Token(Token = "0x4000047")]
	[FieldOffset(Offset = "0x20")]
	[Header("Buoyancy Force")]
	[Tooltip("Height offset from transform center to bottom of boat (if any).")]
	[SerializeField]
	private float _bottomH;

	// Token: 0x04000048 RID: 72
	[Token(Token = "0x4000048")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Tooltip("Strength of buoyancy force per meter of submersion in water.")]
	private float _buoyancyCoeff;

	// Token: 0x04000049 RID: 73
	[Token(Token = "0x4000049")]
	[FieldOffset(Offset = "0x28")]
	[Tooltip("Strength of torque applied to match boat orientation to water normal.")]
	[SerializeField]
	private float _boyancyTorque;

	// Token: 0x0400004A RID: 74
	[Token(Token = "0x400004A")]
	[FieldOffset(Offset = "0x2C")]
	[Header("Engine Power")]
	[Tooltip("Vertical offset for where engine force should be applied.")]
	[SerializeField]
	private float _forceHeightOffset;

	// Token: 0x0400004B RID: 75
	[Token(Token = "0x400004B")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float _enginePower;

	// Token: 0x0400004C RID: 76
	[Token(Token = "0x400004C")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float _turnPower;

	// Token: 0x0400004D RID: 77
	[Token(Token = "0x400004D")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Header("Wave Response")]
	[Tooltip("Width dimension of boat. The larger this value, the more filtered/smooth the wave response will be.")]
	private float _boatWidth;

	// Token: 0x0400004E RID: 78
	[Token(Token = "0x400004E")]
	[FieldOffset(Offset = "0x3C")]
	[Tooltip("Computes a separate normal based on boat length to get more accurate orientations, at the cost of an extra collision sample.")]
	[SerializeField]
	private bool _useBoatLength;

	// Token: 0x0400004F RID: 79
	[Token(Token = "0x400004F")]
	[FieldOffset(Offset = "0x40")]
	[Tooltip("Length dimension of boat. Only used if Use Boat Length is enabled.")]
	[SerializeField]
	private float _boatLength;

	// Token: 0x04000050 RID: 80
	[Token(Token = "0x4000050")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	[Header("Drag")]
	private float _dragInWaterUp;

	// Token: 0x04000051 RID: 81
	[Token(Token = "0x4000051")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private float _dragInWaterRight;

	// Token: 0x04000052 RID: 82
	[Token(Token = "0x4000052")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private float _dragInWaterForward;

	// Token: 0x04000053 RID: 83
	[Token(Token = "0x4000053")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Header("Controls")]
	private bool _playerControlled;

	// Token: 0x04000054 RID: 84
	[Token(Token = "0x4000054")]
	[FieldOffset(Offset = "0x54")]
	[Tooltip("Used to automatically add turning input")]
	[SerializeField]
	private float _steerBias;

	// Token: 0x04000055 RID: 85
	[Token(Token = "0x4000055")]
	[FieldOffset(Offset = "0x58")]
	[Header("Debug")]
	[SerializeField]
	private bool _debugDraw;

	// Token: 0x04000056 RID: 86
	[Token(Token = "0x4000056")]
	[FieldOffset(Offset = "0x60")]
	[Header("Submarine")]
	[SerializeField]
	private AnimationCurve _buoyancyCurveFactor;

	// Token: 0x04000057 RID: 87
	[Token(Token = "0x4000057")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Transform _hull;

	// Token: 0x04000058 RID: 88
	[Token(Token = "0x4000058")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Transform _propeller;

	// Token: 0x04000059 RID: 89
	[Token(Token = "0x4000059")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Transform _rightFin;

	// Token: 0x0400005A RID: 90
	[Token(Token = "0x400005A")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Transform _leftFin;

	// Token: 0x0400005B RID: 91
	[Token(Token = "0x400005B")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private Transform _tail;

	// Token: 0x0400005C RID: 92
	[Token(Token = "0x400005C")]
	[FieldOffset(Offset = "0x90")]
	private float _buoyancyFactor;

	// Token: 0x0400005D RID: 93
	[Token(Token = "0x400005D")]
	[FieldOffset(Offset = "0x94")]
	[HideInInspector]
	public float _submarineSpeed;

	// Token: 0x0400005E RID: 94
	[Token(Token = "0x400005E")]
	[FieldOffset(Offset = "0x98")]
	private float _hullUpDown;

	// Token: 0x0400005F RID: 95
	[Token(Token = "0x400005F")]
	[FieldOffset(Offset = "0x9C")]
	private float _tailUpDown;

	// Token: 0x04000060 RID: 96
	[Token(Token = "0x4000060")]
	[FieldOffset(Offset = "0xA0")]
	private bool _inWater;

	// Token: 0x04000061 RID: 97
	[Token(Token = "0x4000061")]
	[FieldOffset(Offset = "0xA8")]
	private Rigidbody _rb;

	// Token: 0x04000062 RID: 98
	[Token(Token = "0x4000062")]
	[FieldOffset(Offset = "0xB0")]
	private SampleHeightHelper _sampleHeightHelper;

	// Token: 0x04000063 RID: 99
	[Token(Token = "0x4000063")]
	[FieldOffset(Offset = "0xB8")]
	private SampleHeightHelper _sampleHeightHelperLengthwise;

	// Token: 0x04000064 RID: 100
	[Token(Token = "0x4000064")]
	[FieldOffset(Offset = "0xC0")]
	private SampleFlowHelper _sampleFlowHelper;
}
