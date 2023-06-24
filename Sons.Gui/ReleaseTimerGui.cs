using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Sons.Gui
{
	// Token: 0x0200002D RID: 45
	[Token(Token = "0x200002D")]
	[AddComponentMenu("Sons/Gui/ReleaseTimerGui")]
	public class ReleaseTimerGui : MonoBehaviour
	{
		// Token: 0x06000109 RID: 265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x300D600", Offset = "0x300BC00", VA = "0x18300D600")]
		private void RefreshVersionReadout()
		{
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x300D930", Offset = "0x300BF30", VA = "0x18300D930")]
		private void Start()
		{
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x300D930", Offset = "0x300BF30", VA = "0x18300D930")]
		private void Update()
		{
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x300D940", Offset = "0x300BF40", VA = "0x18300D940")]
		public ReleaseTimerGui()
		{
		}

		// Token: 0x04000119 RID: 281
		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TMP_Text _timerText;

		// Token: 0x0400011A RID: 282
		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0x28")]
		private int _lastUpdateFrame;

		// Token: 0x0400011B RID: 283
		[Token(Token = "0x400011B")]
		private const int TimeSlicedUpdate = 2000;
	}
}
