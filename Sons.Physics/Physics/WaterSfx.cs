using System;
using FMOD.Studio;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Physics
{
	// Token: 0x02000023 RID: 35
	[Token(Token = "0x2000023")]
	public class WaterSfx : MonoBehaviour
	{
		// Token: 0x060000F6 RID: 246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x310F580", Offset = "0x310DB80", VA = "0x18310F580")]
		private void Update()
		{
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x310F8E0", Offset = "0x310DEE0", VA = "0x18310F8E0")]
		public WaterSfx()
		{
		}

		// Token: 0x04000111 RID: 273
		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Buoyancy _buoyancy;

		// Token: 0x04000112 RID: 274
		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _splashSpeedMinimum;

		// Token: 0x04000113 RID: 275
		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _splashSpeedMaximum;

		// Token: 0x04000114 RID: 276
		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _splashEventPath;

		// Token: 0x04000115 RID: 277
		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _onOceanEventPath;

		// Token: 0x04000116 RID: 278
		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _targetTransform;

		// Token: 0x04000117 RID: 279
		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x48")]
		private EventInstance _onOceanInstance;

		// Token: 0x04000118 RID: 280
		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x50")]
		private bool _submerged;
	}
}
