using System;
using Crest;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Physics
{
	// Token: 0x02000021 RID: 33
	[Token(Token = "0x2000021")]
	public class WaterForce : MonoBehaviour
	{
		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000CB RID: 203 RVA: 0x000023E8 File Offset: 0x000005E8
		[Token(Token = "0x17000017")]
		private bool InWater
		{
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x3108B80", Offset = "0x3107180", VA = "0x183108B80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x13428C0", Offset = "0x1340EC0", VA = "0x1813428C0")]
		private void SetInWaterQuery(Func<bool> inWaterQuery)
		{
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x3108C60", Offset = "0x3107260", VA = "0x183108C60")]
		private void Awake()
		{
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x3108D50", Offset = "0x3107350", VA = "0x183108D50")]
		private void FixedUpdate()
		{
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00002400 File Offset: 0x00000600
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x3108E50", Offset = "0x3107450", VA = "0x183108E50")]
		private bool ShouldRun()
		{
			return default(bool);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x3108F60", Offset = "0x3107560", VA = "0x183108F60")]
		private void ApplyWaterForce()
		{
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00002418 File Offset: 0x00000618
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x3109430", Offset = "0x3107A30", VA = "0x183109430")]
		private float CalculateDepthScale(float waterDepthDifference)
		{
			return 0f;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x3109490", Offset = "0x3107A90", VA = "0x183109490")]
		private void GetWaterLevel(out float height, out Vector3 normal, out Vector3 surfaceVel)
		{
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x3109590", Offset = "0x3107B90", VA = "0x183109590")]
		private void UpdateWaterDataCache()
		{
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x3109680", Offset = "0x3107C80", VA = "0x183109680")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x3109F50", Offset = "0x3108550", VA = "0x183109F50")]
		public WaterForce()
		{
		}

		// Token: 0x040000DF RID: 223
		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0x20")]
		private float _waterLevelCache;

		// Token: 0x040000E0 RID: 224
		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0x24")]
		private Vector3 _waterNormalCache;

		// Token: 0x040000E1 RID: 225
		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0x30")]
		private int _cachedWaterLevel;

		// Token: 0x040000E2 RID: 226
		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x34")]
		private Vector3 _waterSurfaceVelocityCache;

		// Token: 0x040000E3 RID: 227
		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _waterForce;

		// Token: 0x040000E4 RID: 228
		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float _waterVelocityMag;

		// Token: 0x040000E5 RID: 229
		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _waterUpwardsForce;

		// Token: 0x040000E6 RID: 230
		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x4C")]
		private Vector3 _activeWaterForce;

		// Token: 0x040000E7 RID: 231
		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _maxWaterForceAccel;

		// Token: 0x040000E8 RID: 232
		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float _waterForceLerpSpeed;

		// Token: 0x040000E9 RID: 233
		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _waterForceDecay;

		// Token: 0x040000EA RID: 234
		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private WaterLevelSensor _waterLevelSensor;

		// Token: 0x040000EB RID: 235
		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _depthFadeStart;

		// Token: 0x040000EC RID: 236
		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x74")]
		[FormerlySerializedAs("_depthFade")]
		[SerializeField]
		private float _depthFadeEnd;

		// Token: 0x040000ED RID: 237
		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Rigidbody _rigidBody;

		// Token: 0x040000EE RID: 238
		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x80")]
		private Vector3 _rootPosition;

		// Token: 0x040000EF RID: 239
		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x90")]
		private readonly SampleHeightHelper _sampleHeightHelper;

		// Token: 0x040000F0 RID: 240
		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x98")]
		private readonly SampleFlowHelper _sampleFlowHelper;

		// Token: 0x040000F1 RID: 241
		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0xA0")]
		private Transform _rootTr;

		// Token: 0x040000F2 RID: 242
		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0xA8")]
		private Func<bool> _inWaterQuery;
	}
}
