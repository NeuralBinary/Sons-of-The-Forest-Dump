using System;
using Il2CppDummyDll;
using PathologicalGames;
using UnityEngine;

namespace TheForest.Utils
{
	// Token: 0x020003D9 RID: 985
	[Token(Token = "0x20003D9")]
	public class TimedStippling : MonoBehaviour
	{
		// Token: 0x06001A4C RID: 6732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A4C")]
		[Address(RVA = "0x2CEE250", Offset = "0x2CED250", VA = "0x182CEE250")]
		private void Awake()
		{
		}

		// Token: 0x06001A4D RID: 6733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A4D")]
		[Address(RVA = "0x2CEF570", Offset = "0x2CEE570", VA = "0x182CEF570")]
		private void Update()
		{
		}

		// Token: 0x06001A4E RID: 6734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A4E")]
		[Address(RVA = "0x2CEEB90", Offset = "0x2CEDB90", VA = "0x182CEEB90")]
		private void OnEnable()
		{
		}

		// Token: 0x06001A4F RID: 6735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A4F")]
		[Address(RVA = "0x2CEF390", Offset = "0x2CEE390", VA = "0x182CEF390")]
		private void ResetStippling()
		{
		}

		// Token: 0x06001A50 RID: 6736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A50")]
		[Address(RVA = "0x2CEF520", Offset = "0x2CEE520", VA = "0x182CEF520")]
		private void StippleOut()
		{
		}

		// Token: 0x06001A51 RID: 6737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A51")]
		[Address(RVA = "0x2CEEAF0", Offset = "0x2CEDAF0", VA = "0x182CEEAF0")]
		private void OnDespawned(SpawnPool pool)
		{
		}

		// Token: 0x06001A52 RID: 6738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A52")]
		[Address(RVA = "0x2CEF4F0", Offset = "0x2CEE4F0", VA = "0x182CEF4F0")]
		private void SkipStippling()
		{
		}

		// Token: 0x06001A53 RID: 6739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A53")]
		[Address(RVA = "0x2CEF3F0", Offset = "0x2CEE3F0", VA = "0x182CEF3F0")]
		private void SetStipplingAlpha(float alpha)
		{
		}

		// Token: 0x06001A54 RID: 6740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A54")]
		[Address(RVA = "0x2CEF4F0", Offset = "0x2CEE4F0", VA = "0x182CEF4F0")]
		private void Stop()
		{
		}

		// Token: 0x06001A55 RID: 6741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A55")]
		[Address(RVA = "0x5B8DB0", Offset = "0x5B7DB0", VA = "0x1805B8DB0")]
		public TimedStippling()
		{
		}

		// Token: 0x0400197C RID: 6524
		[Token(Token = "0x400197C")]
		[FieldOffset(Offset = "0x20")]
		public Renderer _renderer;

		// Token: 0x0400197D RID: 6525
		[Token(Token = "0x400197D")]
		[FieldOffset(Offset = "0x28")]
		public bool _handleRendererState;

		// Token: 0x0400197E RID: 6526
		[Token(Token = "0x400197E")]
		[FieldOffset(Offset = "0x29")]
		private bool _stipplingIn;

		// Token: 0x0400197F RID: 6527
		[Token(Token = "0x400197F")]
		[FieldOffset(Offset = "0x2C")]
		private float _alpha;

		// Token: 0x04001980 RID: 6528
		[Token(Token = "0x4001980")]
		[FieldOffset(Offset = "0x30")]
		private MaterialPropertyBlock _block;
	}
}
