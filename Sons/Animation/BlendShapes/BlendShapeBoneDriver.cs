using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation.BlendShapes
{
	// Token: 0x02000961 RID: 2401
	[Token(Token = "0x2000961")]
	public class BlendShapeBoneDriver : MonoBehaviour
	{
		// Token: 0x0600459E RID: 17822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600459E")]
		[Address(RVA = "0x3666D70", Offset = "0x3665370", VA = "0x183666D70")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600459F RID: 17823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600459F")]
		[Address(RVA = "0x3666D80", Offset = "0x3665380", VA = "0x183666D80")]
		private void UpdateBlendShapes()
		{
		}

		// Token: 0x060045A0 RID: 17824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045A0")]
		[Address(RVA = "0x3667160", Offset = "0x3665760", VA = "0x183667160")]
		public BlendShapeBoneDriver()
		{
		}

		// Token: 0x0400480A RID: 18442
		[Token(Token = "0x400480A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _bone;

		// Token: 0x0400480B RID: 18443
		[Token(Token = "0x400480B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _multiplier;

		// Token: 0x0400480C RID: 18444
		[Token(Token = "0x400480C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SkinnedMeshRenderer _skinnedMesh;

		// Token: 0x0400480D RID: 18445
		[Token(Token = "0x400480D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<BlendShapeBoneDriver.ShapeDriver> _shapeDrivers;

		// Token: 0x0400480E RID: 18446
		[Token(Token = "0x400480E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _debugLog;

		// Token: 0x02000962 RID: 2402
		[Token(Token = "0x2000962")]
		public enum KeyChannel
		{
			// Token: 0x04004810 RID: 18448
			[Token(Token = "0x4004810")]
			TranslateX,
			// Token: 0x04004811 RID: 18449
			[Token(Token = "0x4004811")]
			TranslateY,
			// Token: 0x04004812 RID: 18450
			[Token(Token = "0x4004812")]
			TranslateZ
		}

		// Token: 0x02000963 RID: 2403
		[Token(Token = "0x2000963")]
		[Serializable]
		public class ShapeDriver
		{
			// Token: 0x060045A1 RID: 17825 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60045A1")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public ShapeDriver()
			{
			}

			// Token: 0x04004813 RID: 18451
			[Token(Token = "0x4004813")]
			[FieldOffset(Offset = "0x10")]
			public string Description;

			// Token: 0x04004814 RID: 18452
			[Token(Token = "0x4004814")]
			[FieldOffset(Offset = "0x18")]
			public BlendShapeBoneDriver.KeyChannel KeyChannel;

			// Token: 0x04004815 RID: 18453
			[Token(Token = "0x4004815")]
			[FieldOffset(Offset = "0x1C")]
			public int ShapeIndex;
		}
	}
}
