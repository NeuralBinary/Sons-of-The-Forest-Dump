using System;
using System.Collections.Generic;
using Crest;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Physics
{
	// Token: 0x02000022 RID: 34
	[Token(Token = "0x2000022")]
	public class WaterLevelSensor : MonoBehaviour
	{
		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00002430 File Offset: 0x00000630
		[Token(Token = "0x17000018")]
		public bool InWater
		{
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x310A0E0", Offset = "0x31086E0", VA = "0x18310A0E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00002448 File Offset: 0x00000648
		[Token(Token = "0x17000019")]
		public float CachedWaterHeight
		{
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x23BFBF0", Offset = "0x23BE1F0", VA = "0x1823BFBF0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x00002460 File Offset: 0x00000660
		[Token(Token = "0x1700001A")]
		public float CachedWaterDepth
		{
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0xA53160", Offset = "0xA51760", VA = "0x180A53160")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x00002478 File Offset: 0x00000678
		[Token(Token = "0x1700001B")]
		public Vector3 CachedWaterNormal
		{
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x1FED010", Offset = "0x1FEB610", VA = "0x181FED010")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000DA RID: 218 RVA: 0x00002490 File Offset: 0x00000690
		[Token(Token = "0x1700001C")]
		public Vector3 CachedWaterSurfaceVelocity
		{
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x23BB6E0", Offset = "0x23B9CE0", VA = "0x1823BB6E0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x060000DB RID: 219 RVA: 0x000024A8 File Offset: 0x000006A8
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x310A1F0", Offset = "0x31087F0", VA = "0x18310A1F0")]
		private bool ManualOnTriggerStayCheckColliderBox(BoxCollider stayBoxCollider)
		{
			return default(bool);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x000024C0 File Offset: 0x000006C0
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x310A670", Offset = "0x3108C70", VA = "0x18310A670")]
		private bool ManualOnTriggerStayCheckColliderCapsule(CapsuleCollider stayCapsuleCollider)
		{
			return default(bool);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x310ABE0", Offset = "0x31091E0", VA = "0x18310ABE0")]
		private void ProcessInsideColliderResults(int count)
		{
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x310AF30", Offset = "0x3109530", VA = "0x18310AF30")]
		public void ForceReset()
		{
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x310B020", Offset = "0x3109620", VA = "0x18310B020")]
		private void OnValidate()
		{
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x310B350", Offset = "0x3109950", VA = "0x18310B350")]
		private void Update()
		{
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x310B660", Offset = "0x3109C60", VA = "0x18310B660")]
		private void UpdateTriggerStay()
		{
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x310B9D0", Offset = "0x3109FD0", VA = "0x18310B9D0")]
		private void CleanUpTrackedColliders()
		{
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x310BCE0", Offset = "0x310A2E0", VA = "0x18310BCE0")]
		public void UpdateWaterDataCache()
		{
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x000024D8 File Offset: 0x000006D8
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x310C5F0", Offset = "0x310ABF0", VA = "0x18310C5F0")]
		private static float GetOceanSeaLevel()
		{
			return 0f;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x310C790", Offset = "0x310AD90", VA = "0x18310C790")]
		private void Reset()
		{
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x310C820", Offset = "0x310AE20", VA = "0x18310C820")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x310CE80", Offset = "0x310B480", VA = "0x18310CE80")]
		private void OnDrawGizmosSelected(Collider lastWaterCollider)
		{
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x310D9B0", Offset = "0x310BFB0", VA = "0x18310D9B0")]
		public void GetWaterLevel(out bool isInWater, out float waterLevel, out float waterDepth)
		{
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x310DAA0", Offset = "0x310C0A0", VA = "0x18310DAA0")]
		public void GetWaterLevel(out bool isInWater, out float waterLevel, out float waterDepth, out float waterVolumeLevel, out Vector3 normal, out Vector3 surfaceVel, out Collider hitCollider)
		{
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x310DBD0", Offset = "0x310C1D0", VA = "0x18310DBD0")]
		private void GetOceanWaterLevel(Vector3 iQueryPos, out Vector3 displacementToPoint, out Vector3 normal, out Vector3 waterSurfaceVel)
		{
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x310DD10", Offset = "0x310C310", VA = "0x18310DD10")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x310DE10", Offset = "0x310C410", VA = "0x18310DE10")]
		private void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x310DEA0", Offset = "0x310C4A0", VA = "0x18310DEA0")]
		private void TryAddCollider(Collider other)
		{
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x310DE10", Offset = "0x310C410", VA = "0x18310DE10")]
		private void TryRemoveCollider(Collider other)
		{
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x310E060", Offset = "0x310C660", VA = "0x18310E060")]
		private void RemoveCollider(Collider other, int index)
		{
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x000024F0 File Offset: 0x000006F0
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x310E350", Offset = "0x310C950", VA = "0x18310E350")]
		private static bool RayCastWaterLevel(Vector3 sourcePos, List<Collider> sourceWaterColliders, LayerMask waterLayerMask, LayerMask blockerLayerMask, out float waterLevel, out float waterDepth, out Vector3 waterNormal, out float waterVolumeLevel, out Collider hitCollider)
		{
			return default(bool);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00002508 File Offset: 0x00000708
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x310EAB0", Offset = "0x310D0B0", VA = "0x18310EAB0")]
		private float GetWaterDepth(Vector3 position, float maxDepth = 30f)
		{
			return 0f;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00002520 File Offset: 0x00000720
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x310EC40", Offset = "0x310D240", VA = "0x18310EC40")]
		private static bool FindWaterColliderPoint(Vector3 sourcePos, LayerMask waterLayerMask, float rayStartHeight, float maxDistance, List<Collider> sourceWaterColliders, int maxRecasts, out RaycastHit eachRaycastHit)
		{
			return default(bool);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00002538 File Offset: 0x00000738
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x310EFC0", Offset = "0x310D5C0", VA = "0x18310EFC0")]
		private static bool IsInvalidCollider(List<Collider> sourceWaterColliders, Collider hitCollider)
		{
			return default(bool);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x310F040", Offset = "0x310D640", VA = "0x18310F040")]
		public WaterLevelSensor()
		{
		}

		// Token: 0x040000F3 RID: 243
		[Token(Token = "0x40000F3")]
		private const float DefaultWaterLevel = -99999f;

		// Token: 0x040000F4 RID: 244
		[Token(Token = "0x40000F4")]
		private const float DefaultWaterDepth = 0f;

		// Token: 0x040000F5 RID: 245
		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Rigidbody _rigidBody;

		// Token: 0x040000F6 RID: 246
		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Collider _stayTriggerCollider;

		// Token: 0x040000F7 RID: 247
		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _autoUpdate;

		// Token: 0x040000F8 RID: 248
		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x31")]
		[SerializeField]
		private bool _refreshOnTrigger;

		// Token: 0x040000F9 RID: 249
		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<string> _tagFilter;

		// Token: 0x040000FA RID: 250
		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private int _triggerStayCheckInterval;

		// Token: 0x040000FB RID: 251
		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x44")]
		[FormerlySerializedAs("_depthLayerMask")]
		[SerializeField]
		private LayerMask _blockerLayerMask;

		// Token: 0x040000FC RID: 252
		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[HideInInspector]
		private LayerMask _waterAndBlockerMask;

		// Token: 0x040000FD RID: 253
		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private LayerMask _waterLayerMask;

		// Token: 0x040000FE RID: 254
		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _objectWidth;

		// Token: 0x040000FF RID: 255
		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0x54")]
		private bool _isInWater;

		// Token: 0x04000100 RID: 256
		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0x55")]
		private bool _isInOcean;

		// Token: 0x04000101 RID: 257
		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0x58")]
		private float _cachedWaterHeight;

		// Token: 0x04000102 RID: 258
		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0x5C")]
		private Vector3 _cachedWaterNormal;

		// Token: 0x04000103 RID: 259
		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0x68")]
		private float _cachedWaterDepth;

		// Token: 0x04000104 RID: 260
		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0x6C")]
		private int _cacheFrame;

		// Token: 0x04000105 RID: 261
		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0x70")]
		private float _waterVolumeLevelCache;

		// Token: 0x04000106 RID: 262
		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0x74")]
		private Vector3 _cachedWaterSurfaceVelocity;

		// Token: 0x04000107 RID: 263
		[Token(Token = "0x4000107")]
		[FieldOffset(Offset = "0x80")]
		private Collider _lastWaterCollider;

		// Token: 0x04000108 RID: 264
		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0x88")]
		private List<Collider> _trackedColliders;

		// Token: 0x04000109 RID: 265
		[Token(Token = "0x4000109")]
		[FieldOffset(Offset = "0x90")]
		private List<Collider> _trackedOceanColliders;

		// Token: 0x0400010A RID: 266
		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0x98")]
		private Collider[] _insideColliderResult;

		// Token: 0x0400010B RID: 267
		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0xA0")]
		private readonly SampleHeightHelper _sampleHeightHelper;

		// Token: 0x0400010C RID: 268
		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0xA8")]
		private readonly SampleFlowHelper _sampleFlowHelper;

		// Token: 0x0400010D RID: 269
		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0x0")]
		private static float _cachedOceanSeaLevel;

		// Token: 0x0400010E RID: 270
		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0xB0")]
		private float _triggerStayCheckIntervalOffset;

		// Token: 0x0400010F RID: 271
		[Token(Token = "0x400010F")]
		[FieldOffset(Offset = "0xB4")]
		private Vector3 _lastManualCheckPosition;

		// Token: 0x04000110 RID: 272
		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0x4")]
		private static readonly float RecastOffset;
	}
}
