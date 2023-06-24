using System;
using Endnight.Utilities.Timer;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Multiplayer
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	public class AutoSelfDestruct : MonoBehaviour
	{
		// Token: 0x0600001D RID: 29 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x30D1780", Offset = "0x30CFD80", VA = "0x1830D1780")]
		public void SetTimer(float selfDestructTimer)
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x30D17A0", Offset = "0x30CFDA0", VA = "0x1830D17A0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x30D17B0", Offset = "0x30CFDB0", VA = "0x1830D17B0")]
		private void InitializeTimer()
		{
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x30D18A0", Offset = "0x30CFEA0", VA = "0x1830D18A0")]
		private void Update()
		{
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x30D1A20", Offset = "0x30D0020", VA = "0x1830D1A20")]
		public AutoSelfDestruct()
		{
		}

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _selfDestructTimer;

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x28")]
		private AutoTimer _destroyTimer;
	}
}
