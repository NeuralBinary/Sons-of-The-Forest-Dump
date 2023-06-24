using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Multiplayer.Gui
{
	// Token: 0x02000051 RID: 81
	[Token(Token = "0x2000051")]
	[CreateAssetMenu(fileName = "PlayerColors", menuName = "Sons/Data/PlayerColors")]
	public class PlayerColors : ScriptableObject
	{
		// Token: 0x0600028F RID: 655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028F")]
		[Address(RVA = "0x30F6460", Offset = "0x30F4A60", VA = "0x1830F6460")]
		private void GenerateRandom()
		{
		}

		// Token: 0x06000290 RID: 656 RVA: 0x000030A8 File Offset: 0x000012A8
		[Token(Token = "0x6000290")]
		[Address(RVA = "0x30F6640", Offset = "0x30F4C40", VA = "0x1830F6640")]
		private Color GenRandom(double goldenRatioConjugate, double h)
		{
			return default(Color);
		}

		// Token: 0x06000291 RID: 657 RVA: 0x000030C0 File Offset: 0x000012C0
		[Token(Token = "0x6000291")]
		[Address(RVA = "0x30F66A0", Offset = "0x30F4CA0", VA = "0x1830F66A0")]
		public Color GetPlayerColor(int playerIndex)
		{
			return default(Color);
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000292")]
		[Address(RVA = "0x30F67D0", Offset = "0x30F4DD0", VA = "0x1830F67D0")]
		public PlayerColors()
		{
		}

		// Token: 0x04000149 RID: 329
		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<Color> _playerColors;

		// Token: 0x0400014A RID: 330
		[Token(Token = "0x400014A")]
		private const float GoldenRatioConjugate = 0.618034f;
	}
}
