using System;
using System.Collections.Generic;
using Endnight.Types;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Atmosphere
{
	// Token: 0x02000055 RID: 85
	[Token(Token = "0x2000055")]
	public class WaterHeightManager : SingletonBehaviour<WaterHeightManager>
	{
		// Token: 0x0600027B RID: 635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027B")]
		[Address(RVA = "0x2D52030", Offset = "0x2D50630", VA = "0x182D52030", Slot = "7")]
		protected override void PostAwake()
		{
		}

		// Token: 0x0600027C RID: 636 RVA: 0x000031E0 File Offset: 0x000013E0
		[Token(Token = "0x600027C")]
		[Address(RVA = "0x2D520C0", Offset = "0x2D506C0", VA = "0x182D520C0")]
		public static float GetWaterHeight()
		{
			return 0f;
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027D")]
		[Address(RVA = "0x2D52160", Offset = "0x2D50760", VA = "0x182D52160")]
		private void Update()
		{
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027E")]
		[Address(RVA = "0x2D523B0", Offset = "0x2D509B0", VA = "0x182D523B0")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027F")]
		[Address(RVA = "0x2D525A0", Offset = "0x2D50BA0", VA = "0x182D525A0")]
		private void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000280")]
		[Address(RVA = "0x2D52750", Offset = "0x2D50D50", VA = "0x182D52750")]
		private void RecalculateMaxColliderY()
		{
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000281")]
		[Address(RVA = "0x2D529A0", Offset = "0x2D50FA0", VA = "0x182D529A0")]
		public static void Initialize()
		{
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000282")]
		[Address(RVA = "0x2D52A40", Offset = "0x2D51040", VA = "0x182D52A40")]
		public WaterHeightManager()
		{
		}

		// Token: 0x04000249 RID: 585
		[Token(Token = "0x4000249")]
		private const float DefaultHeight = -100f;

		// Token: 0x0400024A RID: 586
		[Token(Token = "0x400024A")]
		[FieldOffset(Offset = "0x28")]
		private List<WaterVolumeTrigger> _triggers;

		// Token: 0x0400024B RID: 587
		[Token(Token = "0x400024B")]
		[FieldOffset(Offset = "0x30")]
		private List<Collider> _colliders;

		// Token: 0x0400024C RID: 588
		[Token(Token = "0x400024C")]
		[FieldOffset(Offset = "0x38")]
		private float _waterHeight;

		// Token: 0x0400024D RID: 589
		[Token(Token = "0x400024D")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private LayerMask _waterLayerMask;

		// Token: 0x0400024E RID: 590
		[Token(Token = "0x400024E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _sampleOffset;

		// Token: 0x0400024F RID: 591
		[Token(Token = "0x400024F")]
		[FieldOffset(Offset = "0x44")]
		private float _maxColliderY;
	}
}
