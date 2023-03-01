using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Lighting
{
	// Token: 0x02000574 RID: 1396
	[Token(Token = "0x2000574")]
	[AddComponentMenu("Sons/Lighting/Light Probe Volume Generator")]
	public class LightProbeVolumeGenerator : MonoBehaviour
	{
		// Token: 0x06002436 RID: 9270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002436")]
		[Address(RVA = "0x2D85090", Offset = "0x2D84090", VA = "0x182D85090")]
		private void OnValidate()
		{
		}

		// Token: 0x06002437 RID: 9271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002437")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		private void DoApply()
		{
		}

		// Token: 0x06002438 RID: 9272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002438")]
		[Address(RVA = "0x2D841B0", Offset = "0x2D831B0", VA = "0x182D841B0")]
		private void DoGenerate()
		{
		}

		// Token: 0x06002439 RID: 9273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002439")]
		[Address(RVA = "0x2D84130", Offset = "0x2D83130", VA = "0x182D84130")]
		private void CollectChildColliders()
		{
		}

		// Token: 0x0600243A RID: 9274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600243A")]
		[Address(RVA = "0x2D84F50", Offset = "0x2D83F50", VA = "0x182D84F50")]
		private void DrawCross(Vector3 point, Vector3 size)
		{
		}

		// Token: 0x0600243B RID: 9275 RVA: 0x0000A680 File Offset: 0x00008880
		[Token(Token = "0x600243B")]
		[Address(RVA = "0x2D85130", Offset = "0x2D84130", VA = "0x182D85130")]
		private Vector3 UpdateMax(Vector3 max, Vector3 point)
		{
			return default(Vector3);
		}

		// Token: 0x0600243C RID: 9276 RVA: 0x0000A698 File Offset: 0x00008898
		[Token(Token = "0x600243C")]
		[Address(RVA = "0x2D85180", Offset = "0x2D84180", VA = "0x182D85180")]
		private static Vector3 UpdateMin(Vector3 min, Vector3 point)
		{
			return default(Vector3);
		}

		// Token: 0x0600243D RID: 9277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600243D")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public LightProbeVolumeGenerator()
		{
		}

		// Token: 0x0400208D RID: 8333
		[Token(Token = "0x400208D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Collider> _colliders;

		// Token: 0x0400208E RID: 8334
		[Token(Token = "0x400208E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Tooltip("Distance between probe points")]
		private Vector3 _stepSize;

		// Token: 0x0400208F RID: 8335
		[Token(Token = "0x400208F")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private bool _autoCollectChildColliders;

		// Token: 0x04002090 RID: 8336
		[Token(Token = "0x4002090")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private LightProbeGroup _lightProbeGroupTarget;

		// Token: 0x04002091 RID: 8337
		[Token(Token = "0x4002091")]
		[FieldOffset(Offset = "0x40")]
		private List<Vector3> _validPoints;
	}
}
