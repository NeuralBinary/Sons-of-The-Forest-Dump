using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NWH.DWP2.ShipController
{
	// Token: 0x02000029 RID: 41
	[Token(Token = "0x2000029")]
	[RequireComponent(typeof(Rigidbody))]
	public class Sink : MonoBehaviour
	{
		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000181 RID: 385 RVA: 0x00002E4C File Offset: 0x0000104C
		// (set) Token: 0x06000182 RID: 386 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700005A")]
		public Vector3 FloodedCenterOfMass
		{
			[Token(Token = "0x6000181")]
			[Address(RVA = "0x2716C30", Offset = "0x2715230", VA = "0x182716C30")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000182")]
			[Address(RVA = "0x2716D30", Offset = "0x2715330", VA = "0x182716D30")]
			set
			{
			}
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000183")]
		[Address(RVA = "0x2716E20", Offset = "0x2715420", VA = "0x182716E20")]
		private void Start()
		{
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000184")]
		[Address(RVA = "0x2716F80", Offset = "0x2715580", VA = "0x182716F80")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000185")]
		[Address(RVA = "0x27171D0", Offset = "0x27157D0", VA = "0x1827171D0")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000186")]
		[Address(RVA = "0x21BE6D0", Offset = "0x21BCCD0", VA = "0x1821BE6D0")]
		public void Begin()
		{
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000187")]
		[Address(RVA = "0x22BEAF0", Offset = "0x22BD0F0", VA = "0x1822BEAF0")]
		public void Stop()
		{
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000188")]
		[Address(RVA = "0x2717360", Offset = "0x2715960", VA = "0x182717360")]
		public void Reset()
		{
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000189")]
		[Address(RVA = "0x2717450", Offset = "0x2715A50", VA = "0x182717450")]
		public Sink()
		{
		}

		// Token: 0x04000157 RID: 343
		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Ingress point in local coordinates. Indicated by a red sphere gizmo.")]
		public Vector3 floodedCenterOfMass;

		// Token: 0x04000158 RID: 344
		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0x2C")]
		[Range(0f, 1f)]
		[Tooltip("How much should center of mass drift due to water ingress. 0 = none, 1 = center of mass will move to ingress point, 0-1 = in-between.")]
		public float centerOfMassDriftPercent;

		// Token: 0x04000159 RID: 345
		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("Percentage of initial mass that will be added each second to imitate water ingress")]
		public float addedMassPercentPerSecond;

		// Token: 0x0400015A RID: 346
		[Token(Token = "0x400015A")]
		[FieldOffset(Offset = "0x34")]
		[Tooltip("Maximum added mass after water ingress. 1f = 100% of orginal mass, 2f = 200% of original mass, etc.")]
		public float maxMassPercent;

		// Token: 0x0400015B RID: 347
		[Token(Token = "0x400015B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Tooltip("Should the ship sink? Call Begin() to initialize sinking from script.")]
		private bool sink;

		// Token: 0x0400015C RID: 348
		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0x3C")]
		private float initialMass;

		// Token: 0x0400015D RID: 349
		[Token(Token = "0x400015D")]
		[FieldOffset(Offset = "0x40")]
		private Vector3 initialLocalCOM;

		// Token: 0x0400015E RID: 350
		[Token(Token = "0x400015E")]
		[FieldOffset(Offset = "0x50")]
		private Rigidbody rb;
	}
}
