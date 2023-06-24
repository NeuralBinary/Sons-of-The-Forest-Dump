using System;
using System.Runtime.CompilerServices;
using Crest;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Physics
{
	// Token: 0x0200001C RID: 28
	[Token(Token = "0x200001C")]
	public class Raft : FloatingObjectBase
	{
		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00002370 File Offset: 0x00000570
		[Token(Token = "0x17000012")]
		public override float ObjectWidth
		{
			[Token(Token = "0x600009A")]
			[Address(RVA = "0x9D9860", Offset = "0x9D7E60", VA = "0x1809D9860", Slot = "4")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00002388 File Offset: 0x00000588
		[Token(Token = "0x17000013")]
		public override bool InWater
		{
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x2A88E50", Offset = "0x2A87450", VA = "0x182A88E50", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600009C RID: 156 RVA: 0x000023A0 File Offset: 0x000005A0
		[Token(Token = "0x17000014")]
		private bool HasLimitDistance
		{
			[Token(Token = "0x600009C")]
			[Address(RVA = "0x3104A00", Offset = "0x3103000", VA = "0x183104A00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600009D RID: 157 RVA: 0x000023B8 File Offset: 0x000005B8
		[Token(Token = "0x17000015")]
		private bool HasLimitRotation
		{
			[Token(Token = "0x600009D")]
			[Address(RVA = "0x3104A10", Offset = "0x3103010", VA = "0x183104A10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600009E RID: 158 RVA: 0x000023D0 File Offset: 0x000005D0
		[Token(Token = "0x17000016")]
		public override Vector3 Velocity
		{
			[Token(Token = "0x600009E")]
			[Address(RVA = "0x3104A20", Offset = "0x3103020", VA = "0x183104A20", Slot = "6")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600009F RID: 159 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060000A0 RID: 160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000001")]
		public event Action<Raft> OnUpdateMotion
		{
			[Token(Token = "0x600009F")]
			[Address(RVA = "0x3104AB0", Offset = "0x31030B0", VA = "0x183104AB0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000A0")]
			[Address(RVA = "0x3104C20", Offset = "0x3103220", VA = "0x183104C20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x3104D90", Offset = "0x3103390", VA = "0x183104D90")]
		private void OnEnable()
		{
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x3104F10", Offset = "0x3103510", VA = "0x183104F10")]
		private void Start()
		{
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x3104FA0", Offset = "0x31035A0", VA = "0x183104FA0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x31061F0", Offset = "0x31047F0", VA = "0x1831061F0")]
		private void UpdateLimitDistance()
		{
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x31064E0", Offset = "0x3104AE0", VA = "0x1831064E0")]
		private void UpdateLimitRotation()
		{
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x3106740", Offset = "0x3104D40", VA = "0x183106740")]
		private void UpdateOceanReference()
		{
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x3106920", Offset = "0x3104F20", VA = "0x183106920")]
		private void FixedUpdateOrientation(Vector3 normal)
		{
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x3106E90", Offset = "0x3105490", VA = "0x183106E90")]
		public Raft()
		{
		}

		// Token: 0x040000B3 RID: 179
		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("Offsets center of object to raise it (or lower it) in the water.")]
		[Header("Buoyancy Force")]
		private float _raiseObject;

		// Token: 0x040000B4 RID: 180
		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Tooltip("Strength of buoyancy force per meter of submersion in water.")]
		private float _buoyancyCoeff;

		// Token: 0x040000B5 RID: 181
		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Tooltip("Strength of torque applied to match boat orientation to water normal.")]
		private float _boyancyTorque;

		// Token: 0x040000B6 RID: 182
		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x2C")]
		[Tooltip("Approximate hydrodynamics of 'surfing' down waves.")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _accelerateDownhill;

		// Token: 0x040000B7 RID: 183
		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x30")]
		[Header("Wave Response")]
		[SerializeField]
		[Tooltip("Diameter of object, for physics purposes. The larger this value, the more filtered/smooth the wave response will be.")]
		private float _objectWidth;

		// Token: 0x040000B8 RID: 184
		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		[Header("Limits")]
		private float _limitDistance;

		// Token: 0x040000B9 RID: 185
		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Header("Limits")]
		private float _limitRotation;

		// Token: 0x040000BA RID: 186
		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _limitSpeed;

		// Token: 0x040000BB RID: 187
		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _linkToOcean;

		// Token: 0x040000BC RID: 188
		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GuidReference _oceanReference;

		// Token: 0x040000BD RID: 189
		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("Vertical offset for where drag force should be applied.")]
		[SerializeField]
		[Header("Drag")]
		private float _forceHeightOffset;

		// Token: 0x040000BE RID: 190
		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float _dragInWaterUp;

		// Token: 0x040000BF RID: 191
		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _dragInWaterRight;

		// Token: 0x040000C0 RID: 192
		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float _dragInWaterForward;

		// Token: 0x040000C1 RID: 193
		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _dragInWaterRotational;

		// Token: 0x040000C2 RID: 194
		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		[Header("Debug")]
		private bool _debugDraw;

		// Token: 0x040000C3 RID: 195
		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x68")]
		[Header("Debug")]
		private float _angleOffset;

		// Token: 0x040000C4 RID: 196
		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x6C")]
		private bool _inWater;

		// Token: 0x040000C5 RID: 197
		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x70")]
		private Rigidbody _rigidbody;

		// Token: 0x040000C6 RID: 198
		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x78")]
		private SampleHeightHelper _sampleHeightHelper;

		// Token: 0x040000C7 RID: 199
		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x80")]
		private SampleFlowHelper _sampleFlowHelper;

		// Token: 0x040000C8 RID: 200
		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x88")]
		private Vector3 _startPosition;

		// Token: 0x040000C9 RID: 201
		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x94")]
		private Quaternion _startRotation;
	}
}
