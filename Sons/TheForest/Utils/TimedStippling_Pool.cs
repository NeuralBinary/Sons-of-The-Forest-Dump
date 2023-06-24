using System;
using Il2CppDummyDll;
using PathologicalGames;
using UnityEngine;

namespace TheForest.Utils
{
	// Token: 0x020003CD RID: 973
	[Token(Token = "0x20003CD")]
	public class TimedStippling_Pool : MonoBehaviour
	{
		// Token: 0x06001AA0 RID: 6816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AA0")]
		[Address(RVA = "0x32A56A0", Offset = "0x32A3CA0", VA = "0x1832A56A0")]
		private void Awake()
		{
		}

		// Token: 0x06001AA1 RID: 6817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AA1")]
		[Address(RVA = "0x32A58E0", Offset = "0x32A3EE0", VA = "0x1832A58E0")]
		private void Update()
		{
		}

		// Token: 0x06001AA2 RID: 6818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AA2")]
		[Address(RVA = "0x32A5A90", Offset = "0x32A4090", VA = "0x1832A5A90")]
		private void OnEnable()
		{
		}

		// Token: 0x06001AA3 RID: 6819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AA3")]
		[Address(RVA = "0x32A5AC0", Offset = "0x32A40C0", VA = "0x1832A5AC0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001AA4 RID: 6820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AA4")]
		[Address(RVA = "0x32A5AD0", Offset = "0x32A40D0", VA = "0x1832A5AD0")]
		public void OnSpawned()
		{
		}

		// Token: 0x06001AA5 RID: 6821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AA5")]
		[Address(RVA = "0x32A5CC0", Offset = "0x32A42C0", VA = "0x1832A5CC0")]
		public void OnDespawned(SpawnPool pool)
		{
		}

		// Token: 0x06001AA6 RID: 6822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AA6")]
		[Address(RVA = "0x32A5DE0", Offset = "0x32A43E0", VA = "0x1832A5DE0")]
		private void SkipStippling()
		{
		}

		// Token: 0x06001AA7 RID: 6823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AA7")]
		[Address(RVA = "0x32A5E50", Offset = "0x32A4450", VA = "0x1832A5E50")]
		private void SetStipplingAlpha(float alpha)
		{
		}

		// Token: 0x06001AA8 RID: 6824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AA8")]
		[Address(RVA = "0x32A5FB0", Offset = "0x32A45B0", VA = "0x1832A5FB0")]
		private void Stop()
		{
		}

		// Token: 0x06001AA9 RID: 6825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AA9")]
		[Address(RVA = "0x32A6020", Offset = "0x32A4620", VA = "0x1832A6020")]
		private void VisibilityCheck()
		{
		}

		// Token: 0x06001AAA RID: 6826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AAA")]
		[Address(RVA = "0x32A6180", Offset = "0x32A4780", VA = "0x1832A6180")]
		private void BeginStipplingIn()
		{
		}

		// Token: 0x06001AAB RID: 6827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AAB")]
		[Address(RVA = "0x32A61F0", Offset = "0x32A47F0", VA = "0x1832A61F0")]
		private void WSRegister()
		{
		}

		// Token: 0x06001AAC RID: 6828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AAC")]
		[Address(RVA = "0x32A6340", Offset = "0x32A4940", VA = "0x1832A6340")]
		private void WSUnregister()
		{
		}

		// Token: 0x06001AAD RID: 6829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AAD")]
		[Address(RVA = "0x32A63C0", Offset = "0x32A49C0", VA = "0x1832A63C0")]
		public TimedStippling_Pool()
		{
		}

		// Token: 0x040019AD RID: 6573
		[Token(Token = "0x40019AD")]
		[FieldOffset(Offset = "0x20")]
		public Renderer _renderer;

		// Token: 0x040019AE RID: 6574
		[Token(Token = "0x40019AE")]
		[FieldOffset(Offset = "0x28")]
		public bool _ignoreVisibleCheck;

		// Token: 0x040019AF RID: 6575
		[Token(Token = "0x40019AF")]
		[FieldOffset(Offset = "0x29")]
		private bool _stipplingIn;

		// Token: 0x040019B0 RID: 6576
		[Token(Token = "0x40019B0")]
		[FieldOffset(Offset = "0x2C")]
		private float _alpha;

		// Token: 0x040019B1 RID: 6577
		[Token(Token = "0x40019B1")]
		[FieldOffset(Offset = "0x30")]
		private MaterialPropertyBlock _block;

		// Token: 0x040019B2 RID: 6578
		[Token(Token = "0x40019B2")]
		[FieldOffset(Offset = "0x38")]
		private int _wsToken;
	}
}
