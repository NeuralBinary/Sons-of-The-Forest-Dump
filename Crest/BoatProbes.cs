using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Crest
{
	// Token: 0x0200002A RID: 42
	[Token(Token = "0x200002A")]
	public class BoatProbes : FloatingObjectBase
	{
		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000CF RID: 207 RVA: 0x000023E8 File Offset: 0x000005E8
		[Token(Token = "0x17000019")]
		public override Vector3 Velocity
		{
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x9D5B70", Offset = "0x9D4170", VA = "0x1809D5B70", Slot = "6")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00002400 File Offset: 0x00000600
		[Token(Token = "0x1700001A")]
		public override float ObjectWidth
		{
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x781570", Offset = "0x77FB70", VA = "0x180781570", Slot = "4")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00002418 File Offset: 0x00000618
		[Token(Token = "0x1700001B")]
		public override bool InWater
		{
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x9D5C00", Offset = "0x9D4200", VA = "0x1809D5C00")]
		private void Start()
		{
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x9D6000", Offset = "0x9D4600", VA = "0x1809D6000")]
		private void CalcTotalWeight()
		{
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x9D6060", Offset = "0x9D4660", VA = "0x1809D6060")]
		private void FixedUpdate()
		{
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x9D6490", Offset = "0x9D4A90", VA = "0x1809D6490")]
		private void UpdateWaterQueries(ICollProvider collProvider)
		{
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x9D67F0", Offset = "0x9D4DF0", VA = "0x1809D67F0")]
		private void FixedUpdateEngine()
		{
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x9D6CC0", Offset = "0x9D52C0", VA = "0x1809D6CC0")]
		private void FixedUpdateBuoyancy()
		{
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x9D7050", Offset = "0x9D5650", VA = "0x1809D7050")]
		private void FixedUpdateDrag(Vector3 waterSurfaceVel)
		{
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x9D76D0", Offset = "0x9D5CD0", VA = "0x1809D76D0")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x9D7B80", Offset = "0x9D6180", VA = "0x1809D7B80")]
		public BoatProbes()
		{
		}

		// Token: 0x04000084 RID: 132
		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x20")]
		[Header("Forces")]
		[Tooltip("Override RB center of mass, in local space.")]
		[SerializeField]
		private Vector3 _centerOfMass;

		// Token: 0x04000085 RID: 133
		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[FormerlySerializedAs("ForcePoints")]
		private FloaterForcePoints[] _forcePoints;

		// Token: 0x04000086 RID: 134
		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("Vertical offset for where engine force should be applied.")]
		[SerializeField]
		private float _forceHeightOffset;

		// Token: 0x04000087 RID: 135
		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _forceMultiplier;

		// Token: 0x04000088 RID: 136
		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("Width dimension of boat. The larger this value, the more filtered/smooth the wave response will be.")]
		[SerializeField]
		private float _minSpatialLength;

		// Token: 0x04000089 RID: 137
		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _turningHeel;

		// Token: 0x0400008A RID: 138
		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x48")]
		[Header("Drag")]
		[SerializeField]
		private float _dragInWaterUp;

		// Token: 0x0400008B RID: 139
		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float _dragInWaterRight;

		// Token: 0x0400008C RID: 140
		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _dragInWaterForward;

		// Token: 0x0400008D RID: 141
		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x54")]
		[FormerlySerializedAs("EnginePower")]
		[Header("Control")]
		[SerializeField]
		private float _enginePower;

		// Token: 0x0400008E RID: 142
		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[FormerlySerializedAs("TurnPower")]
		private float _turnPower;

		// Token: 0x0400008F RID: 143
		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private bool _playerControlled;

		// Token: 0x04000090 RID: 144
		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x60")]
		[Tooltip("Used to automatically add throttle input")]
		[SerializeField]
		private float _engineBias;

		// Token: 0x04000091 RID: 145
		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x64")]
		[Tooltip("Used to automatically add turning input")]
		[SerializeField]
		private float _turnBias;

		// Token: 0x04000092 RID: 146
		[Token(Token = "0x4000092")]
		private const float WATER_DENSITY = 1000f;

		// Token: 0x04000093 RID: 147
		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x68")]
		private Rigidbody _rb;

		// Token: 0x04000094 RID: 148
		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x70")]
		private float _totalWeight;

		// Token: 0x04000095 RID: 149
		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x78")]
		private Vector3[] _queryPoints;

		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x80")]
		private Vector3[] _queryResultDisps;

		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x88")]
		private Vector3[] _queryResultVels;

		// Token: 0x04000098 RID: 152
		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x90")]
		private SampleFlowHelper _sampleFlowHelper;
	}
}
