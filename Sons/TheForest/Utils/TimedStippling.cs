using System;
using Il2CppDummyDll;
using PathologicalGames;
using UnityEngine;

namespace TheForest.Utils
{
	// Token: 0x020003CB RID: 971
	[Token(Token = "0x20003CB")]
	public class TimedStippling : MonoBehaviour
	{
		// Token: 0x06001A8A RID: 6794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A8A")]
		[Address(RVA = "0x32A3EE0", Offset = "0x32A24E0", VA = "0x1832A3EE0")]
		private void Awake()
		{
		}

		// Token: 0x06001A8B RID: 6795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A8B")]
		[Address(RVA = "0x32A4120", Offset = "0x32A2720", VA = "0x1832A4120")]
		private void Update()
		{
		}

		// Token: 0x06001A8C RID: 6796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A8C")]
		[Address(RVA = "0x32A42C0", Offset = "0x32A28C0", VA = "0x1832A42C0")]
		private void OnEnable()
		{
		}

		// Token: 0x06001A8D RID: 6797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A8D")]
		[Address(RVA = "0x32A42F0", Offset = "0x32A28F0", VA = "0x1832A42F0")]
		private void ResetStippling()
		{
		}

		// Token: 0x06001A8E RID: 6798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A8E")]
		[Address(RVA = "0x32A43C0", Offset = "0x32A29C0", VA = "0x1832A43C0")]
		private void StippleOut()
		{
		}

		// Token: 0x06001A8F RID: 6799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A8F")]
		[Address(RVA = "0x32A4480", Offset = "0x32A2A80", VA = "0x1832A4480")]
		private void OnDespawned(SpawnPool pool)
		{
		}

		// Token: 0x06001A90 RID: 6800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A90")]
		[Address(RVA = "0x32A45F0", Offset = "0x32A2BF0", VA = "0x1832A45F0")]
		private void SkipStippling()
		{
		}

		// Token: 0x06001A91 RID: 6801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A91")]
		[Address(RVA = "0x32A4660", Offset = "0x32A2C60", VA = "0x1832A4660")]
		private void SetStipplingAlpha(float alpha)
		{
		}

		// Token: 0x06001A92 RID: 6802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A92")]
		[Address(RVA = "0x32A45F0", Offset = "0x32A2BF0", VA = "0x1832A45F0")]
		private void Stop()
		{
		}

		// Token: 0x06001A93 RID: 6803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A93")]
		[Address(RVA = "0x656600", Offset = "0x654C00", VA = "0x180656600")]
		public TimedStippling()
		{
		}

		// Token: 0x040019A0 RID: 6560
		[Token(Token = "0x40019A0")]
		[FieldOffset(Offset = "0x20")]
		public Renderer _renderer;

		// Token: 0x040019A1 RID: 6561
		[Token(Token = "0x40019A1")]
		[FieldOffset(Offset = "0x28")]
		public bool _handleRendererState;

		// Token: 0x040019A2 RID: 6562
		[Token(Token = "0x40019A2")]
		[FieldOffset(Offset = "0x29")]
		private bool _stipplingIn;

		// Token: 0x040019A3 RID: 6563
		[Token(Token = "0x40019A3")]
		[FieldOffset(Offset = "0x2C")]
		private float _alpha;

		// Token: 0x040019A4 RID: 6564
		[Token(Token = "0x40019A4")]
		[FieldOffset(Offset = "0x30")]
		private MaterialPropertyBlock _block;
	}
}
