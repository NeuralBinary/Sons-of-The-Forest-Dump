using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Sons.Multiplayer
{
	// Token: 0x02000034 RID: 52
	[Token(Token = "0x2000034")]
	public class MultiplayerRespawnTimer : MonoBehaviour
	{
		// Token: 0x1400000A RID: 10
		// (add) Token: 0x060001B2 RID: 434 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060001B3 RID: 435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400000A")]
		public event Action OnRespawn
		{
			[Token(Token = "0x60001B2")]
			[Address(RVA = "0x30EAE40", Offset = "0x30E9440", VA = "0x1830EAE40")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0x30EAF30", Offset = "0x30E9530", VA = "0x1830EAF30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x30EB020", Offset = "0x30E9620", VA = "0x1830EB020")]
		private void SetFillAmount(float fillAmount)
		{
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x30EB060", Offset = "0x30E9660", VA = "0x1830EB060")]
		private void Update()
		{
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x30EB260", Offset = "0x30E9860", VA = "0x1830EB260")]
		private void DoRespawn()
		{
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x30EB330", Offset = "0x30E9930", VA = "0x1830EB330")]
		public void Dispose()
		{
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x30EB3B0", Offset = "0x30E99B0", VA = "0x1830EB3B0")]
		public void Init(Action respawnAction)
		{
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x30EB420", Offset = "0x30E9A20", VA = "0x1830EB420")]
		public MultiplayerRespawnTimer()
		{
		}

		// Token: 0x040000BE RID: 190
		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _fillImage;

		// Token: 0x040000BF RID: 191
		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _minFillValue;

		// Token: 0x040000C0 RID: 192
		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _maxFillValue;

		// Token: 0x040000C1 RID: 193
		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _autoRespawnTimer;

		// Token: 0x040000C2 RID: 194
		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x34")]
		private float _startTime;
	}
}
