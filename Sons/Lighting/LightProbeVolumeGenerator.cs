using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Lighting
{
	// Token: 0x02000584 RID: 1412
	[Token(Token = "0x2000584")]
	[AddComponentMenu("Sons/Lighting/Light Probe Volume Generator")]
	public class LightProbeVolumeGenerator : MonoBehaviour
	{
		// Token: 0x06002535 RID: 9525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002535")]
		[Address(RVA = "0x3399130", Offset = "0x3397730", VA = "0x183399130")]
		private void OnValidate()
		{
		}

		// Token: 0x06002536 RID: 9526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002536")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void DoApply()
		{
		}

		// Token: 0x06002537 RID: 9527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002537")]
		[Address(RVA = "0x3399260", Offset = "0x3397860", VA = "0x183399260")]
		private void DoGenerate()
		{
		}

		// Token: 0x06002538 RID: 9528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002538")]
		[Address(RVA = "0x339A1F0", Offset = "0x33987F0", VA = "0x18339A1F0")]
		private void CollectChildColliders()
		{
		}

		// Token: 0x06002539 RID: 9529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002539")]
		[Address(RVA = "0x339A320", Offset = "0x3398920", VA = "0x18339A320")]
		private void DrawCross(Vector3 point, Vector3 size)
		{
		}

		// Token: 0x0600253A RID: 9530 RVA: 0x0000AD40 File Offset: 0x00008F40
		[Token(Token = "0x600253A")]
		[Address(RVA = "0x339A510", Offset = "0x3398B10", VA = "0x18339A510")]
		private Vector3 UpdateMax(Vector3 max, Vector3 point)
		{
			return default(Vector3);
		}

		// Token: 0x0600253B RID: 9531 RVA: 0x0000AD58 File Offset: 0x00008F58
		[Token(Token = "0x600253B")]
		[Address(RVA = "0x339A560", Offset = "0x3398B60", VA = "0x18339A560")]
		private static Vector3 UpdateMin(Vector3 min, Vector3 point)
		{
			return default(Vector3);
		}

		// Token: 0x0600253C RID: 9532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600253C")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public LightProbeVolumeGenerator()
		{
		}

		// Token: 0x04002161 RID: 8545
		[Token(Token = "0x4002161")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Collider> _colliders;

		// Token: 0x04002162 RID: 8546
		[Token(Token = "0x4002162")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Tooltip("Distance between probe points")]
		private Vector3 _stepSize;

		// Token: 0x04002163 RID: 8547
		[Token(Token = "0x4002163")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private bool _autoCollectChildColliders;

		// Token: 0x04002164 RID: 8548
		[Token(Token = "0x4002164")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private LightProbeGroup _lightProbeGroupTarget;

		// Token: 0x04002165 RID: 8549
		[Token(Token = "0x4002165")]
		[FieldOffset(Offset = "0x40")]
		private List<Vector3> _validPoints;
	}
}
