using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Crest
{
	// Token: 0x0200002F RID: 47
	[Token(Token = "0x200002F")]
	public class SimpleFloatingObject : FloatingObjectBase
	{
		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x00002478 File Offset: 0x00000678
		[Token(Token = "0x17000022")]
		public override float ObjectWidth
		{
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x9D9860", Offset = "0x9D7E60", VA = "0x1809D9860", Slot = "4")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x00002490 File Offset: 0x00000690
		[Token(Token = "0x17000023")]
		public override bool InWater
		{
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x9D9870", Offset = "0x9D7E70", VA = "0x1809D9870", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000EA RID: 234 RVA: 0x000024A8 File Offset: 0x000006A8
		[Token(Token = "0x17000024")]
		public override Vector3 Velocity
		{
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x9D9880", Offset = "0x9D7E80", VA = "0x1809D9880", Slot = "6")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x9D9910", Offset = "0x9D7F10", VA = "0x1809D9910")]
		private void Start()
		{
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x9D9AD0", Offset = "0x9D80D0", VA = "0x1809D9AD0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x9DACE0", Offset = "0x9D92E0", VA = "0x1809DACE0")]
		private void FixedUpdateOrientation(Vector3 normal)
		{
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x9DB250", Offset = "0x9D9850", VA = "0x1809DB250")]
		public SimpleFloatingObject()
		{
		}

		// Token: 0x040000AE RID: 174
		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Offsets center of object to raise it (or lower it) in the water.")]
		[SerializeField]
		[Header("Buoyancy Force")]
		private float _raiseObject;

		// Token: 0x040000AF RID: 175
		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Tooltip("Strength of buoyancy force per meter of submersion in water.")]
		private float _buoyancyCoeff;

		// Token: 0x040000B0 RID: 176
		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Tooltip("Strength of torque applied to match boat orientation to water normal.")]
		private float _boyancyTorque;

		// Token: 0x040000B1 RID: 177
		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x2C")]
		[Range(0f, 1f)]
		[SerializeField]
		[Tooltip("Approximate hydrodynamics of 'surfing' down waves.")]
		private float _accelerateDownhill;

		// Token: 0x040000B2 RID: 178
		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Header("Wave Response")]
		[Tooltip("Diameter of object, for physics purposes. The larger this value, the more filtered/smooth the wave response will be.")]
		private float _objectWidth;

		// Token: 0x040000B3 RID: 179
		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		[Tooltip("Vertical offset for where drag force should be applied.")]
		[Header("Drag")]
		private float _forceHeightOffset;

		// Token: 0x040000B4 RID: 180
		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _dragInWaterUp;

		// Token: 0x040000B5 RID: 181
		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _dragInWaterRight;

		// Token: 0x040000B6 RID: 182
		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _dragInWaterForward;

		// Token: 0x040000B7 RID: 183
		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float _dragInWaterRotational;

		// Token: 0x040000B8 RID: 184
		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Header("Debug")]
		private bool _debugDraw;

		// Token: 0x040000B9 RID: 185
		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x49")]
		private bool _inWater;

		// Token: 0x040000BA RID: 186
		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x50")]
		private Rigidbody _rb;

		// Token: 0x040000BB RID: 187
		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x58")]
		private SampleHeightHelper _sampleHeightHelper;

		// Token: 0x040000BC RID: 188
		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x60")]
		private SampleFlowHelper _sampleFlowHelper;
	}
}
