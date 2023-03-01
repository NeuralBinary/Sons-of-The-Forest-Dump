using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation.BlendShapes
{
	// Token: 0x020008E1 RID: 2273
	[Token(Token = "0x20008E1")]
	public class BlendShapeBoneDriver : MonoBehaviour
	{
		// Token: 0x06003DD3 RID: 15827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DD3")]
		[Address(RVA = "0x2F0DA10", Offset = "0x2F0CA10", VA = "0x182F0DA10")]
		private void LateUpdate()
		{
		}

		// Token: 0x06003DD4 RID: 15828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DD4")]
		[Address(RVA = "0x2F0DA20", Offset = "0x2F0CA20", VA = "0x182F0DA20")]
		private void UpdateBlendShapes()
		{
		}

		// Token: 0x06003DD5 RID: 15829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DD5")]
		[Address(RVA = "0x2F0DD60", Offset = "0x2F0CD60", VA = "0x182F0DD60")]
		public BlendShapeBoneDriver()
		{
		}

		// Token: 0x04004190 RID: 16784
		[Token(Token = "0x4004190")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _bone;

		// Token: 0x04004191 RID: 16785
		[Token(Token = "0x4004191")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _multiplier;

		// Token: 0x04004192 RID: 16786
		[Token(Token = "0x4004192")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SkinnedMeshRenderer _skinnedMesh;

		// Token: 0x04004193 RID: 16787
		[Token(Token = "0x4004193")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<BlendShapeBoneDriver.ShapeDriver> _shapeDrivers;

		// Token: 0x04004194 RID: 16788
		[Token(Token = "0x4004194")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _debugLog;

		// Token: 0x020008E2 RID: 2274
		[Token(Token = "0x20008E2")]
		public enum KeyChannel
		{
			// Token: 0x04004196 RID: 16790
			[Token(Token = "0x4004196")]
			TranslateX,
			// Token: 0x04004197 RID: 16791
			[Token(Token = "0x4004197")]
			TranslateY,
			// Token: 0x04004198 RID: 16792
			[Token(Token = "0x4004198")]
			TranslateZ
		}

		// Token: 0x020008E3 RID: 2275
		[Token(Token = "0x20008E3")]
		[Serializable]
		public class ShapeDriver
		{
			// Token: 0x06003DD6 RID: 15830 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003DD6")]
			[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
			public ShapeDriver()
			{
			}

			// Token: 0x04004199 RID: 16793
			[Token(Token = "0x4004199")]
			[FieldOffset(Offset = "0x10")]
			public string Description;

			// Token: 0x0400419A RID: 16794
			[Token(Token = "0x400419A")]
			[FieldOffset(Offset = "0x18")]
			public BlendShapeBoneDriver.KeyChannel KeyChannel;

			// Token: 0x0400419B RID: 16795
			[Token(Token = "0x400419B")]
			[FieldOffset(Offset = "0x1C")]
			public int ShapeIndex;
		}
	}
}
