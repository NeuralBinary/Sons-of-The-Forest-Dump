using System;
using Crest;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000002 RID: 2
[Token(Token = "0x2000002")]
public class BoatAlignNormal : FloatingObjectBase
{
	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000001")]
	public override float ObjectWidth
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x71D320", Offset = "0x71B920", VA = "0x18071D320", Slot = "4")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000002 RID: 2 RVA: 0x00002068 File Offset: 0x00000268
	[Token(Token = "0x17000002")]
	public override bool InWater
	{
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x9EB6D0", Offset = "0x9E9CD0", VA = "0x1809EB6D0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000003 RID: 3 RVA: 0x00002080 File Offset: 0x00000280
	[Token(Token = "0x17000003")]
	public override Vector3 Velocity
	{
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x9EB6E0", Offset = "0x9E9CE0", VA = "0x1809EB6E0", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00002096 File Offset: 0x00000296
	[Token(Token = "0x6000004")]
	[Address(RVA = "0x9EB770", Offset = "0x9E9D70", VA = "0x1809EB770")]
	private void Start()
	{
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00002096 File Offset: 0x00000296
	[Token(Token = "0x6000005")]
	[Address(RVA = "0x9EB930", Offset = "0x9E9F30", VA = "0x1809EB930")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06000006 RID: 6 RVA: 0x00002096 File Offset: 0x00000296
	[Token(Token = "0x6000006")]
	[Address(RVA = "0x9ECD60", Offset = "0x9EB360", VA = "0x1809ECD60")]
	private void FixedUpdateOrientation(Vector3 normalSideways)
	{
	}

	// Token: 0x06000007 RID: 7 RVA: 0x00002096 File Offset: 0x00000296
	[Token(Token = "0x6000007")]
	[Address(RVA = "0x9ED8E0", Offset = "0x9EBEE0", VA = "0x1809ED8E0")]
	public BoatAlignNormal()
	{
	}

	// Token: 0x04000001 RID: 1
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x20")]
	[Header("Buoyancy Force")]
	[Tooltip("Height offset from transform center to bottom of boat (if any).")]
	[SerializeField]
	private float _bottomH;

	// Token: 0x04000002 RID: 2
	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Tooltip("Strength of buoyancy force per meter of submersion in water.")]
	private float _buoyancyCoeff;

	// Token: 0x04000003 RID: 3
	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x28")]
	[Tooltip("Strength of torque applied to match boat orientation to water normal.")]
	[SerializeField]
	private float _boyancyTorque;

	// Token: 0x04000004 RID: 4
	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x2C")]
	[Tooltip("Vertical offset for where engine force should be applied.")]
	[Header("Engine Power")]
	[SerializeField]
	private float _forceHeightOffset;

	// Token: 0x04000005 RID: 5
	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float _enginePower;

	// Token: 0x04000006 RID: 6
	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float _turnPower;

	// Token: 0x04000007 RID: 7
	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x38")]
	[Header("Wave Response")]
	[Tooltip("Width dimension of boat. The larger this value, the more filtered/smooth the wave response will be.")]
	[SerializeField]
	private float _boatWidth;

	// Token: 0x04000008 RID: 8
	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Tooltip("Computes a separate normal based on boat length to get more accurate orientations, at the cost of an extra collision sample.")]
	private bool _useBoatLength;

	// Token: 0x04000009 RID: 9
	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x40")]
	[Tooltip("Length dimension of boat. Only used if Use Boat Length is enabled.")]
	[SerializeField]
	[PredicatedField("_useBoatLength", false, 0)]
	private float _boatLength;

	// Token: 0x0400000A RID: 10
	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x44")]
	[Header("Drag")]
	[SerializeField]
	private float _dragInWaterUp;

	// Token: 0x0400000B RID: 11
	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private float _dragInWaterRight;

	// Token: 0x0400000C RID: 12
	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private float _dragInWaterForward;

	// Token: 0x0400000D RID: 13
	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x50")]
	[Header("Controls")]
	[SerializeField]
	private bool _playerControlled;

	// Token: 0x0400000E RID: 14
	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x54")]
	[Tooltip("Used to automatically add throttle input")]
	[SerializeField]
	private float _throttleBias;

	// Token: 0x0400000F RID: 15
	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x58")]
	[Tooltip("Used to automatically add turning input")]
	[SerializeField]
	private float _steerBias;

	// Token: 0x04000010 RID: 16
	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x5C")]
	[Header("Debug")]
	[SerializeField]
	private bool _debugDraw;

	// Token: 0x04000011 RID: 17
	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x5D")]
	private bool _inWater;

	// Token: 0x04000012 RID: 18
	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x60")]
	private Rigidbody _rb;

	// Token: 0x04000013 RID: 19
	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x68")]
	private SampleHeightHelper _sampleHeightHelper;

	// Token: 0x04000014 RID: 20
	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x70")]
	private SampleHeightHelper _sampleHeightHelperLengthwise;

	// Token: 0x04000015 RID: 21
	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x78")]
	private SampleFlowHelper _sampleFlowHelper;
}
