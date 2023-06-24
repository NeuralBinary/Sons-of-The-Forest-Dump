using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

namespace Sons.VFX
{
	// Token: 0x0200001F RID: 31
	[Token(Token = "0x200001F")]
	[AddComponentMenu("Sons/VFX/FlipbookLightCookie")]
	public class FlipbookLightCookie : MonoBehaviour
	{
		// Token: 0x0600009F RID: 159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x31710C0", Offset = "0x316F6C0", VA = "0x1831710C0")]
		private void OnValidate()
		{
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x31711F0", Offset = "0x316F7F0", VA = "0x1831711F0")]
		private void UpdateLightData()
		{
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x31713F0", Offset = "0x316F9F0", VA = "0x1831713F0")]
		private void Update()
		{
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x3171670", Offset = "0x316FC70", VA = "0x183171670")]
		public FlipbookLightCookie()
		{
		}

		// Token: 0x040000C9 RID: 201
		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Light _lightSource;

		// Token: 0x040000CA RID: 202
		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _fps;

		// Token: 0x040000CB RID: 203
		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<Texture> _sequence;

		// Token: 0x040000CC RID: 204
		[Token(Token = "0x40000CC")]
		[FieldOffset(Offset = "0x38")]
		private Light _cachedLightSource;

		// Token: 0x040000CD RID: 205
		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x40")]
		private int _currentIndex;

		// Token: 0x040000CE RID: 206
		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x44")]
		private float _timer;

		// Token: 0x040000CF RID: 207
		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x48")]
		private HDAdditionalLightData _additionalLightData;
	}
}
