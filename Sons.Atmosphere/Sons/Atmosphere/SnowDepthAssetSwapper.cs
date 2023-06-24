using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Atmosphere
{
	// Token: 0x0200004A RID: 74
	[Token(Token = "0x200004A")]
	public class SnowDepthAssetSwapper : MonoBehaviour
	{
		// Token: 0x0600020C RID: 524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020C")]
		[Address(RVA = "0x2D4A830", Offset = "0x2D48E30", VA = "0x182D4A830")]
		private void Update()
		{
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020D")]
		[Address(RVA = "0x2D4A9B0", Offset = "0x2D48FB0", VA = "0x182D4A9B0")]
		private void UpdateObjectLists(bool inSnow)
		{
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020E")]
		[Address(RVA = "0x2D4ACC0", Offset = "0x2D492C0", VA = "0x182D4ACC0")]
		public SnowDepthAssetSwapper()
		{
		}

		// Token: 0x040001CD RID: 461
		[Token(Token = "0x40001CD")]
		[FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		[SerializeField]
		private float _enableAtSnowDepth;

		// Token: 0x040001CE RID: 462
		[Token(Token = "0x40001CE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		public List<GameObject> _objectsActiveInSnow;

		// Token: 0x040001CF RID: 463
		[Token(Token = "0x40001CF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		public List<GameObject> _objectsActiveOutOfSnow;

		// Token: 0x040001D0 RID: 464
		[Token(Token = "0x40001D0")]
		[FieldOffset(Offset = "0x38")]
		private bool _inSnow;
	}
}
