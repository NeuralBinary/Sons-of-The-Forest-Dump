using System;
using Endnight.Types;
using Il2CppDummyDll;
using Sons.Areas;
using UnityEngine;

namespace Sons.Atmosphere
{
	// Token: 0x02000022 RID: 34
	[Token(Token = "0x2000022")]
	public class AmbientManager : SingletonBehaviour<AmbientManager>
	{
		// Token: 0x060000F6 RID: 246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x2D3AEC0", Offset = "0x2D394C0", VA = "0x182D3AEC0")]
		private void OnEnable()
		{
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x2D3AFA0", Offset = "0x2D395A0", VA = "0x182D3AFA0")]
		private void OnDisable()
		{
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x2D3B010", Offset = "0x2D39610", VA = "0x182D3B010")]
		private void OnAreaMaskChanged(AreaMask oldMask, AreaMask areaMask, PlayerType playerType)
		{
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00002940 File Offset: 0x00000B40
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x2D3B040", Offset = "0x2D39640", VA = "0x182D3B040")]
		public static float GetAmbientIntensity()
		{
			return 0f;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x2D3B0E0", Offset = "0x2D396E0", VA = "0x182D3B0E0")]
		public AmbientManager()
		{
		}

		// Token: 0x040000D3 RID: 211
		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _bunkerAmbient;

		// Token: 0x040000D4 RID: 212
		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _caveAmbient;

		// Token: 0x040000D5 RID: 213
		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x30")]
		private bool _overrideAmbient;

		// Token: 0x040000D6 RID: 214
		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x34")]
		private float _overrideAmbientValue;
	}
}
